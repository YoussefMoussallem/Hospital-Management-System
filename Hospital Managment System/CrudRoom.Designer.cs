namespace Hospital_Managment_System
{
    partial class CrudRoom
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
            label8 = new Label();
            textBoxNO = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            Content = new Panel();
            typetxt = new TextBox();
            floortxt = new TextBox();
            button2 = new Button();
            Content.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(41, 171, 226);
            label8.Location = new Point(105, 245);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(171, 32);
            label8.TabIndex = 0;
            label8.Text = "FLOOR No:";
            // 
            // textBoxNO
            // 
            textBoxNO.BackColor = Color.FromArgb(41, 171, 226);
            textBoxNO.BorderStyle = BorderStyle.None;
            textBoxNO.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNO.Location = new Point(399, 174);
            textBoxNO.Margin = new Padding(5, 6, 5, 6);
            textBoxNO.Name = "textBoxNO";
            textBoxNO.Size = new Size(205, 37);
            textBoxNO.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(41, 171, 226);
            label3.Location = new Point(123, 169);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 32);
            label3.TabIndex = 0;
            label3.Text = "ROOM No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(41, 171, 226);
            label2.Location = new Point(33, 28);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 55);
            label2.TabIndex = 1;
            label2.Text = "Room";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(41, 171, 226);
            label9.Location = new Point(89, 314);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(208, 32);
            label9.TabIndex = 0;
            label9.Text = "ROOM TYPE: ";
            // 
            // Content
            // 
            Content.BackColor = Color.FromArgb(0, 7, 13);
            Content.BackgroundImage = Properties.Resources.back;
            Content.BorderStyle = BorderStyle.Fixed3D;
            Content.Controls.Add(typetxt);
            Content.Controls.Add(floortxt);
            Content.Controls.Add(button2);
            Content.Controls.Add(label8);
            Content.Controls.Add(label9);
            Content.Controls.Add(textBoxNO);
            Content.Controls.Add(label3);
            Content.Controls.Add(label2);
            Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Content.Location = new Point(0, 0);
            Content.Margin = new Padding(5, 6, 5, 6);
            Content.Name = "Content";
            Content.Size = new Size(893, 711);
            Content.TabIndex = 3;
            // 
            // typetxt
            // 
            typetxt.BackColor = Color.FromArgb(41, 171, 226);
            typetxt.BorderStyle = BorderStyle.None;
            typetxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            typetxt.Location = new Point(399, 309);
            typetxt.Margin = new Padding(5, 6, 5, 6);
            typetxt.Name = "typetxt";
            typetxt.Size = new Size(205, 37);
            typetxt.TabIndex = 25;
            // 
            // floortxt
            // 
            floortxt.BackColor = Color.FromArgb(41, 171, 226);
            floortxt.BorderStyle = BorderStyle.None;
            floortxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            floortxt.Location = new Point(399, 240);
            floortxt.Margin = new Padding(5, 6, 5, 6);
            floortxt.Name = "floortxt";
            floortxt.Size = new Size(205, 37);
            floortxt.TabIndex = 24;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 171, 226);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 21, 41);
            button2.Location = new Point(403, 429);
            button2.Name = "button2";
            button2.Size = new Size(190, 82);
            button2.TabIndex = 23;
            button2.Text = "SUBMIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CrudRoom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 709);
            Controls.Add(Content);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5, 6, 5, 6);
            Name = "CrudRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrudEmployee";
            Content.ResumeLayout(false);
            Content.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label8;
        private TextBox textBoxNO;
        private Label label3;
        private Label label2;
        private Label label9;
        private Panel Content;
        private Button button2;
        private TextBox floortxt;
        private TextBox typetxt;
    }
}