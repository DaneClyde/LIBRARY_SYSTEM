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
    public partial class menuform : Form
    {
        public menuform()
        {
            InitializeComponent();
        }

        private void vEIWBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "AddBook")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }

            }
            if (Isopen == false)
            {
                ViewBook anb = new ViewBook();
                anb.Show();
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("Are you sure You want to exit?", "WARNING", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit ();
            }
        }

        private void aDDBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if(f.Text == "AddBook")
                { 
                Isopen = true;
                f.BringToFront();
                break;
                }

            }
            if (Isopen == false)
            {
                AddBook anb = new AddBook();
                anb.Show();
            }
        }
    }
}
