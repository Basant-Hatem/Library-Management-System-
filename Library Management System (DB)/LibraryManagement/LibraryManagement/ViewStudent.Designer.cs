namespace LibraryManagement
{
    partial class ViewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudent));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(573, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(538, 770);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 1;
            label1.Text = "View Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 61);
            label2.Name = "label2";
            label2.Size = new Size(145, 23);
            label2.TabIndex = 2;
            label2.Text = "Student Name ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(470, 61);
            button1.Name = "button1";
            button1.Size = new Size(86, 29);
            button1.TabIndex = 4;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(565, 216);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox11);
            panel1.Controls.Add(textBox10);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(2, 348);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 426);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(426, 385);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 18;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(268, 385);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(268, 336);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(252, 27);
            textBox11.TabIndex = 17;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(268, 299);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(252, 27);
            textBox10.TabIndex = 16;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(268, 266);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(252, 27);
            textBox9.TabIndex = 15;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(268, 228);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(252, 27);
            textBox8.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(268, 189);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(252, 27);
            textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(268, 151);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(252, 27);
            textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(268, 115);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(252, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(268, 82);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(252, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(268, 45);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(252, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(268, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 27);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(22, 336);
            label12.Name = "label12";
            label12.Size = new Size(93, 20);
            label12.TabIndex = 7;
            label12.Text = "Student Age";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(22, 303);
            label11.Name = "label11";
            label11.Size = new Size(132, 20);
            label11.TabIndex = 6;
            label11.Text = "Student Birth-Day";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(22, 270);
            label9.Name = "label9";
            label9.Size = new Size(151, 20);
            label9.TabIndex = 5;
            label9.Text = "Student Birth-Month";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(22, 232);
            label10.Name = "label10";
            label10.Size = new Size(135, 20);
            label10.TabIndex = 4;
            label10.Text = "Student Birth-Year";
            label10.Click += label10_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(22, 159);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 4;
            label8.Text = "Student City";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(22, 197);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 4;
            label7.Text = "Student Street";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 121);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 3;
            label6.Text = "Student Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 82);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 2;
            label5.Text = "Student Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 45);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 1;
            label4.Text = "Student PhoneNumber";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 14);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            label3.Click += label3_Click;
            // 
            // ViewStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1126, 614);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ViewStudent";
            Text = "ViewStudent";
            Load += ViewStudent_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label3;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label12;
        private Label label11;
        private Label label9;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private Button button3;
        private Button button2;
    }
}