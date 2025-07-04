using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class AddBookCopy : Form
    {
        public AddBookCopy()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bisbn = textBox1.Text;
            string bstatus = textBox2.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database = Library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into BOOKCOPY(ISBN, STATUS) values('" + bisbn + "', '" + bstatus + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Book Copy Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
