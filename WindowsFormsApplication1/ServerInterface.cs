using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public class ServerInterface
    {

        #region Constants, Singleton, Constructor

        public static readonly string ServerAddress = "localhost";

        private static ServerInterface _instance;
        private static object _instanceLock = new object();
        public static ServerInterface GetInstance()
        {
            if(_instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                        _instance = new ServerInterface();
                }
            }
            return _instance;
        }

        public ServerInterface()
        {
            IPAddress addr = Dns.GetHostAddresses(ServerAddress).FirstOrDefault();
            this.RemoteEndPoint = new IPEndPoint(addr, 1337);
            this._restSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            this._restSocket.Connect(this.RemoteEndPoint);
            this._beginReceive();
        }

        #endregion

        #region Members

        public string Username { get; private set; }
        public bool IsAuthenticated { get; private set; }

        private Socket _restSocket;
        public IPEndPoint RemoteEndPoint { get; private set; }
        private byte[] _receiveBuffer;

        #endregion

        #region Methods

        public void SetUsername(string username)
        {
            this.Username = username;
            this.IsAuthenticated = !string.IsNullOrEmpty(username);
        }

        private void _beginReceive()
        {
            if (this._restSocket.Connected)
                this._restSocket.BeginReceive(this._receiveBuffer, 0, this._receiveBuffer.Length, SocketFlags.None, this._IOnReceive, null);
        }
        private void _IOnReceive(IAsyncResult ar)
        {
            int recvLen = 0;
            try
            {
                this._restSocket.EndReceive(ar);
            }
            catch { }
            if (recvLen > 0)
            {
                byte[] received = new byte[recvLen];
                Array.Copy(_receiveBuffer, 0, received, 0, received.Length);
                string receivedStr = Encoding.UTF8.GetString(received);
                System.Windows.Forms.MessageBox.Show(receivedStr, "EMPFANGEN");
                // fire event
                this._beginReceive();
            }
            else
            {
                this._restSocket.Shutdown(SocketShutdown.Both);
                this._restSocket.Disconnect(true);
            }
        }

        public void Send(byte[] data)
        {
            this._restSocket.Send(data, 0, data.Length, SocketFlags.None);
        }
        public void Send(string data)
        {
            this.Send(Encoding.UTF8.GetBytes(data));
        }

        public void SendNewHomework(string title, string content, DateTime expireDate)
        {
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri("http://" + ServerAddress + "/magie"));
            request.Method = "PUT";
            request.ContentType = "application/x-www-form-urlencoded";
            byte[] requestData = Encoding.UTF8.GetBytes(string.Format("title={0}&content={1}", System.Web.HttpUtility.UrlEncode(title), System.Web.HttpUtility.UrlEncode(content)));
            request.ContentLength = requestData.Length;
            using(var binaryWriter = new System.IO.BinaryWriter(request.GetRequestStream()))
            {
                binaryWriter.Write(requestData, 0, requestData.Length);
                binaryWriter.Close();
            }

            // get response! actually useless
        }

        #endregion


    }
}
