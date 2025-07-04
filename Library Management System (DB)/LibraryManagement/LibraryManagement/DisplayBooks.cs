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
using System.Transactions;

namespace LibraryManagement
{
    public partial class DisplayBooks : Form
    {
        public DisplayBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void DisplayBooks_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database = Library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from BOOK";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];



        }
        string bISBN;
        string rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bISBN = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel1.Visible = true;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database = Library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from BOOK where ISBN ='" + bISBN + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = ds.Tables[0].Rows[0][0].ToString();
            textBox6.Text = ds.Tables[0].Rows[0][4].ToString();
            textBox4.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox5.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox7.Text = ds.Tables[0].Rows[0][5].ToString();
            textBox8.Text = ds.Tables[0].Rows[0][6].ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database = Library;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from BOOK where TITLE LIKE '" + textBox1.Text + "%'";
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
                cmd.CommandText = "select * from BOOK";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string TITLE = textBox6.Text;
            string GENRE = textBox4.Text;
            Int64 PUBLICATIONYEAR = Int64.Parse(textBox5.Text);
            Int64 PRICE = Int64.Parse(textBox7.Text);
            Int64 NUMCOPIES = Int64.Parse(textBox8.Text);


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = HP-ZBOOK\\SQLEXPRESS; database = Library; integrated security = True";

            try
            {
                conn.Open();

                // Update the BOOK table
                SqlCommand cmdUpdateBook = new SqlCommand();
                cmdUpdateBook.Connection = conn;
                cmdUpdateBook.CommandText = "UPDATE BOOK SET TITLE = @TITLE, GENRE = @GENRE, PUBLISHYEAR = @PUBLISHYEAR, PRICE = @PRICE, NUMCOPIES = @NUMCOPIES,ADMINID=@ADMINID WHERE ISBN = @ISBN";
                cmdUpdateBook.Parameters.AddWithValue("@TITLE", TITLE);
                cmdUpdateBook.Parameters.AddWithValue("@ADMINID", 3);
                cmdUpdateBook.Parameters.AddWithValue("@GENRE", GENRE);
                cmdUpdateBook.Parameters.AddWithValue("@PUBLISHYEAR", PUBLICATIONYEAR);
                cmdUpdateBook.Parameters.AddWithValue("@PRICE", PRICE);
                cmdUpdateBook.Parameters.AddWithValue("@NUMCOPIES", NUMCOPIES);
                cmdUpdateBook.Parameters.AddWithValue("@ISBN", rowid);
                cmdUpdateBook.ExecuteNonQuery();

                SqlCommand cmdCheckUpdate = new SqlCommand();
                cmdCheckUpdate.Connection = conn;
                cmdCheckUpdate.CommandText = "IF EXISTS (SELECT 1 FROM [UPDATE] WHERE ADMINID = @ADMINID AND ISBN = @ISBN) " +
                                             "UPDATE [UPDATE] SET UPDATETYPE = 'Changed Data' WHERE ADMINID = @ADMINID AND ISBN = @ISBN " +
                                             "ELSE " +
                                             "INSERT INTO [UPDATE] (ADMINID, ISBN) VALUES (@ADMINID, @ISBN)";
                cmdCheckUpdate.Parameters.AddWithValue("@ADMINID", 3); // Set the admin ID
                cmdCheckUpdate.Parameters.AddWithValue("@ISBN", rowid);
                cmdCheckUpdate.ExecuteNonQuery();

                MessageBox.Show("Book Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("data source=HP-ZBOOK\\SQLEXPRESS;database=Library;integrated security=True"))
            {
                // Confirmation message before deleting
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();

                        // Start a transaction
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                // Delete from WRITE table
                                using (SqlCommand cmdDeleteWrite = new SqlCommand("DELETE FROM WRITE WHERE ISBN = @ISBN", conn, transaction))
                                {
                                    cmdDeleteWrite.Parameters.AddWithValue("@ISBN", rowid);
                                    cmdDeleteWrite.ExecuteNonQuery();
                                }

                                // Delete from UPDATE table
                                using (SqlCommand cmdDeleteUpdate = new SqlCommand("DELETE FROM [UPDATE] WHERE ISBN = @ISBN", conn, transaction))
                                {
                                    cmdDeleteUpdate.Parameters.AddWithValue("@ISBN", rowid);
                                    cmdDeleteUpdate.ExecuteNonQuery();
                                }

                                // Delete from BOOKCOPY table
                                using (SqlCommand cmdDeleteBookCopy = new SqlCommand("DELETE FROM BOOKCOPY WHERE ISBN = @ISBN", conn, transaction))
                                {
                                    cmdDeleteBookCopy.Parameters.AddWithValue("@ISBN", rowid);
                                    cmdDeleteBookCopy.ExecuteNonQuery();
                                }

                                // Delete from BOOK table
                                using (SqlCommand cmdDeleteBook = new SqlCommand("DELETE FROM BOOK WHERE ISBN = @ISBN", conn, transaction))
                                {
                                    cmdDeleteBook.Parameters.AddWithValue("@ISBN", rowid);
                                    cmdDeleteBook.ExecuteNonQuery();
                                }

                                // Commit the transaction
                                transaction.Commit();

                                MessageBox.Show("Book and related records deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                // Rollback the transaction in case of an error
                                transaction.Rollback();
                                MessageBox.Show("An error occurred during deletion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
