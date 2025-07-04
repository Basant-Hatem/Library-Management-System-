using Microsoft.VisualBasic.ApplicationServices;
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

    public partial class Dasboard : Form
    {
        private int UserId;

        public Dasboard(int userId)
        {
            InitializeComponent();
            this.UserId = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Dasboard_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void exToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks abs = new AddBooks();
            abs.Show();
        }

        private void displayBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBooks abs = new DisplayBooks();
            abs.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudentForm = new AddStudent(this.UserId); // Pass userId to AddStudent form
            addStudentForm.Show();
        }

        private void viewStudentIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent vst = new ViewStudent();
            vst.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void addBookCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookCopy abc = new AddBookCopy();
            abc.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dashboard2 d = new Dashboard2();
            d.Show();
        }
    }
}
