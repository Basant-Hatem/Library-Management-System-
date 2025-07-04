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
using System.Xml.Linq;

namespace LibraryManagement
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bisbn = textBox1.Text;
            string bname = textBox2.Text;
            string bGenre = textBox3.Text;
            Int64 bPublishingYear = Int64.Parse(textBox4.Text);
            Int64 bPrice = Int64.Parse(textBox5.Text);
            bool Status = true;
            string authorName = textBox7.Text; // Assuming textBox7 contains the author's name

            // Establish connection
            using (SqlConnection conn = new SqlConnection("data source = HP-ZBOOK\\SQLEXPRESS; database = Library;integrated security = True"))

            {
                conn.Open();

                // Check if the author already exists
                SqlCommand checkAuthorCmd = new SqlCommand("SELECT AUTHORID FROM AUTHOR WHERE NAME = @AuthorName", conn);
                checkAuthorCmd.Parameters.AddWithValue("@AuthorName", authorName);
                object authorId = checkAuthorCmd.ExecuteScalar();

                // If the author doesn't exist, insert them into the AUTHOR table
                if (authorId == null)
                {
                    SqlCommand insertAuthorCmd = new SqlCommand("INSERT INTO AUTHOR (NAME) VALUES (@AuthorName); SELECT SCOPE_IDENTITY();", conn);
                    insertAuthorCmd.Parameters.AddWithValue("@AuthorName", authorName);
                    authorId = insertAuthorCmd.ExecuteScalar();
                }
               
                // Insert book information into the BOOK table
                SqlCommand insertBookCmd = new SqlCommand("INSERT INTO BOOK (ADMINID,ISBN, PUBLISHYEAR, GENRE, TITLE, PRICE) VALUES (@ADMINID,@ISBN, @PUBLISHYEAR, @GENRE, @TITLE, @PRICE)", conn);
                insertBookCmd.Parameters.AddWithValue("@ISBN", bisbn);
                insertBookCmd.Parameters.AddWithValue("@ADMINID", 3);
                insertBookCmd.Parameters.AddWithValue("@PUBLISHYEAR", bPublishingYear);
                insertBookCmd.Parameters.AddWithValue("@GENRE", bGenre);
                insertBookCmd.Parameters.AddWithValue("@TITLE", bname);
                insertBookCmd.Parameters.AddWithValue("@PRICE", bPrice);
               

                insertBookCmd.ExecuteNonQuery();

                // Insert the relationship between the book and the author into the WRITE table
                SqlCommand insertWriteCmd = new SqlCommand("INSERT INTO WRITE (ISBN, AUTHORID) VALUES (@ISBN, @AuthorId)", conn);
                insertWriteCmd.Parameters.AddWithValue("@ISBN", bisbn);
                insertWriteCmd.Parameters.AddWithValue("@AuthorId", authorId);
                insertWriteCmd.ExecuteNonQuery();
                SqlCommand insertbookcopyCmd = new SqlCommand("INSERT INTO BOOKCOPY (STATUS,ISBN) VALUES (@STATUS,@ISBN); SELECT SCOPE_IDENTITY();", conn);

                insertbookcopyCmd.Parameters.AddWithValue("@STATUS", Status);
                insertbookcopyCmd.Parameters.AddWithValue("@ISBN", bisbn);
                insertbookcopyCmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Data saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
