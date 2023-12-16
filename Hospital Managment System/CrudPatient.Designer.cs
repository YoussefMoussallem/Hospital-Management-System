namespace Hospital_Managment_System
{
    partial class CrudPatient
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
            components = new System.ComponentModel.Container();
            dOCTORSBindingSource = new BindingSource(components);
            textBoxTel = new TextBox();
            label4 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            Content = new Panel();
            emailtxt = new TextBox();
            label1 = new Label();
            sextxt = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dOCTORSBindingSource).BeginInit();
            Content.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTel
            // 
            textBoxTel.BackColor = Color.FromArgb(41, 171, 226);
            textBoxTel.BorderStyle = BorderStyle.None;
            textBoxTel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTel.Location = new Point(399, 277);
            textBoxTel.Margin = new Padding(5, 6, 5, 6);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(493, 37);
            textBoxTel.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(41, 171, 226);
            label4.Location = new Point(225, 371);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 32);
            label4.TabIndex = 0;
            label4.Text = "GENDER:";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.FromArgb(41, 171, 226);
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(399, 174);
            textBoxName.Margin = new Padding(5, 6, 5, 6);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(493, 37);
            textBoxName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(41, 171, 226);
            label3.Location = new Point(266, 179);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 32);
            label3.TabIndex = 0;
            label3.Text = "NAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(41, 171, 226);
            label2.Location = new Point(25, 23);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 55);
            label2.TabIndex = 1;
            label2.Text = "Patient";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(41, 171, 226);
            label9.Location = new Point(244, 277);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(130, 32);
            label9.TabIndex = 0;
            label9.Text = "TEL NO:";
            // 
            // Content
            // 
            Content.BackColor = Color.FromArgb(0, 7, 13);
            Content.BackgroundImage = Properties.Resources.back;
            Content.Controls.Add(emailtxt);
            Content.Controls.Add(label1);
            Content.Controls.Add(sextxt);
            Content.Controls.Add(button2);
            Content.Controls.Add(textBoxTel);
            Content.Controls.Add(label9);
            Content.Controls.Add(label4);
            Content.Controls.Add(textBoxName);
            Content.Controls.Add(label3);
            Content.Controls.Add(label2);
            Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Content.Location = new Point(0, 0);
            Content.Margin = new Padding(5, 6, 5, 6);
            Content.Name = "Content";
            Content.Size = new Size(1042, 711);
            Content.TabIndex = 3;
            Content.Paint += Content_Paint;
            // 
            // emailtxt
            // 
            emailtxt.BackColor = Color.FromArgb(41, 171, 226);
            emailtxt.BorderStyle = BorderStyle.None;
            emailtxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            emailtxt.Location = new Point(399, 451);
            emailtxt.Margin = new Padding(5, 6, 5, 6);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(493, 37);
            emailtxt.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(41, 171, 226);
            label1.Location = new Point(262, 451);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 26;
            label1.Text = "EMAIL:";
            // 
            // sextxt
            // 
            sextxt.BackColor = Color.FromArgb(41, 171, 226);
            sextxt.BorderStyle = BorderStyle.None;
            sextxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            sextxt.Location = new Point(399, 366);
            sextxt.Margin = new Padding(5, 6, 5, 6);
            sextxt.Name = "sextxt";
            sextxt.Size = new Size(493, 37);
            sextxt.TabIndex = 25;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 171, 226);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 21, 41);
            button2.Location = new Point(399, 534);
            button2.Name = "button2";
            button2.Size = new Size(284, 77);
            button2.TabIndex = 23;
            button2.Text = "SUBMIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CrudPatient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 709);
            Controls.Add(Content);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5, 6, 5, 6);
            Name = "CrudPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrudEmployee";
            ((System.ComponentModel.ISupportInitialize)dOCTORSBindingSource).EndInit();
            Content.ResumeLayout(false);
            Content.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource dOCTORSBindingSource;
        private TextBox textBoxTel;
        private Label label4;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private Label label9;
        private Panel Content;
        private Button button2;
        private TextBox sextxt;
        private TextBox emailtxt;
        private Label label1;
    }
}