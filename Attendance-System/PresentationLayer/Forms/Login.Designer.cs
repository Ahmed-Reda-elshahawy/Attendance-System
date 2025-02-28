namespace Attendance_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LpicClose = new PictureBox();
            LpicMinimize = new PictureBox();
            GBL = new GroupBox();
            btnLogin = new Button();
            PicInvalidUserOrpass = new PictureBox();
            txtbxLPassword = new TextBox();
            txtbxLName = new TextBox();
            labelError = new Label();
            labelFP = new Label();
            LblLPass = new Label();
            LblLUsername = new Label();
            panel1 = new Panel();
            LoginPic = new PictureBox();
            label3 = new Label();
            LblLTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)LpicClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LpicMinimize).BeginInit();
            GBL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicInvalidUserOrpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoginPic).BeginInit();
            SuspendLayout();
            // 
            // LpicClose
            // 
            LpicClose.Cursor = Cursors.Hand;
            LpicClose.Image = (Image)resources.GetObject("LpicClose.Image");
            LpicClose.Location = new Point(1148, 3);
            LpicClose.Name = "LpicClose";
            LpicClose.Size = new Size(31, 31);
            LpicClose.SizeMode = PictureBoxSizeMode.Zoom;
            LpicClose.TabIndex = 0;
            LpicClose.TabStop = false;
            LpicClose.Click += pictureBoxClose_Click;
            // 
            // LpicMinimize
            // 
            LpicMinimize.Cursor = Cursors.Hand;
            LpicMinimize.Image = (Image)resources.GetObject("LpicMinimize.Image");
            LpicMinimize.Location = new Point(1111, 3);
            LpicMinimize.Name = "LpicMinimize";
            LpicMinimize.Size = new Size(31, 31);
            LpicMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            LpicMinimize.TabIndex = 1;
            LpicMinimize.TabStop = false;
            LpicMinimize.Click += pictureBoxMinimize_Click;
            // 
            // GBL
            // 
            GBL.Anchor = AnchorStyles.None;
            GBL.Controls.Add(btnLogin);
            GBL.Controls.Add(PicInvalidUserOrpass);
            GBL.Controls.Add(txtbxLPassword);
            GBL.Controls.Add(txtbxLName);
            GBL.Controls.Add(labelError);
            GBL.Controls.Add(labelFP);
            GBL.Controls.Add(LblLPass);
            GBL.Controls.Add(LblLUsername);
            GBL.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            GBL.Location = new Point(107, 190);
            GBL.Name = "GBL";
            GBL.Size = new Size(452, 348);
            GBL.TabIndex = 0;
            GBL.TabStop = false;
            GBL.Text = "Please Login First";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(67, 3, 125);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(95, 297);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(265, 35);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // PicInvalidUserOrpass
            // 
            PicInvalidUserOrpass.Cursor = Cursors.Hand;
            PicInvalidUserOrpass.Image = (Image)resources.GetObject("PicInvalidUserOrpass.Image");
            PicInvalidUserOrpass.Location = new Point(95, 226);
            PicInvalidUserOrpass.Name = "PicInvalidUserOrpass";
            PicInvalidUserOrpass.Size = new Size(28, 28);
            PicInvalidUserOrpass.SizeMode = PictureBoxSizeMode.Zoom;
            PicInvalidUserOrpass.TabIndex = 1;
            PicInvalidUserOrpass.TabStop = false;
            PicInvalidUserOrpass.Click += pictureBoxHide_Click;
            // 
            // txtbxLPassword
            // 
            txtbxLPassword.Location = new Point(95, 183);
            txtbxLPassword.Name = "txtbxLPassword";
            txtbxLPassword.Size = new Size(265, 28);
            txtbxLPassword.TabIndex = 2;
            txtbxLPassword.TextChanged += txtbxPassword_TextChanged;
            // 
            // txtbxLName
            // 
            txtbxLName.Location = new Point(95, 92);
            txtbxLName.Name = "txtbxLName";
            txtbxLName.Size = new Size(265, 28);
            txtbxLName.TabIndex = 1;
            txtbxLName.TextChanged += txtbxName_TextChanged;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Century Gothic", 9F);
            labelError.ForeColor = Color.Crimson;
            labelError.Location = new Point(129, 230);
            labelError.Name = "labelError";
            labelError.Size = new Size(233, 20);
            labelError.TabIndex = 0;
            labelError.Text = "Invalid Username Or Password";
            labelError.Click += labelError_Click;
            // 
            // labelFP
            // 
            labelFP.AutoSize = true;
            labelFP.Cursor = Cursors.Hand;
            labelFP.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelFP.ForeColor = Color.FromArgb(67, 3, 125);
            labelFP.Location = new Point(140, 262);
            labelFP.Name = "labelFP";
            labelFP.Size = new Size(157, 19);
            labelFP.TabIndex = 0;
            labelFP.Text = "Forgot Password ?";
            labelFP.Click += labelFP_Click;
            // 
            // LblLPass
            // 
            LblLPass.AutoSize = true;
            LblLPass.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            LblLPass.Location = new Point(95, 150);
            LblLPass.Name = "LblLPass";
            LblLPass.Size = new Size(92, 19);
            LblLPass.TabIndex = 0;
            LblLPass.Text = "Password:";
            // 
            // LblLUsername
            // 
            LblLUsername.AutoSize = true;
            LblLUsername.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            LblLUsername.Location = new Point(92, 59);
            LblLUsername.Name = "LblLUsername";
            LblLUsername.Size = new Size(96, 19);
            LblLUsername.TabIndex = 0;
            LblLUsername.Text = "Username:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(643, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 455);
            panel1.TabIndex = 2;
            // 
            // LoginPic
            // 
            LoginPic.Cursor = Cursors.Hand;
            LoginPic.Image = (Image)resources.GetObject("LoginPic.Image");
            LoginPic.Location = new Point(783, 190);
            LoginPic.Name = "LoginPic";
            LoginPic.Size = new Size(295, 288);
            LoginPic.SizeMode = PictureBoxSizeMode.Zoom;
            LoginPic.TabIndex = 1;
            LoginPic.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(888, 509);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 0;
            label3.Text = "System";
            label3.Click += labelError_Click;
            // 
            // LblLTitle
            // 
            LblLTitle.AutoSize = true;
            LblLTitle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            LblLTitle.ForeColor = Color.DarkBlue;
            LblLTitle.Location = new Point(809, 486);
            LblLTitle.Name = "LblLTitle";
            LblLTitle.Size = new Size(251, 23);
            LblLTitle.TabIndex = 0;
            LblLTitle.Text = "Attendance Managment";
            LblLTitle.Click += labelError_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 673);
            Controls.Add(panel1);
            Controls.Add(GBL);
            Controls.Add(LoginPic);
            Controls.Add(LpicMinimize);
            Controls.Add(LblLTitle);
            Controls.Add(label3);
            Controls.Add(LpicClose);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)LpicClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)LpicMinimize).EndInit();
            GBL.ResumeLayout(false);
            GBL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicInvalidUserOrpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoginPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LpicClose;
        private PictureBox LpicMinimize;
        private GroupBox GBL;
        private Button btnLogin;
        private TextBox txtbxLName;
        private Label LblLUsername;
        private TextBox txtbxLPassword;
        private Label LblLPass;
        private PictureBox PicInvalidUserOrpass;
        private Label labelError;
        private Label labelFP;
        private Panel panel1;
        private PictureBox LoginPic;
        private Label label3;
        private Label LblLTitle;
    }
}
