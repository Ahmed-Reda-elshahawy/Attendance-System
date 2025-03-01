namespace Attendance_System.PresentationLayer.UserControls
{
    partial class StudentDashboardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboardControl));
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pictureBox1 = new PictureBox();
            lb_std_discription = new Label();
            lb_std_instructor = new Label();
            label9 = new Label();
            lb_std_address = new Label();
            label7 = new Label();
            label4 = new Label();
            lb_std_group = new Label();
            label5 = new Label();
            lb_std_phone = new Label();
            label3 = new Label();
            lb_std_email = new Label();
            label2 = new Label();
            lb_title_std_control = new Label();
            lb_std_name = new Label();
            label1 = new Label();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.None;
            materialCard1.AutoSize = true;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Controls.Add(lb_std_discription);
            materialCard1.Controls.Add(lb_std_instructor);
            materialCard1.Controls.Add(label9);
            materialCard1.Controls.Add(lb_std_address);
            materialCard1.Controls.Add(label7);
            materialCard1.Controls.Add(label4);
            materialCard1.Controls.Add(lb_std_group);
            materialCard1.Controls.Add(label5);
            materialCard1.Controls.Add(lb_std_phone);
            materialCard1.Controls.Add(label3);
            materialCard1.Controls.Add(lb_std_email);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(lb_title_std_control);
            materialCard1.Controls.Add(lb_std_name);
            materialCard1.Controls.Add(label1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(267, 96);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(942, 625);
            materialCard1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(725, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lb_std_discription
            // 
            lb_std_discription.AutoSize = true;
            lb_std_discription.BackColor = Color.White;
            lb_std_discription.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lb_std_discription.ForeColor = Color.SteelBlue;
            lb_std_discription.Location = new Point(353, 528);
            lb_std_discription.Name = "lb_std_discription";
            lb_std_discription.Size = new Size(0, 28);
            lb_std_discription.TabIndex = 3;
            // 
            // lb_std_instructor
            // 
            lb_std_instructor.AutoSize = true;
            lb_std_instructor.BackColor = Color.White;
            lb_std_instructor.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lb_std_instructor.ForeColor = Color.SteelBlue;
            lb_std_instructor.Location = new Point(353, 478);
            lb_std_instructor.Name = "lb_std_instructor";
            lb_std_instructor.Size = new Size(0, 28);
            lb_std_instructor.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(96, 528);
            label9.Name = "label9";
            label9.Size = new Size(226, 28);
            label9.TabIndex = 5;
            label9.Text = "Group discription: ";
            // 
            // lb_std_address
            // 
            lb_std_address.AutoSize = true;
            lb_std_address.BackColor = Color.White;
            lb_std_address.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lb_std_address.ForeColor = Color.SteelBlue;
            lb_std_address.Location = new Point(353, 379);
            lb_std_address.Name = "lb_std_address";
            lb_std_address.Size = new Size(0, 28);
            lb_std_address.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(96, 478);
            label7.Name = "label7";
            label7.Size = new Size(146, 28);
            label7.TabIndex = 7;
            label7.Text = "Instructor: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(96, 379);
            label4.Name = "label4";
            label4.Size = new Size(219, 28);
            label4.TabIndex = 8;
            label4.Text = "Student Address: ";
            // 
            // lb_std_group
            // 
            lb_std_group.AutoSize = true;
            lb_std_group.BackColor = Color.White;
            lb_std_group.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lb_std_group.ForeColor = Color.SteelBlue;
            lb_std_group.Location = new Point(353, 429);
            lb_std_group.Name = "lb_std_group";
            lb_std_group.Size = new Size(0, 28);
            lb_std_group.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(96, 429);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 10;
            label5.Text = "Group: ";
            // 
            // lb_std_phone
            // 
            lb_std_phone.AutoSize = true;
            lb_std_phone.BackColor = Color.White;
            lb_std_phone.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lb_std_phone.ForeColor = Color.SteelBlue;
            lb_std_phone.Location = new Point(353, 330);
            lb_std_phone.Name = "lb_std_phone";
            lb_std_phone.Size = new Size(0, 28);
            lb_std_phone.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(96, 330);
            label3.Name = "label3";
            label3.Size = new Size(200, 28);
            label3.TabIndex = 12;
            label3.Text = "Student Phone: ";
            // 
            // lb_std_email
            // 
            lb_std_email.AutoSize = true;
            lb_std_email.BackColor = Color.White;
            lb_std_email.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lb_std_email.ForeColor = Color.SteelBlue;
            lb_std_email.Location = new Point(353, 276);
            lb_std_email.Name = "lb_std_email";
            lb_std_email.Size = new Size(0, 28);
            lb_std_email.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(96, 276);
            label2.Name = "label2";
            label2.Size = new Size(191, 28);
            label2.TabIndex = 14;
            label2.Text = "Student Email: ";
            // 
            // lb_title_std_control
            // 
            lb_title_std_control.AutoSize = true;
            lb_title_std_control.BackColor = Color.White;
            lb_title_std_control.Font = new Font("Tahoma", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_title_std_control.ForeColor = Color.RoyalBlue;
            lb_title_std_control.Location = new Point(314, 31);
            lb_title_std_control.Name = "lb_title_std_control";
            lb_title_std_control.Size = new Size(307, 34);
            lb_title_std_control.TabIndex = 15;
            lb_title_std_control.Text = "Student Information";
            // 
            // lb_std_name
            // 
            lb_std_name.AutoSize = true;
            lb_std_name.BackColor = Color.White;
            lb_std_name.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lb_std_name.ForeColor = Color.SteelBlue;
            lb_std_name.Location = new Point(353, 224);
            lb_std_name.Name = "lb_std_name";
            lb_std_name.Size = new Size(0, 28);
            lb_std_name.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(96, 224);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 17;
            label1.Text = "Student Name: ";
            // 
            // StudentDashboardControl
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(materialCard1);
            Font = new Font("Tahoma", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.RoyalBlue;
            Name = "StudentDashboardControl";
            Size = new Size(1256, 733);
            Load += Student_Control_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lb_std_discription;
        private Label lb_std_instructor;
        private Label label9;
        private Label lb_std_address;
        private Label label7;
        private Label label4;
        private Label lb_std_group;
        private Label label5;
        private Label lb_std_phone;
        private Label label3;
        private Label lb_std_email;
        private Label label2;
        private Label lb_title_std_control;
        private Label lb_std_name;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
