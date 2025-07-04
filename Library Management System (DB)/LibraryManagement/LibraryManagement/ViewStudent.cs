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
using System.Security.Cryptography;

namespace LibraryManagement
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database = Library;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from STUDENT where NAME LIKE '" + textBox1.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database = Library;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from STUDENT";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel1.Visible = false;
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database = Library;integrated security = True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from STUDENT ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int studID;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                studID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel1.Visible = true;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database = Library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from STUDENT where STUDENTID =" + studID + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            textBox2.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox3.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox4.Text = ds.Tables[0].Rows[0][4].ToString();
            textBox5.Text = ds.Tables[0].Rows[0][5].ToString();
            textBox6.Text = ds.Tables[0].Rows[0][6].ToString();
            textBox7.Text = ds.Tables[0].Rows[0][7].ToString();
            textBox8.Text = ds.Tables[0].Rows[0][10].ToString();
            textBox9.Text = ds.Tables[0].Rows[0][9].ToString();
            textBox10.Text = ds.Tables[0].Rows[0][8].ToString();
            textBox11.Text = ds.Tables[0].Rows[0][11].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string NAME = textBox2.Text;
            string PHONENUMBER = textBox3.Text;
            // Int64 PHONENUMBER = Int64.Parse(textBox3.Text);
            string EMAIL = textBox4.Text;
            string COUNTRY = textBox5.Text;
            string CITY = textBox6.Text;
            string STREET = textBox7.Text;
            Int64 BIRTHYEAR = Int64.Parse(textBox8.Text);
            Int64 BIRTHMONTH = Int64.Parse(textBox9.Text);
            Int64 BIRTHDAY = Int64.Parse(textBox10.Text);
            Int64 AGE = Int64.Parse(textBox11.Text);
            // string rowid = /* Your logic to get the ISBN value for update */; // Assuming you have logic to get the ISBN for update

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database = Library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            // Use parameterized query with parameters
            cmd.CommandText = "update STUDENT set NAME = @NAME, PHONENUMBER = @PHONENUMBER, EMAIL  = @EMAIL, COUNTRY = @COUNTRY, CITY = @CITY ,STREET = @STREET,BIRTHDAY = @BIRTHDAY , BIRTHMONTH = @BIRTHMONTH , BIRTHYEAR = @BIRTHYEAR ,AGE = @AGE where STUDENTID = @STUDENTID";
            cmd.Parameters.AddWithValue("@NAME", NAME);
            cmd.Parameters.AddWithValue("@PHONENUMBER", PHONENUMBER);
            cmd.Parameters.AddWithValue("@EMAIL", EMAIL);
            cmd.Parameters.AddWithValue("@COUNTRY", COUNTRY);
            cmd.Parameters.AddWithValue("@CITY", CITY);
            cmd.Parameters.AddWithValue("@STREET", STREET);
            cmd.Parameters.AddWithValue("@BIRTHYEAR", BIRTHYEAR);
            cmd.Parameters.AddWithValue("@BIRTHMONTH", BIRTHMONTH);
            cmd.Parameters.AddWithValue("@BIRTHDAY", BIRTHDAY);
            cmd.Parameters.AddWithValue("@AGE", AGE);
            cmd.Parameters.AddWithValue("@STUDENTID", rowid); // Assuming rowid holds the ISBN value

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Student Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database = Library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            // Use parameterized query for ISBN
            cmd.CommandText = "delete from STUDENT where STUDENTID = @STUDENTID";
            cmd.Parameters.AddWithValue("@STUDENTID", rowid);

            conn.Open();

            // Confirmation message before deleting
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during deletion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                // Do nothing if user cancels deletion
            }

            conn.Close();
        }
    }
}
