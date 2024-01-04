using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_INFO_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string name, pass;
            name = tbusername.Text;
            pass = tbpassword.Text;
            if (string.IsNullOrEmpty(tbusername.Text) || string.IsNullOrEmpty(tbpassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else if (name == "daneclyde" && pass == "12345")
            {
                
                this.Hide();
                menuform frm2 = new menuform();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("INVALID USERNAME OR PASSWORD !!!!", "Error");
                tbusername.Clear();
                tbpassword.Clear();
            }
        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
