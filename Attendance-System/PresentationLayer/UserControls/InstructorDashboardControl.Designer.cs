namespace Attendance_System.PresentationLayer.UserControls
{
    partial class InstructorDashboardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorDashboardControl));
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pictureBox1 = new PictureBox();
            flp_cards = new FlowLayoutPanel();
            lb_ins_address = new Label();
            label4 = new Label();
            label5 = new Label();
            lb_ins_phone = new Label();
            label3 = new Label();
            lb_ins_email = new Label();
            label2 = new Label();
            lb_title_std_control = new Label();
            lb_ins_name = new Label();
            label1 = new Label();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.None;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Controls.Add(flp_cards);
            materialCard1.Controls.Add(lb_ins_address);
            materialCard1.Controls.Add(label4);
            materialCard1.Controls.Add(label5);
            materialCard1.Controls.Add(lb_ins_phone);
            materialCard1.Controls.Add(label3);
            materialCard1.Controls.Add(lb_ins_email);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(lb_title_std_control);
            materialCard1.Controls.Add(lb_ins_name);
            materialCard1.Controls.Add(label1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(316, 64);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(948, 689);
            materialCard1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(771, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // flp_cards
            // 
            flp_cards.BackColor = Color.White;
            flp_cards.Font = new Font("Tahoma", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            flp_cards.ForeColor = Color.White;
            flp_cards.Location = new Point(245, 470);
            flp_cards.Name = "flp_cards";
            flp_cards.Size = new Size(346, 171);
            flp_cards.TabIndex = 18;
            // 
            // lb_ins_address
            // 
            lb_ins_address.AutoSize = true;
            lb_ins_address.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lb_ins_address.ForeColor = Color.SteelBlue;
            lb_ins_address.Location = new Point(377, 382);
            lb_ins_address.Name = "lb_ins_address";
            lb_ins_address.Size = new Size(0, 28);
            lb_ins_address.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(120, 382);
            label4.Name = "label4";
            label4.Size = new Size(245, 28);
            label4.TabIndex = 8;
            label4.Text = "Instructor Address: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(120, 461);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 10;
            label5.Text = "Group: ";
            // 
            // lb_ins_phone
            // 
            lb_ins_phone.AutoSize = true;
            lb_ins_phone.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lb_ins_phone.ForeColor = Color.SteelBlue;
            lb_ins_phone.Location = new Point(377, 329);
            lb_ins_phone.Name = "lb_ins_phone";
            lb_ins_phone.Size = new Size(0, 28);
            lb_ins_phone.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(120, 329);
            label3.Name = "label3";
            label3.Size = new Size(226, 28);
            label3.TabIndex = 12;
            label3.Text = "Instructor Phone: ";
            // 
            // lb_ins_email
            // 
            lb_ins_email.AutoSize = true;
            lb_ins_email.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lb_ins_email.ForeColor = Color.SteelBlue;
            lb_ins_email.Location = new Point(377, 270);
            lb_ins_email.Name = "lb_ins_email";
            lb_ins_email.Size = new Size(0, 28);
            lb_ins_email.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(120, 270);
            label2.Name = "label2";
            label2.Size = new Size(217, 28);
            label2.TabIndex = 14;
            label2.Text = "Instructor Email: ";
            // 
            // lb_title_std_control
            // 
            lb_title_std_control.AutoSize = true;
            lb_title_std_control.Font = new Font("Tahoma", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_title_std_control.ForeColor = Color.RoyalBlue;
            lb_title_std_control.Location = new Point(297, 31);
            lb_title_std_control.Name = "lb_title_std_control";
            lb_title_std_control.Size = new Size(338, 34);
            lb_title_std_control.TabIndex = 15;
            lb_title_std_control.Text = "Instructor Information";
            // 
            // lb_ins_name
            // 
            lb_ins_name.AutoSize = true;
            lb_ins_name.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lb_ins_name.ForeColor = Color.SteelBlue;
            lb_ins_name.Location = new Point(377, 213);
            lb_ins_name.Name = "lb_ins_name";
            lb_ins_name.Size = new Size(0, 28);
            lb_ins_name.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(120, 213);
            label1.Name = "label1";
            label1.Size = new Size(221, 28);
            label1.TabIndex = 17;
            label1.Text = "Instructor Name: ";
            // 
            // InstructorDashboardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(materialCard1);
            Name = "InstructorDashboardControl";
            Size = new Size(1344, 772);
            Load += Instructor_dashboard_load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lb_ins_address;
        private Label label4;
        private Label label5;
        private Label lb_ins_phone;
        private Label label3;
        private Label lb_ins_email;
        private Label label2;
        private Label lb_title_std_control;
        private Label lb_ins_name;
        private Label label1;
        private FlowLayoutPanel flp_cards;
        private PictureBox pictureBox1;
    }
}
