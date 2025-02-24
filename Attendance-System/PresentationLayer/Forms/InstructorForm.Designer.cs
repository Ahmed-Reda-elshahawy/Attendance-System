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
            btn_dash = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btn_report = new Button();
            btn_atten = new Button();
            mainPanal = new Panel();
            panel2 = new Panel();
            btn_logout = new Button();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            p_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            mainPanal.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // p_main
            // 
            p_main.AutoScroll = true;
            p_main.AutoSize = true;
            p_main.Controls.Add(mainPanal);
            p_main.Dock = DockStyle.Fill;
            p_main.Location = new Point(313, 0);
            p_main.Margin = new Padding(0);
            p_main.Name = "p_main";
            p_main.Size = new Size(1143, 681);
            p_main.TabIndex = 4;
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
            panel1.Controls.Add(btn_report);
            panel1.Controls.Add(btn_atten);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 681);
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
            // 
            // mainPanal
            // 
            mainPanal.Controls.Add(panel2);
            mainPanal.Dock = DockStyle.Fill;
            mainPanal.Location = new Point(0, 0);
            mainPanal.Name = "mainPanal";
            mainPanal.Size = new Size(1143, 681);
            mainPanal.TabIndex = 0;
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
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 79);
            panel2.TabIndex = 0;
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
            btn_logout.Location = new Point(1075, 0);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(66, 77);
            btn_logout.TabIndex = 13;
            btn_logout.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label6.Location = new Point(261, 27);
            label6.Name = "label6";
            label6.Size = new Size(45, 28);
            label6.TabIndex = 11;
            label6.Text = "{?}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label3.Location = new Point(192, 27);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 12;
            label3.Text = "Role:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label5.Location = new Point(119, 25);
            label5.Name = "label5";
            label5.Size = new Size(45, 28);
            label5.TabIndex = 9;
            label5.Text = "{?}";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label2.Location = new Point(1, 27);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 10;
            label2.Text = "Welcome:";
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1456, 681);
            Controls.Add(p_main);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InstructorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Instructor Form";
            p_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainPanal.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel p_main;
        private Panel mainPanal;
        private Panel panel2;
        private Button btn_dash;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btn_report;
        private Button btn_atten;
        private Button btn_logout;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
    }
}