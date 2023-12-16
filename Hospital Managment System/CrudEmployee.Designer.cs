namespace Hospital_Managment_System
{
    partial class CrudEmployee
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
            textBoxEmail = new TextBox();
            label6 = new Label();
            label8 = new Label();
            dOCTORSBindingSource = new BindingSource(components);
            label5 = new Label();
            textBoxTel = new TextBox();
            label4 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            Content = new Panel();
            roletxt = new TextBox();
            sextxt = new TextBox();
            departmentxt = new TextBox();
            button2 = new Button();
            password = new TextBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dOCTORSBindingSource).BeginInit();
            Content.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(41, 171, 226);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(399, 395);
            textBoxEmail.Margin = new Padding(5, 6, 5, 6);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(631, 37);
            textBoxEmail.TabIndex = 6;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(41, 171, 226);
            label6.Location = new Point(105, 387);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 32);
            label6.TabIndex = 0;
            label6.Text = "EMAIL:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(41, 171, 226);
            label8.Location = new Point(105, 245);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(226, 32);
            label8.TabIndex = 0;
            label8.Text = "DEPARTMENT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(41, 171, 226);
            label5.Location = new Point(714, 169);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 32);
            label5.TabIndex = 0;
            label5.Text = "Role:";
            // 
            // textBoxTel
            // 
            textBoxTel.BackColor = Color.FromArgb(41, 171, 226);
            textBoxTel.BorderStyle = BorderStyle.None;
            textBoxTel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTel.Location = new Point(399, 319);
            textBoxTel.Margin = new Padding(5, 6, 5, 6);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(205, 37);
            textBoxTel.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(41, 171, 226);
            label4.Location = new Point(651, 248);
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
            textBoxName.Size = new Size(205, 37);
            textBoxName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(41, 171, 226);
            label3.Location = new Point(123, 169);
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
            label2.Location = new Point(14, 19);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(246, 55);
            label2.TabIndex = 1;
            label2.Text = "Employee";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(41, 171, 226);
            label9.Location = new Point(89, 314);
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
            Content.Controls.Add(roletxt);
            Content.Controls.Add(sextxt);
            Content.Controls.Add(departmentxt);
            Content.Controls.Add(button2);
            Content.Controls.Add(password);
            Content.Controls.Add(label12);
            Content.Controls.Add(textBoxEmail);
            Content.Controls.Add(label6);
            Content.Controls.Add(label8);
            Content.Controls.Add(label5);
            Content.Controls.Add(textBoxTel);
            Content.Controls.Add(label9);
            Content.Controls.Add(label4);
            Content.Controls.Add(textBoxName);
            Content.Controls.Add(label3);
            Content.Controls.Add(label2);
            Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Content.Location = new Point(0, -1);
            Content.Margin = new Padding(5, 6, 5, 6);
            Content.Name = "Content";
            Content.Size = new Size(1114, 715);
            Content.TabIndex = 3;
            Content.Paint += Content_Paint;
            // 
            // roletxt
            // 
            roletxt.BackColor = Color.FromArgb(41, 171, 226);
            roletxt.BorderStyle = BorderStyle.None;
            roletxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            roletxt.Location = new Point(825, 164);
            roletxt.Margin = new Padding(5, 6, 5, 6);
            roletxt.Name = "roletxt";
            roletxt.Size = new Size(205, 37);
            roletxt.TabIndex = 26;
            // 
            // sextxt
            // 
            sextxt.BackColor = Color.FromArgb(41, 171, 226);
            sextxt.BorderStyle = BorderStyle.None;
            sextxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            sextxt.Location = new Point(825, 243);
            sextxt.Margin = new Padding(5, 6, 5, 6);
            sextxt.Name = "sextxt";
            sextxt.Size = new Size(205, 37);
            sextxt.TabIndex = 25;
            // 
            // departmentxt
            // 
            departmentxt.BackColor = Color.FromArgb(41, 171, 226);
            departmentxt.BorderStyle = BorderStyle.None;
            departmentxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            departmentxt.Location = new Point(399, 240);
            departmentxt.Margin = new Padding(5, 6, 5, 6);
            departmentxt.Name = "departmentxt";
            departmentxt.Size = new Size(205, 37);
            departmentxt.TabIndex = 24;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 171, 226);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 21, 41);
            button2.Location = new Point(399, 521);
            button2.Name = "button2";
            button2.Size = new Size(201, 82);
            button2.TabIndex = 23;
            button2.Text = "SUBMIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(41, 171, 226);
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(399, 444);
            password.Margin = new Padding(5, 6, 5, 6);
            password.Name = "password";
            password.Size = new Size(631, 37);
            password.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(41, 171, 226);
            label12.Location = new Point(89, 447);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(155, 32);
            label12.TabIndex = 15;
            label12.Text = "Password:";
            // 
            // CrudEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 709);
            Controls.Add(Content);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5, 6, 5, 6);
            Name = "CrudEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrudEmployee";
            ((System.ComponentModel.ISupportInitialize)dOCTORSBindingSource).EndInit();
            Content.ResumeLayout(false);
            Content.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxEmail;
        private Label label6;
        private Label label8;
        private BindingSource dOCTORSBindingSource;
        private Label label5;
        private TextBox textBoxTel;
        private Label label4;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private Label label9;
        private Panel Content;
        private TextBox password;
        private Label label12;
        private Button button2;
        private TextBox roletxt;
        private TextBox sextxt;
        private TextBox departmentxt;
    }
}