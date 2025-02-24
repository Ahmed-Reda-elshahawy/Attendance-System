namespace Attendance_System.PresentationLayer.Forms
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            panel1 = new Panel();
            btn_dash = new Button();
            btn_atten = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            mainPanal = new Panel();
            panel3 = new Panel();
            btn_logout = new Button();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mainPanal.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btn_dash);
            panel1.Controls.Add(btn_atten);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 663);
            panel1.TabIndex = 3;
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
            btn_dash.Location = new Point(5, 231);
            btn_dash.Name = "btn_dash";
            btn_dash.Size = new Size(291, 65);
            btn_dash.TabIndex = 2;
            btn_dash.Text = "DashBoard";
            btn_dash.UseVisualStyleBackColor = false;
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
            btn_atten.Location = new Point(5, 320);
            btn_atten.Name = "btn_atten";
            btn_atten.Size = new Size(291, 67);
            btn_atten.TabIndex = 2;
            btn_atten.Text = "Attendance";
            btn_atten.UseVisualStyleBackColor = false;
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // mainPanal
            // 
            mainPanal.BackColor = Color.White;
            mainPanal.Controls.Add(panel3);
            mainPanal.Dock = DockStyle.Fill;
            mainPanal.Location = new Point(306, 0);
            mainPanal.Name = "mainPanal";
            mainPanal.Size = new Size(1234, 663);
            mainPanal.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btn_logout);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1234, 72);
            panel3.TabIndex = 0;
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
            btn_logout.Location = new Point(1166, 0);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(66, 70);
            btn_logout.TabIndex = 8;
            btn_logout.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label6.Location = new Point(263, 27);
            label6.Name = "label6";
            label6.Size = new Size(45, 28);
            label6.TabIndex = 6;
            label6.Text = "{?}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label3.Location = new Point(194, 27);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 7;
            label3.Text = "Role:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label5.Location = new Point(121, 25);
            label5.Name = "label5";
            label5.Size = new Size(45, 28);
            label5.TabIndex = 4;
            label5.Text = "{?}";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label2.Location = new Point(3, 27);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 5;
            label2.Text = "Welcome:";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1540, 663);
            Controls.Add(mainPanal);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Attendance";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mainPanal.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_dash;
        private Button btn_atten;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel mainPanal;
        private Panel panel3;
        private Button btn_logout;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
    }
}