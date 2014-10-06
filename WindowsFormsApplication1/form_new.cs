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
    public partial class form_new : Form
    {
        public form_new()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            ServerInterface.GetInstance().SendNewHomework(this.textBox_title.Text, this.textBox_content.Text, this.dateTimePicker_expire.Value);
            MessageBox.Show(this, "Neue Hausaufgaben an den Server gesendet", "Neue Hausaufgaben", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
