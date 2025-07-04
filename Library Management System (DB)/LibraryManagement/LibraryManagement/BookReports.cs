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

namespace LibraryManagement
{
    public partial class BookReports : Form
    {
        public BookReports()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookReports_Load(object sender, EventArgs e)
        {
            string connectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database = Library; integrated security = True";
            string query = "SELECT TOP 1 b.ISBN, b.TITLE, b.NUMCOPIES FROM BOOK b ORDER BY b.NUMCOPIES DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            string query2 = @"SELECT GENRE, COUNT(*) AS NumBooks FROM BOOK GROUP BY GENRE;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query2, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView3.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the book name from the user input
            string bookName = textBox1.Text.Trim();
            UpdateStatus(bookName);
        }

        private void UpdateStatus(string bookName)
        {
            // Connection string
            string connectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database = Library; integrated security = True";

            // SQL query with parameter
            string query = @"SELECT CASE WHEN EXISTS (
                                    SELECT 1
                                    FROM [UPDATE] u
                                    INNER JOIN BOOK b ON u.ISBN = b.ISBN
                                    WHERE b.TITLE = @BookName
                                ) THEN 'Updated'
                                ELSE 'Not Updated'
                                END AS UpdateStatus;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameter
                    cmd.Parameters.AddWithValue("@BookName", bookName);

                    try
                    {
                        conn.Open();

                        // Execute scalar query
                        object result = cmd.ExecuteScalar();

                        // Display result
                        MessageBox.Show($"Book '{bookName}' Update Status: {result}", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

