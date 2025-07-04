using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Dashboard2 : Form
    {
        public Dashboard2()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookReports br = new BookReports();
            br.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentReports sr = new StudentReports();
            sr.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Join j = new Join();
            j.Show();
        }
    }
}
