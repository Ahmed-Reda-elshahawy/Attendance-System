namespace Attendance_System.PresentationLayer.Forms
{
    partial class InstructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorForm));
            p_main = new Panel();
            mainPanal = new Panel();
            btn_dash = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btn_report = new Button();
            btn_atten = new Button();
            mainPanel = new Panel();
            insPanel = new Panel();
            panel2 = new Panel();
            btnI_logout = new Button();
            ins_name = new Label();
            label4 = new Label();
            p_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            mainPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // p_main
            // 
            p_main.AutoScroll = true;
            p_main.AutoSize = true;
            p_main.Controls.Add(mainPanal);
            p_main.Location = new Point(312, 86);
            p_main.Margin = new Padding(0);
            p_main.Name = "p_main";
            p_main.Size = new Size(1227, 546);
            p_main.TabIndex = 4;
            // 
            // mainPanal
            // 
            mainPanal.Dock = DockStyle.Fill;
            mainPanal.Location = new Point(0, 0);
            mainPanal.Name = "mainPanal";
            mainPanal.Size = new Size(1227, 546);
            mainPanal.TabIndex = 0;
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
            btn_dash.Size = new Size(295, 69);
            btn_dash.TabIndex = 2;
            btn_dash.Text = "DashBoard";
            btn_dash.UseVisualStyleBackColor = false;
            btn_dash.Click += btn_dash_Click;
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
            pictureBox1.Size = new Size(313, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btn_dash);
            panel1.Controls.Add(p_main);
            panel1.Controls.Add(btn_report);
            panel1.Controls.Add(btn_atten);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 663);
            panel1.TabIndex = 3;
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
            btn_report.Location = new Point(5, 414);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(295, 69);
            btn_report.TabIndex = 2;
            btn_report.Text = "Reports";
            btn_report.UseVisualStyleBackColor = false;
            btn_report.Click += btn_report_Click;
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
            btn_atten.Location = new Point(5, 323);
            btn_atten.Name = "btn_atten";
            btn_atten.Size = new Size(295, 69);
            btn_atten.TabIndex = 2;
            btn_atten.Text = "Attendance";
            btn_atten.UseVisualStyleBackColor = false;
            btn_atten.Click += btn_atten_Click;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(insPanel);
            mainPanel.Controls.Add(panel2);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(313, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1227, 663);
            mainPanel.TabIndex = 4;
            // 
            // insPanel
            // 
            insPanel.BackColor = Color.WhiteSmoke;
            insPanel.Dock = DockStyle.Fill;
            insPanel.Location = new Point(0, 72);
            insPanel.Name = "insPanel";
            insPanel.Size = new Size(1227, 591);
            insPanel.TabIndex = 6;
            insPanel.Paint += insPanel_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(btnI_logout);
            panel2.Controls.Add(ins_name);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1227, 72);
            panel2.TabIndex = 5;
            // 
            // btnI_logout
            // 
            btnI_logout.BackColor = Color.Tomato;
            btnI_logout.BackgroundImageLayout = ImageLayout.None;
            btnI_logout.Cursor = Cursors.Hand;
            btnI_logout.Dock = DockStyle.Right;
            btnI_logout.FlatStyle = FlatStyle.Popup;
            btnI_logout.ForeColor = Color.White;
            btnI_logout.Image = (Image)resources.GetObject("btnI_logout.Image");
            btnI_logout.Location = new Point(1161, 0);
            btnI_logout.Name = "btnI_logout";
            btnI_logout.Size = new Size(66, 72);
            btnI_logout.TabIndex = 12;
            btnI_logout.UseVisualStyleBackColor = false;
            btnI_logout.Click += btnI_logout_Click;
            // 
            // ins_name
            // 
            ins_name.AutoSize = true;
            ins_name.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            ins_name.Location = new Point(151, 26);
            ins_name.Name = "ins_name";
            ins_name.Size = new Size(45, 28);
            ins_name.TabIndex = 8;
            ins_name.Text = "{?}";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label4.Location = new Point(33, 28);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 9;
            label4.Text = "Welcome:";
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1540, 663);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InstructorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Instructor Form";
            WindowState = FormWindowState.Maximized;
            FormClosing += InstructorForm_FormClosing;
            Load += InstructorForm_Load;
            p_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel p_main;
        private Panel mainPanal;
        private Button btn_dash;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btn_report;
        private Button btn_atten;
        private Panel mainPanel;
        private Panel panel2;
        private Label ins_name;
        private Label label4;
        private Panel insPanel;
        private Button btnI_logout;
    }
}