using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace LIBRARY_INFO_SYSTEM
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ARE YOU SURE YOU WANT TO CANCEL?? ", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (bookname.Text != "" && bookauthor.Text != "" && bookpublicated.Text != "" && bookprice.Text != "" && bookquantity.Text != "" )
            {
                String bname = bookname.Text;
                String bauthor = bookauthor.Text;
                String bpublicated = bookpublicated.Text;
                String bdate = dateTimePicker1.Text;
                Int64 bprice = Int64.Parse(bookprice.Text);
                Int64 bquantity = Int64.Parse(bookquantity.Text);

                string MySQLConnectionString = "datasource = 127.0.0.1;port= 3306; username = root; password=;database = library";
                MySqlConnection con = new MySqlConnection(MySQLConnectionString);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into Newbook (bName,bAuthor,bPubl,bPdate,bPrice,bQuan) values ('" + bname + "','" + bauthor + "','" + bpublicated + "','" + bdate + "'," + bprice + "," + bquantity + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("DATA SAVED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bookname.Clear();
                bookauthor.Clear();
                bookpublicated.Clear();
                bookprice.Clear();
                bookquantity.Clear();
            }
            else
            {
                MessageBox.Show("EMPTY FIELD IS NOT ALLOWED", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }






        }
    }
}
