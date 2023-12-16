namespace Hospital_Managment_System
{
    partial class CrudAppointment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudAppointment));
            Content = new Panel();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label12 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Content
            // 
            Content.BackColor = Color.FromArgb(0, 7, 13);
            Content.BackgroundImage = Properties.Resources.back;
            Content.Controls.Add(dataGridView1);
            Content.Controls.Add(button2);
            Content.Controls.Add(label12);
            Content.Controls.Add(dateTimePicker1);
            Content.Controls.Add(label2);
            Content.Dock = DockStyle.Fill;
            Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Content.Location = new Point(0, 0);
            Content.Name = "Content";
            Content.Size = new Size(1730, 940);
            Content.TabIndex = 2;
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
            dataGridView1.Location = new Point(718, 40);
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
            dataGridView1.TabIndex = 23;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 171, 226);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 21, 41);
            button2.Location = new Point(31, 251);
            button2.Name = "button2";
            button2.Size = new Size(334, 67);
            button2.TabIndex = 22;
            button2.Text = "SUBMIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(41, 171, 226);
            label12.Location = new Point(31, 156);
            label12.Name = "label12";
            label12.Size = new Size(163, 32);
            label12.TabIndex = 17;
            label12.Text = "Start Time:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(200, 154);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(434, 35);
            dateTimePicker1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(41, 171, 226);
            label2.Location = new Point(19, 20);
            label2.Name = "label2";
            label2.Size = new Size(381, 55);
            label2.TabIndex = 1;
            label2.Text = "APPOINTMENT";
            // 
            // CrudAppointment
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1730, 940);
            Controls.Add(Content);
            Name = "CrudAppointment";
            Content.ResumeLayout(false);
            Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Content;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label12;
        private Button button2;
        private DataGridView dataGridView1;
    }
}
