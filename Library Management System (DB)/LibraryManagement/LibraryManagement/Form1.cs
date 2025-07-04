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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database=Library; integrated security=True";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = "select * from REGISTRATION where EMAIL= '" + textBox1.Text + "' and PASSWORD= '" + textBox2.Text + "' ";

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                int userId = (int)ds.Tables[0].Rows[0]["USERID"];
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Dasboard dashboard = new Dasboard(userId); // Pass userId to MainForm
                dashboard.Show();
            }

            else


                MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source=HP-ZBOOK\\SQLEXPRESS; database=Library; integrated security=True"))
            {
                SqlCommand cmd = new SqlCommand(@"
            INSERT INTO REGISTRATION (PASSWORD, EMAIL)
            VALUES (@Password, @Email);
            SELECT SCOPE_IDENTITY();
        ", con);

                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                cmd.Parameters.AddWithValue("@Email", textBox1.Text);

                try
                {
                    con.Open();
                    int userId = Convert.ToInt32(cmd.ExecuteScalar());
                    MessageBox.Show("User signed up successfully with USERID: " + userId);

                    // After obtaining the userId, you can proceed with other actions
                    // For example, you might open the AddStudent form with this userId
                    AddStudent addStudentForm = new AddStudent(userId);
                    addStudentForm.Show();


                    // or this.Close() if you want to close the signup form
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}