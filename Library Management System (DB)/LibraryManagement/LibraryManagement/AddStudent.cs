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
using Microsoft.VisualBasic.ApplicationServices;
namespace LibraryManagement
{
    public partial class AddStudent : Form
    {
        private int UserId;
        public AddStudent(int userId)
        {
            InitializeComponent();
            this.UserId = userId;

        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string NAME = textBox1.Text;
            string PHONENUMBER = textBox2.Text;
            string EMAIL = textBox3.Text;
            string COUNTRY = textBox4.Text;
            string CITY = textBox5.Text;
            string STREET = textBox6.Text;
            Int64 BIRTHYEAR = Int64.Parse(textBox7.Text);
            Int64 BIRTHMONTH = Int64.Parse(textBox8.Text);
            Int64 BIRTHDAY = Int64.Parse(textBox9.Text);
           


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database = Library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            // Use parameterized query with parameters
            cmd.CommandText = "insert into STUDENT (USERID,NAME, PHONENUMBER, EMAIL, COUNTRY, CITY, STREET, BIRTHYEAR, BIRTHMONTH, BIRTHDAY ) values (@USERID,@NAME, @PHONENUMBER, @EMAIL, @COUNTRY, @CITY, @STREET, @BIRTHYEAR, @BIRTHMONTH, @BIRTHDAY)";
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@NAME", NAME);
            cmd.Parameters.AddWithValue("@PHONENUMBER", PHONENUMBER);
            cmd.Parameters.AddWithValue("@EMAIL", EMAIL);
            cmd.Parameters.AddWithValue("@COUNTRY", COUNTRY);
            cmd.Parameters.AddWithValue("@CITY", CITY);
            cmd.Parameters.AddWithValue("@STREET", STREET);
            cmd.Parameters.AddWithValue("@BIRTHYEAR", BIRTHYEAR);
            cmd.Parameters.AddWithValue("@BIRTHMONTH", BIRTHMONTH);
            cmd.Parameters.AddWithValue("@BIRTHDAY", BIRTHDAY);
            
            


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
