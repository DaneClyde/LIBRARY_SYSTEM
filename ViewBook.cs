using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LIBRARY_INFO_SYSTEM
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }
        int BID;
        Int64 rowid;

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            string MySQLConnectionString = "datasource = 127.0.0.1;port= 3306; username = root; password=;database = library";
            MySqlConnection con = new MySqlConnection(MySQLConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * from Newbook";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                BID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel3.Visible = true;

            string MySQLConnectionString = "datasource = 127.0.0.1;port= 3306; username = root; password=;database = library";
            MySqlConnection con = new MySqlConnection(MySQLConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * from Newbook where bId= "+BID+"";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            tbname.Text = ds.Tables[0].Rows[0][1].ToString();
            tbauthor.Text = ds.Tables[0].Rows[0][2].ToString();
            tbpublicated.Text = ds.Tables[0].Rows[0][3].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0][4].ToString();
            tbprice.Text = ds.Tables[0].Rows[0][5].ToString();
            tbquantity.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            if (tbsearch.Text != null)
            {
                string MySQLConnectionString = "datasource = 127.0.0.1;port= 3306; username = root; password=;database = library";
                MySqlConnection con = new MySqlConnection(MySQLConnectionString);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * from Newbook where bName LIKE '"+tbsearch.Text+"%'";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                string MySQLConnectionString = "datasource = 127.0.0.1;port= 3306; username = root; password=;database = library";
                MySqlConnection con = new MySqlConnection(MySQLConnectionString);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * from Newbook";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            tbsearch.Clear();
            panel3.Visible = false;
            refre();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ARE YOU SURE YOU WILL UPDATE THE DATA??", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String bname = tbname.Text;
                String bauthor = tbauthor.Text;
                String bpublicated = tbpublicated.Text;
                String bdate = dateTimePicker1.Text;
                Int64 bprice = Int64.Parse(tbprice.Text);
                Int64 bquantity = Int64.Parse(tbquantity.Text);

                string MySQLConnectionString = "datasource = 127.0.0.1;port= 3306; username = root; password=;database = library";
                MySqlConnection con = new MySqlConnection(MySQLConnectionString);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update Newbook set bName ='" + bname + "',bAuthor = '" + bauthor + "',bPubl = '" + bpublicated + "', bPdate = '" + bdate + "', bPrice = " + bprice + ", bQuan = " + bquantity + " where bId = " + rowid + " ";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
           }


        }
        public void refre()
        {
            string MySQLConnectionString = "datasource = 127.0.0.1;port= 3306; username = root; password=;database = library";
            MySqlConnection con = new MySqlConnection(MySQLConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * from Newbook";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"library");

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS DATA??", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                

                string MySQLConnectionString = "datasource = 127.0.0.1;port= 3306; username = root; password=;database = library";
                MySqlConnection con = new MySqlConnection(MySQLConnectionString);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " delete from Newbook WHERE bId="+rowid+"";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
    }
}
