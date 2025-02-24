namespace Attendance_System.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            btn_dash = new Button();
            btn_report = new Button();
            btn_ins = new Button();
            btn_student = new Button();
            btn_group = new Button();
            btn_atten = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            p_main = new Panel();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            btn_logout = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btn_dash);
            panel1.Controls.Add(btn_report);
            panel1.Controls.Add(btn_ins);
            panel1.Controls.Add(btn_student);
            panel1.Controls.Add(btn_group);
            panel1.Controls.Add(btn_atten);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 674);
            panel1.TabIndex = 0;
            // 
            // btn_dash
            // 
            btn_dash.BackColor = Color.RoyalBlue;
            btn_dash.BackgroundImageLayout = ImageLayout.None;
            btn_dash.Cursor = Cursors.Hand;
            btn_dash.DialogResult = DialogResult.Cancel;
            btn_dash.FlatStyle = FlatStyle.Flat;
            btn_dash.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            btn_dash.ForeColor = Color.White;
            btn_dash.Image = (Image)resources.GetObject("btn_dash.Image");
            btn_dash.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dash.Location = new Point(5, 233);
            btn_dash.Name = "btn_dash";
            btn_dash.Size = new Size(291, 52);
            btn_dash.TabIndex = 2;
            btn_dash.Text = "DashBoard";
            btn_dash.UseVisualStyleBackColor = false;
            btn_dash.Click += btn_dash_Click;
            // 
            // btn_report
            // 
            btn_report.BackColor = Color.RoyalBlue;
            btn_report.BackgroundImageLayout = ImageLayout.None;
            btn_report.Cursor = Cursors.Hand;
            btn_report.FlatStyle = FlatStyle.Flat;
            btn_report.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            btn_report.ForeColor = Color.White;
            btn_report.Image = (Image)resources.GetObject("btn_report.Image");
            btn_report.ImageAlign = ContentAlignment.MiddleLeft;
            btn_report.Location = new Point(5, 588);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(291, 52);
            btn_report.TabIndex = 2;
            btn_report.Text = "Reports";
            btn_report.UseVisualStyleBackColor = false;
            btn_report.Click += btn_report_Click;
            // 
            // btn_ins
            // 
            btn_ins.BackColor = Color.RoyalBlue;
            btn_ins.BackgroundImageLayout = ImageLayout.None;
            btn_ins.Cursor = Cursors.Hand;
            btn_ins.FlatStyle = FlatStyle.Flat;
            btn_ins.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            btn_ins.ForeColor = Color.White;
            btn_ins.Image = (Image)resources.GetObject("btn_ins.Image");
            btn_ins.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ins.Location = new Point(5, 517);
            btn_ins.Name = "btn_ins";
            btn_ins.Size = new Size(291, 52);
            btn_ins.TabIndex = 2;
            btn_ins.Text = "Add Instructor";
            btn_ins.UseVisualStyleBackColor = false;
            btn_ins.Click += btn_ins_Click;
            // 
            // btn_student
            // 
            btn_student.BackColor = Color.RoyalBlue;
            btn_student.BackgroundImageLayout = ImageLayout.None;
            btn_student.Cursor = Cursors.Hand;
            btn_student.FlatStyle = FlatStyle.Flat;
            btn_student.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            btn_student.ForeColor = Color.White;
            btn_student.Image = (Image)resources.GetObject("btn_student.Image");
            btn_student.ImageAlign = ContentAlignment.MiddleLeft;
            btn_student.Location = new Point(5, 446);
            btn_student.Name = "btn_student";
            btn_student.Size = new Size(291, 52);
            btn_student.TabIndex = 2;
            btn_student.Text = "Add Student";
            btn_student.UseVisualStyleBackColor = false;
            // 
            // btn_group
            // 
            btn_group.BackColor = Color.RoyalBlue;
            btn_group.BackgroundImageLayout = ImageLayout.None;
            btn_group.Cursor = Cursors.Hand;
            btn_group.FlatStyle = FlatStyle.Flat;
            btn_group.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            btn_group.ForeColor = Color.White;
            btn_group.Image = (Image)resources.GetObject("btn_group.Image");
            btn_group.ImageAlign = ContentAlignment.MiddleLeft;
            btn_group.Location = new Point(5, 375);
            btn_group.Name = "btn_group";
            btn_group.Size = new Size(291, 52);
            btn_group.TabIndex = 2;
            btn_group.Text = "Add Group";
            btn_group.UseVisualStyleBackColor = false;
            // 
            // btn_atten
            // 
            btn_atten.BackColor = Color.RoyalBlue;
            btn_atten.BackgroundImageLayout = ImageLayout.None;
            btn_atten.Cursor = Cursors.Hand;
            btn_atten.FlatStyle = FlatStyle.Flat;
            btn_atten.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            btn_atten.ForeColor = Color.White;
            btn_atten.Image = (Image)resources.GetObject("btn_atten.Image");
            btn_atten.ImageAlign = ContentAlignment.MiddleLeft;
            btn_atten.Location = new Point(5, 304);
            btn_atten.Name = "btn_atten";
            btn_atten.Size = new Size(291, 52);
            btn_atten.TabIndex = 2;
            btn_atten.Text = "Attendance";
            btn_atten.UseVisualStyleBackColor = false;
            btn_atten.Click += btn_atten_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 136);
            label1.Name = "label1";
            label1.Size = new Size(239, 28);
            label1.TabIndex = 1;
            label1.Text = "Attendance System";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // p_main
            // 
            p_main.AutoScroll = true;
            p_main.AutoSize = true;
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(306, 84);
            p_main.Margin = new Padding(0);
            p_main.Name = "p_main";
            p_main.Size = new Size(1403, 590);
            p_main.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label2.Location = new Point(6, 27);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 0;
            label2.Text = "Welcome:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label5.Location = new Point(124, 25);
            label5.Name = "label5";
            label5.Size = new Size(45, 28);
            label5.TabIndex = 0;
            label5.Text = "{?}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label3.Location = new Point(197, 27);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 1;
            label3.Text = "Role:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label6.Location = new Point(266, 27);
            label6.Name = "label6";
            label6.Size = new Size(45, 28);
            label6.TabIndex = 1;
            label6.Text = "{?}";
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Tomato;
            btn_logout.BackgroundImageLayout = ImageLayout.None;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.Dock = DockStyle.Right;
            btn_logout.FlatStyle = FlatStyle.Popup;
            btn_logout.ForeColor = Color.White;
            btn_logout.Image = (Image)resources.GetObject("btn_logout.Image");
            btn_logout.Location = new Point(1335, 0);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(66, 82);
            btn_logout.TabIndex = 3;
            btn_logout.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_logout);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(306, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1403, 84);
            panel2.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1709, 674);
            Controls.Add(p_main);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance System";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_atten;
        private Button btn_dash;
        private Button btn_report;
        private Button btn_ins;
        private Button btn_student;
        private Button btn_group;
        private Panel p_main;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label6;
        private Button btn_logout;
        private Panel panel2;
    }
}