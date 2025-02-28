namespace Attendance_System.PresentationLayer.UserControls
{
    partial class UpdateGroupControl
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
            lblUpdateCF = new Label();
            btnUpdateGCF = new Button();
            panel5 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            txtDiscriptionCF = new TextBox();
            txtNOSCF = new TextBox();
            sltINSCF = new ComboBox();
            txtGCCF = new TextBox();
            lblinstructorSelectCF = new Label();
            lblDiscriptionCF = new Label();
            lblnumofSCF = new Label();
            lblGCCF = new Label();
            btncancel = new Button();
            SuspendLayout();
            // 
            // lblUpdateCF
            // 
            lblUpdateCF.AutoSize = true;
            lblUpdateCF.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblUpdateCF.ForeColor = Color.RoyalBlue;
            lblUpdateCF.Location = new Point(277, 22);
            lblUpdateCF.Name = "lblUpdateCF";
            lblUpdateCF.Size = new Size(172, 28);
            lblUpdateCF.TabIndex = 0;
            lblUpdateCF.Text = "Update Group";
            lblUpdateCF.Click += lblUpdateCF_Click;
            // 
            // btnUpdateGCF
            // 
            btnUpdateGCF.BackColor = Color.RoyalBlue;
            btnUpdateGCF.FlatStyle = FlatStyle.Flat;
            btnUpdateGCF.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnUpdateGCF.ForeColor = Color.White;
            btnUpdateGCF.Location = new Point(107, 550);
            btnUpdateGCF.Name = "btnUpdateGCF";
            btnUpdateGCF.Size = new Size(138, 50);
            btnUpdateGCF.TabIndex = 18;
            btnUpdateGCF.Text = "Update Group";
            btnUpdateGCF.UseVisualStyleBackColor = false;
            btnUpdateGCF.Click += btnUpdateGCF_Click;
            // 
            // panel5
            // 
            panel5.Location = new Point(453, 469);
            panel5.Name = "panel5";
            panel5.Size = new Size(317, 2);
            panel5.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Location = new Point(453, 231);
            panel3.Name = "panel3";
            panel3.Size = new Size(307, 2);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Location = new Point(45, 231);
            panel4.Name = "panel4";
            panel4.Size = new Size(307, 2);
            panel4.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Location = new Point(453, 239);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 1);
            panel1.TabIndex = 17;
            // 
            // txtDiscriptionCF
            // 
            txtDiscriptionCF.BackColor = SystemColors.InactiveBorder;
            txtDiscriptionCF.BorderStyle = BorderStyle.None;
            txtDiscriptionCF.Location = new Point(453, 334);
            txtDiscriptionCF.Multiline = true;
            txtDiscriptionCF.Name = "txtDiscriptionCF";
            txtDiscriptionCF.Size = new Size(317, 137);
            txtDiscriptionCF.TabIndex = 9;
            // 
            // txtNOSCF
            // 
            txtNOSCF.BorderStyle = BorderStyle.None;
            txtNOSCF.Location = new Point(453, 206);
            txtNOSCF.Name = "txtNOSCF";
            txtNOSCF.Size = new Size(305, 20);
            txtNOSCF.TabIndex = 10;
            txtNOSCF.TextChanged += txtNOSCF_TextChanged;
            // 
            // sltINSCF
            // 
            sltINSCF.FormattingEnabled = true;
            sltINSCF.Location = new Point(45, 352);
            sltINSCF.Name = "sltINSCF";
            sltINSCF.Size = new Size(307, 28);
            sltINSCF.TabIndex = 13;
            // 
            // txtGCCF
            // 
            txtGCCF.BorderStyle = BorderStyle.None;
            txtGCCF.Location = new Point(45, 205);
            txtGCCF.Name = "txtGCCF";
            txtGCCF.Size = new Size(305, 20);
            txtGCCF.TabIndex = 12;
            // 
            // lblinstructorSelectCF
            // 
            lblinstructorSelectCF.AutoSize = true;
            lblinstructorSelectCF.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lblinstructorSelectCF.Location = new Point(45, 303);
            lblinstructorSelectCF.Name = "lblinstructorSelectCF";
            lblinstructorSelectCF.Size = new Size(112, 28);
            lblinstructorSelectCF.TabIndex = 5;
            lblinstructorSelectCF.Text = "Instructor";
            // 
            // lblDiscriptionCF
            // 
            lblDiscriptionCF.AutoSize = true;
            lblDiscriptionCF.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lblDiscriptionCF.Location = new Point(453, 303);
            lblDiscriptionCF.Name = "lblDiscriptionCF";
            lblDiscriptionCF.Size = new Size(118, 28);
            lblDiscriptionCF.TabIndex = 6;
            lblDiscriptionCF.Text = "Discription";
            // 
            // lblnumofSCF
            // 
            lblnumofSCF.AutoSize = true;
            lblnumofSCF.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lblnumofSCF.Location = new Point(453, 150);
            lblnumofSCF.Name = "lblnumofSCF";
            lblnumofSCF.Size = new Size(209, 28);
            lblnumofSCF.TabIndex = 7;
            lblnumofSCF.Text = "Number Of Student";
            // 
            // lblGCCF
            // 
            lblGCCF.AutoSize = true;
            lblGCCF.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lblGCCF.Location = new Point(45, 150);
            lblGCCF.Name = "lblGCCF";
            lblGCCF.Size = new Size(131, 28);
            lblGCCF.TabIndex = 8;
            lblGCCF.Text = "Group Code";
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.RoyalBlue;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btncancel.ForeColor = Color.White;
            btncancel.Location = new Point(506, 550);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(138, 50);
            btncancel.TabIndex = 18;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // UpdateGroupControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btncancel);
            Controls.Add(btnUpdateGCF);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(txtDiscriptionCF);
            Controls.Add(txtNOSCF);
            Controls.Add(sltINSCF);
            Controls.Add(txtGCCF);
            Controls.Add(lblinstructorSelectCF);
            Controls.Add(lblDiscriptionCF);
            Controls.Add(lblnumofSCF);
            Controls.Add(lblGCCF);
            Controls.Add(lblUpdateCF);
            Name = "UpdateGroupControl";
            Size = new Size(816, 629);
            Load += UpdateGroupControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdateCF;
        private Button btnUpdateGCF;
        private Panel panel5;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
        private TextBox txtDiscriptionCF;
        private TextBox txtNOSCF;
        private ComboBox sltINSCF;
        private TextBox txtGCCF;
        private Label lblinstructorSelectCF;
        private Label lblDiscriptionCF;
        private Label lblnumofSCF;
        private Label lblGCCF;
        private Button btncancel;
    }
}
