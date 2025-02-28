namespace Attendance_System
{
    partial class Forgetpassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgetpassword));
            PicVBoxMin = new PictureBox();
            PicVBoxClose = new PictureBox();
            VerfiyEmalPic = new PictureBox();
            txtbxforget = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnVerify = new Button();
            InvlidEmail = new PictureBox();
            LblEmail = new Label();
            labelError = new Label();
            ((System.ComponentModel.ISupportInitialize)PicVBoxMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicVBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VerfiyEmalPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvlidEmail).BeginInit();
            SuspendLayout();
            // 
            // PicVBoxMin
            // 
            PicVBoxMin.Cursor = Cursors.Hand;
            PicVBoxMin.Image = (Image)resources.GetObject("PicVBoxMin.Image");
            PicVBoxMin.Location = new Point(535, 5);
            PicVBoxMin.Name = "PicVBoxMin";
            PicVBoxMin.Size = new Size(31, 31);
            PicVBoxMin.SizeMode = PictureBoxSizeMode.Zoom;
            PicVBoxMin.TabIndex = 1;
            PicVBoxMin.TabStop = false;
            PicVBoxMin.Click += PicVBoxMin_Click;
            // 
            // PicVBoxClose
            // 
            PicVBoxClose.Cursor = Cursors.Hand;
            PicVBoxClose.Image = (Image)resources.GetObject("PicVBoxClose.Image");
            PicVBoxClose.Location = new Point(572, 5);
            PicVBoxClose.Name = "PicVBoxClose";
            PicVBoxClose.Size = new Size(31, 31);
            PicVBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            PicVBoxClose.TabIndex = 1;
            PicVBoxClose.TabStop = false;
            PicVBoxClose.Click += PicVBoxClose_Click;
            // 
            // VerfiyEmalPic
            // 
            VerfiyEmalPic.Cursor = Cursors.Hand;
            VerfiyEmalPic.Image = (Image)resources.GetObject("VerfiyEmalPic.Image");
            VerfiyEmalPic.Location = new Point(169, 30);
            VerfiyEmalPic.Name = "VerfiyEmalPic";
            VerfiyEmalPic.Size = new Size(262, 195);
            VerfiyEmalPic.SizeMode = PictureBoxSizeMode.Zoom;
            VerfiyEmalPic.TabIndex = 1;
            VerfiyEmalPic.TabStop = false;
            // 
            // txtbxforget
            // 
            txtbxforget.BorderStyle = BorderStyle.None;
            txtbxforget.Location = new Point(131, 288);
            txtbxforget.Name = "txtbxforget";
            txtbxforget.PlaceholderText = "John@example.com";
            txtbxforget.Size = new Size(300, 20);
            txtbxforget.TabIndex = 2;
            txtbxforget.TextChanged += txtbxforget_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Location = new Point(131, 314);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(300, 3);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.FromArgb(67, 3, 125);
            btnVerify.FlatAppearance.BorderSize = 0;
            btnVerify.FlatStyle = FlatStyle.Flat;
            btnVerify.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnVerify.ForeColor = Color.White;
            btnVerify.Location = new Point(181, 394);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(198, 35);
            btnVerify.TabIndex = 4;
            btnVerify.Text = "Verify";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // InvlidEmail
            // 
            InvlidEmail.Cursor = Cursors.Hand;
            InvlidEmail.Image = (Image)resources.GetObject("InvlidEmail.Image");
            InvlidEmail.Location = new Point(437, 288);
            InvlidEmail.Name = "InvlidEmail";
            InvlidEmail.Size = new Size(27, 27);
            InvlidEmail.SizeMode = PictureBoxSizeMode.Zoom;
            InvlidEmail.TabIndex = 1;
            InvlidEmail.TabStop = false;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            LblEmail.Location = new Point(131, 247);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(58, 19);
            LblEmail.TabIndex = 5;
            LblEmail.Text = "Email:";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Century Gothic", 9F);
            labelError.ForeColor = Color.Crimson;
            labelError.Location = new Point(470, 295);
            labelError.Name = "labelError";
            labelError.Size = new Size(100, 20);
            labelError.TabIndex = 6;
            labelError.Text = "Invalid Email";
            // 
            // Forgetpassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(613, 495);
            Controls.Add(labelError);
            Controls.Add(LblEmail);
            Controls.Add(btnVerify);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtbxforget);
            Controls.Add(PicVBoxClose);
            Controls.Add(InvlidEmail);
            Controls.Add(VerfiyEmalPic);
            Controls.Add(PicVBoxMin);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Forgetpassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgetpassword";
            ((System.ComponentModel.ISupportInitialize)PicVBoxMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicVBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)VerfiyEmalPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvlidEmail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PicVBoxMin;
        private PictureBox PicVBoxClose;
        private PictureBox VerfiyEmalPic;
        private TextBox txtbxforget;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnVerify;
        private PictureBox InvlidEmail;
        private Label LblEmail;
        private Label labelError;
    }
}