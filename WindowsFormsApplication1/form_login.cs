using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
            this.textBox_username.KeyUp += textBox_username_KeyUp;
            this.textBox_password.KeyUp += textBox_username_KeyUp;
        }

        #region Buttons

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void textBox_username_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button_login.PerformClick();
                e.Handled = true;
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = this.textBox_username.Text;
            string password = this.textBox_password.Text;

            if (username == "magie" && password == "wizard")
            {
                this.Hide();
                ServerInterface.GetInstance().SetUsername(username); // authenticated

                form_main mainWindow = new form_main();
                mainWindow.ShowDialog();

                ServerInterface.GetInstance().SetUsername(null); // not authenticated
                this.Show();
            }
            else
                MessageBox.Show("Login fehlgeschlagen! Versuchs nochmal", "Login", MessageBoxButtons.OK);
        }

        #endregion

    }
}
