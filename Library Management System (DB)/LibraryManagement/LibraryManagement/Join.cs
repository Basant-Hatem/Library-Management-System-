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
    public partial class Join : Form
    {
        public Join()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Join_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void LoadData(string name = null)
        {
            using (SqlConnection conn = new SqlConnection("data source = HP-ZBOOK\\SQLEXPRESS; database = Library; integrated security = True"))
            {
                string query = "SELECT s.NAME AS 'STUDENT NAME', r.PASSWORD, r.EMAIL FROM STUDENT s INNER JOIN REGISTRATION r ON s.USERID = r.USERID";
                if (!string.IsNullOrEmpty(name))
                {
                    query += " WHERE s.NAME LIKE @Name";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(name))
                    {
                        cmd.Parameters.AddWithValue("@Name", name + "%");
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            LoadData(name); // Call LoadData with the name in textbox
        }
    }
}