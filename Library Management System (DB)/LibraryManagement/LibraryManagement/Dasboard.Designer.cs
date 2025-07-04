namespace LibraryManagement
{
    partial class Dasboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dasboard));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBookToolStripMenuItem = new ToolStripMenuItem();
            addBookCopyToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentIDToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            addAdminToolStripMenuItem = new ToolStripMenuItem();
            displayBooksToolStripMenuItem = new ToolStripMenuItem();
            exToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentToolStripMenuItem, adminToolStripMenuItem, displayBooksToolStripMenuItem, exToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(638, 39);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.BackColor = Color.LightGray;
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBookToolStripMenuItem, addBookCopyToolStripMenuItem });
            booksToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            booksToolStripMenuItem.ForeColor = Color.DimGray;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(100, 35);
            booksToolStripMenuItem.Text = "Books";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // addNewBookToolStripMenuItem
            // 
            addNewBookToolStripMenuItem.ForeColor = Color.MidnightBlue;
            addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            addNewBookToolStripMenuItem.Size = new Size(280, 34);
            addNewBookToolStripMenuItem.Text = "Add New Book";
            addNewBookToolStripMenuItem.Click += addNewBookToolStripMenuItem_Click;
            // 
            // addBookCopyToolStripMenuItem
            // 
            addBookCopyToolStripMenuItem.ForeColor = Color.MidnightBlue;
            addBookCopyToolStripMenuItem.Name = "addBookCopyToolStripMenuItem";
            addBookCopyToolStripMenuItem.Size = new Size(280, 34);
            addBookCopyToolStripMenuItem.Text = "Add Book Copy";
            addBookCopyToolStripMenuItem.Click += addBookCopyToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.BackColor = Color.LightGray;
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewStudentIDToolStripMenuItem });
            studentToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            studentToolStripMenuItem.ForeColor = Color.DimGray;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(116, 35);
            studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.ForeColor = Color.MidnightBlue;
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(285, 34);
            addStudentToolStripMenuItem.Text = "Add Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // viewStudentIDToolStripMenuItem
            // 
            viewStudentIDToolStripMenuItem.ForeColor = Color.MidnightBlue;
            viewStudentIDToolStripMenuItem.Name = "viewStudentIDToolStripMenuItem";
            viewStudentIDToolStripMenuItem.Size = new Size(285, 34);
            viewStudentIDToolStripMenuItem.Text = "View Student ID";
            viewStudentIDToolStripMenuItem.Click += viewStudentIDToolStripMenuItem_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.BackColor = Color.LightGray;
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addAdminToolStripMenuItem });
            adminToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            adminToolStripMenuItem.ForeColor = Color.DimGray;
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(100, 35);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // addAdminToolStripMenuItem
            // 
            addAdminToolStripMenuItem.ForeColor = Color.MidnightBlue;
            addAdminToolStripMenuItem.Name = "addAdminToolStripMenuItem";
            addAdminToolStripMenuItem.Size = new Size(226, 34);
            addAdminToolStripMenuItem.Text = "Add Admin";
            // 
            // displayBooksToolStripMenuItem
            // 
            displayBooksToolStripMenuItem.BackColor = Color.LightGray;
            displayBooksToolStripMenuItem.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            displayBooksToolStripMenuItem.ForeColor = Color.DimGray;
            displayBooksToolStripMenuItem.Name = "displayBooksToolStripMenuItem";
            displayBooksToolStripMenuItem.Size = new Size(201, 35);
            displayBooksToolStripMenuItem.Text = "Display Books";
            displayBooksToolStripMenuItem.Click += displayBooksToolStripMenuItem_Click;
            // 
            // exToolStripMenuItem
            // 
            exToolStripMenuItem.BackColor = Color.LightGray;
            exToolStripMenuItem.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            exToolStripMenuItem.ForeColor = Color.DimGray;
            exToolStripMenuItem.Name = "exToolStripMenuItem";
            exToolStripMenuItem.Size = new Size(74, 35);
            exToolStripMenuItem.Text = "EXIT";
            exToolStripMenuItem.Click += exToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(638, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(489, 439);
            button1.Name = "button1";
            button1.Size = new Size(137, 29);
            button1.TabIndex = 17;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Dasboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(638, 480);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Dasboard";
            Text = "Dasboard";
            Load += Dasboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBookToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentIDToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem addAdminToolStripMenuItem;
        private ToolStripMenuItem displayBooksToolStripMenuItem;
        private ToolStripMenuItem exToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem addBookCopyToolStripMenuItem;
        private Button button1;
    }
}