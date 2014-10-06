using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class form_main : Form
    {

        #region Start

        public form_main()
        {
            InitializeComponent();
            this.Load += form_main_Load;
            this.listView_homework.DoubleClick += listView_homework_DoubleClick;
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            XmlDocument homework = this.RequestList();
            this.ProcessList(homework);
            this.Reorder();
        }

        #endregion

        #region Magie

        private XmlDocument RequestList()
        {
            XmlDocument homeworkDocument = new XmlDocument();
            homeworkDocument.Load("Homework.xml");
            return homeworkDocument;
        }

        private void ProcessList(XmlDocument document)
        {
            var homeworkList = new List<HomeworkEntry>();
            var culture = System.Globalization.CultureInfo.GetCultureInfo("de-DE");
            XmlNode mainNode = document["homework"];
            foreach (XmlNode node in mainNode)
            {
                if (node.NodeType == XmlNodeType.Element && node.Name.ToLower().Equals("entry"))
                {
                    int id = int.Parse(node.Attributes["id"].Value);
                    string title = node["title"].InnerText;
                    DateTime expires = DateTime.Parse(node["expires"].InnerText, culture);
                    string content = node["content"].InnerText;
                    string owner = node["owner"].InnerText;
                    string subject = node["subject"].InnerText;

                    homeworkList.Add(new HomeworkEntry(id, title, owner, subject, expires, content));
                }
            }
            this._homework = homeworkList.ToArray();
            this.Reorder();
        }

        public void CreateTab(int id, string title, string defaultText = "")
        {
            TextBox textBox_homeworkNew = new TextBox();
            textBox_homeworkNew.Multiline = true;
            textBox_homeworkNew.Dock = DockStyle.Fill;
            textBox_homeworkNew.Text = defaultText;

            ArgumentedTabPage page = new ArgumentedTabPage();
            page.Text = title;
            page.SetIndex(id);
            page.Controls.Add(textBox_homeworkNew);
            tabControl1.Controls.Add(page);
        }

        public void CreateListEntry(int id, string title, string subject, string owner, DateTime expires)
        {
            ArgumentedListViewItem lvi = new ArgumentedListViewItem();
            lvi.Text = title;
            lvi.SetIndex(id);
            //lvi.SubItems.Add(title);
            lvi.SubItems.Add(owner);
            lvi.SubItems.Add(subject);
            lvi.SubItems.Add(expires.ToString());
            listView_homework.Items.Add(lvi);
        }

        /// <summary>
        /// Internes _homework array anhand kriterien neu sortieren und an listview bringen
        /// </summary>
        /// <param name="doPrint"></param>
        private void Reorder(bool doPrint = true)
        {
            if (_showAll)
            {
                if (_sorting)
                    this._homeworkOrdered = (from HomeworkEntry hwe in this._homework orderby hwe.Expires ascending select hwe).ToArray();
                else
                    this._homeworkOrdered = (from HomeworkEntry hwe in this._homework orderby hwe.Expires descending select hwe).ToArray();
            }
            else
            {
                if (_sorting)
                    this._homeworkOrdered = (from HomeworkEntry hwe in this._homework where hwe.Expires > DateTime.Now orderby hwe.Expires ascending select hwe).ToArray();
                else
                    this._homeworkOrdered = (from HomeworkEntry hwe in this._homework where hwe.Expires > DateTime.Now orderby hwe.Expires descending select hwe).ToArray();
            }
            if (doPrint)
            {
                this.listView_homework.BeginUpdate();
                this.listView_homework.Items.Clear();
                foreach (HomeworkEntry hwe in this._homeworkOrdered)
                    CreateListEntry(hwe.Id, hwe.Title, hwe.Subject, hwe.Owner, hwe.Expires);
                this.listView_homework.EndUpdate();
            }
        }

        #endregion

        #region Members

        private HomeworkEntry[] _homework;
        private HomeworkEntry[] _homeworkOrdered;
        private bool _sorting;
        private bool _showAll;

        #endregion

        #region Control Handler

        /// <summary>
        /// Neue Hausaufgaben hinzufügen (Fenster öffnen)
        /// </summary>
        private void button_add_Click(object sender, EventArgs e)
        {
            new form_new().ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Sortiere nach Ablaufdatum / toggle
        /// </summary>
        private void button_sortByExpireDate_Click(object sender, EventArgs e)
        {
            this.Reorder();
            this._sorting = !this._sorting;

        }

        /// <summary>
        /// Öffne Tab oder wechsle zu existierenden Tab
        /// </summary>
        private void listView_homework_DoubleClick(object sender, System.EventArgs e)
        {
            if (listView_homework.SelectedItems.Count == 1)
            {
                int selectedIndex = ((ArgumentedListViewItem)listView_homework.SelectedItems[0]).Index;
                HomeworkEntry entry = this._homeworkOrdered.Where(x => x.Id == selectedIndex).FirstOrDefault();
                if (entry == null)
                    return; // FEHLER FEHLER FEHLER!!1 11eins!
                var existingTab = (from ArgumentedTabPage elem in this.tabControl1.Controls where elem.Index == selectedIndex select elem).FirstOrDefault();
                if (existingTab != null)
                    tabControl1.SelectedTab = existingTab;
                else
                    CreateTab(selectedIndex, entry.Title, entry.Content);
            }
        }

        /// <summary>
        /// Zeige alle oder nur noch nicht abgelaufene Hausaufgaben an
        /// </summary>
        private void checkBox_showAll_CheckedChanged(object sender, EventArgs e)
        {
            this._showAll = this.checkBox_showAll.Checked;
            this.Reorder();
        }

        #endregion

        private void button_done_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guck nochmal in 2 Wochen nach");
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Daten werden nicht gelöscht\n#NSA");
        }

    }
}
