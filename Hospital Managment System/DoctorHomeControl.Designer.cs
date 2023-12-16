namespace Hospital_Managment_System
{
    partial class DoctorHomeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorHomeControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Content = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            button5 = new Button();
            buttonAddPatient = new Button();
            panel11 = new Panel();
            panel12 = new Panel();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            Content.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // Content
            // 
            Content.BackColor = Color.FromArgb(0, 7, 13);
            Content.BackgroundImage = Properties.Resources.back;
            Content.Controls.Add(panel1);
            Content.Controls.Add(button7);
            Content.Controls.Add(dataGridView1);
            Content.Controls.Add(label2);
            Content.Controls.Add(panel7);
            Content.Dock = DockStyle.Fill;
            Content.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Content.Location = new Point(0, 0);
            Content.Name = "Content";
            Content.Size = new Size(1904, 956);
            Content.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 21, 41);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(48, 522);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(2);
            panel1.Size = new Size(471, 287);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 7, 13);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(2, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(465, 190);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 171, 226);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 7, 13);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(13, 97);
            button1.Name = "button1";
            button1.Size = new Size(427, 57);
            button1.TabIndex = 3;
            button1.Text = " ADD APPOINTMENT\r\n";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 171, 226);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 7, 13);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(-396, 85);
            button2.Name = "button2";
            button2.Size = new Size(348, 57);
            button2.TabIndex = 1;
            button2.Text = "z";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(41, 171, 226);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 7, 13);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(13, 22);
            button3.Name = "button3";
            button3.Size = new Size(427, 57);
            button3.TabIndex = 1;
            button3.Text = "SHOW APPOIONTMENTS";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 21, 41);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(2, 273);
            panel3.Name = "panel3";
            panel3.Size = new Size(465, 10);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 21, 41);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(465, 81);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(41, 171, 226);
            label1.Location = new Point(93, 21);
            label1.Name = "label1";
            label1.Size = new Size(277, 38);
            label1.TabIndex = 1;
            label1.Text = "PATIENTS INFO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(41, 171, 226);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.FromArgb(0, 7, 13);
            button7.Location = new Point(22, 12);
            button7.Name = "button7";
            button7.Size = new Size(224, 57);
            button7.TabIndex = 3;
            button7.Text = "BACK TO LOGIN";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(41, 171, 226);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 7, 13);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Location = new Point(911, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(962, 840);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(41, 171, 226);
            label2.Location = new Point(418, 17);
            label2.Name = "label2";
            label2.Size = new Size(566, 55);
            label2.TabIndex = 1;
            label2.Text = "DOCTOR DASHBOARD";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 21, 41);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel11);
            panel7.Controls.Add(panel12);
            panel7.Location = new Point(48, 154);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(2);
            panel7.Size = new Size(471, 315);
            panel7.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 7, 13);
            panel8.Controls.Add(button5);
            panel8.Controls.Add(buttonAddPatient);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(2, 83);
            panel8.Name = "panel8";
            panel8.Size = new Size(465, 218);
            panel8.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(41, 171, 226);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 7, 13);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(13, 131);
            button5.Name = "button5";
            button5.Size = new Size(427, 57);
            button5.TabIndex = 1;
            button5.Text = "ADD PATIENT";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // buttonAddPatient
            // 
            buttonAddPatient.BackColor = Color.FromArgb(41, 171, 226);
            buttonAddPatient.FlatStyle = FlatStyle.Flat;
            buttonAddPatient.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddPatient.ForeColor = Color.FromArgb(0, 7, 13);
            buttonAddPatient.Image = (Image)resources.GetObject("buttonAddPatient.Image");
            buttonAddPatient.Location = new Point(13, 22);
            buttonAddPatient.Name = "buttonAddPatient";
            buttonAddPatient.Size = new Size(427, 57);
            buttonAddPatient.TabIndex = 1;
            buttonAddPatient.Text = "SHOW PATIENTS";
            buttonAddPatient.TextAlign = ContentAlignment.MiddleRight;
            buttonAddPatient.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddPatient.UseVisualStyleBackColor = false;
            buttonAddPatient.Click += button9_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(0, 21, 41);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(2, 301);
            panel11.Name = "panel11";
            panel11.Size = new Size(465, 10);
            panel11.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(0, 21, 41);
            panel12.Controls.Add(label6);
            panel12.Controls.Add(pictureBox6);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(2, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(465, 81);
            panel12.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(41, 171, 226);
            label6.Location = new Point(93, 21);
            label6.Name = "label6";
            label6.Size = new Size(277, 38);
            label6.TabIndex = 1;
            label6.Text = "PATIENTS INFO";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.None;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(23, 15);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(64, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // DoctorHomeControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1904, 956);
            Controls.Add(Content);
            Name = "DoctorHomeControl";
            Content.ResumeLayout(false);
            Content.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel Content;
        private Panel panel7;
        private Panel panel8;
        private Panel panel11;
        private Panel panel12;
        private PictureBox pictureBox6;
        private Button button5;
        private Button buttonAddPatient;
        private Label label2;
        private Label label6;
        private DataGridView dataGridView1;
        private Button button7;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
