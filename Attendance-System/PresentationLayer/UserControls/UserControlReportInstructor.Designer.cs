namespace Attendance_System.PresentationLayer.UserControls
{
    partial class UserControlReportInstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlReportInstructor));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBoxPrint = new PictureBox();
            panel8 = new Panel();
            label8 = new Label();
            viewinsAtt = new Button();
            txtGroupRep = new TextBox();
            panel7 = new Panel();
            dvgGroupRepIns = new DataGridView();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            panel5 = new Panel();
            dtRepGroup = new DateTimePicker();
            dvgStudentRep = new DataGridView();
            view1 = new Button();
            txtStdId = new TextBox();
            panel15 = new Panel();
            tabPage1 = new TabPage();
            label5 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel1 = new Panel();
            tabPageMarkAttendance = new TabPage();
            label2 = new Label();
            GroupRep = new TabControl();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgGroupRepIns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgStudentRep).BeginInit();
            panel15.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPageMarkAttendance.SuspendLayout();
            GroupRep.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxPrint
            // 
            pictureBoxPrint.Cursor = Cursors.Hand;
            pictureBoxPrint.Image = (Image)resources.GetObject("pictureBoxPrint.Image");
            pictureBoxPrint.Location = new Point(1414, 8);
            pictureBoxPrint.Margin = new Padding(4);
            pictureBoxPrint.Name = "pictureBoxPrint";
            pictureBoxPrint.Size = new Size(52, 53);
            pictureBoxPrint.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPrint.TabIndex = 27;
            pictureBoxPrint.TabStop = false;
            pictureBoxPrint.Click += pictureBoxPrint_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Location = new Point(577, 119);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 3);
            panel8.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(11, 8);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(244, 38);
            label8.TabIndex = 14;
            label8.Text = "Student Report: ";
            // 
            // viewinsAtt
            // 
            viewinsAtt.BackColor = Color.RoyalBlue;
            viewinsAtt.ForeColor = Color.White;
            viewinsAtt.Location = new Point(1066, 74);
            viewinsAtt.Name = "viewinsAtt";
            viewinsAtt.Size = new Size(113, 39);
            viewinsAtt.TabIndex = 31;
            viewinsAtt.Text = "view";
            viewinsAtt.UseVisualStyleBackColor = false;
            viewinsAtt.Click += viewinsAtt_Click;
            // 
            // txtGroupRep
            // 
            txtGroupRep.BackColor = Color.FromArgb(224, 224, 224);
            txtGroupRep.Location = new Point(756, 76);
            txtGroupRep.Name = "txtGroupRep";
            txtGroupRep.Size = new Size(204, 35);
            txtGroupRep.TabIndex = 30;
            // 
            // panel7
            // 
            panel7.Controls.Add(dvgGroupRepIns);
            panel7.Location = new Point(60, 151);
            panel7.Name = "panel7";
            panel7.Size = new Size(1360, 571);
            panel7.TabIndex = 29;
            // 
            // dvgGroupRepIns
            // 
            dvgGroupRepIns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgGroupRepIns.BackgroundColor = Color.White;
            dvgGroupRepIns.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgGroupRepIns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgGroupRepIns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dvgGroupRepIns.DefaultCellStyle = dataGridViewCellStyle2;
            dvgGroupRepIns.Dock = DockStyle.Fill;
            dvgGroupRepIns.Location = new Point(0, 0);
            dvgGroupRepIns.Name = "dvgGroupRepIns";
            dvgGroupRepIns.RowHeadersWidth = 51;
            dvgGroupRepIns.Size = new Size(1360, 571);
            dvgGroupRepIns.TabIndex = 0;
            dvgGroupRepIns.CellContentClick += dvgGroupRepIns_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1414, 8);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Location = new Point(756, 110);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 3);
            panel6.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(661, 87);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 27);
            label3.TabIndex = 7;
            label3.Text = "Group:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Location = new Point(211, 118);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(351, 3);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(dtRepGroup);
            panel3.Location = new Point(199, 83);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(374, 31);
            panel3.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Location = new Point(306, 0);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(13, 31);
            panel5.TabIndex = 7;
            // 
            // dtRepGroup
            // 
            dtRepGroup.CustomFormat = "yyyy/MM/dd";
            dtRepGroup.Format = DateTimePickerFormat.Custom;
            dtRepGroup.Location = new Point(12, 0);
            dtRepGroup.Margin = new Padding(4);
            dtRepGroup.Name = "dtRepGroup";
            dtRepGroup.Size = new Size(349, 35);
            dtRepGroup.TabIndex = 7;
            // 
            // dvgStudentRep
            // 
            dvgStudentRep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgStudentRep.BackgroundColor = Color.White;
            dvgStudentRep.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dvgStudentRep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dvgStudentRep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dvgStudentRep.DefaultCellStyle = dataGridViewCellStyle4;
            dvgStudentRep.Dock = DockStyle.Fill;
            dvgStudentRep.Location = new Point(0, 0);
            dvgStudentRep.Name = "dvgStudentRep";
            dvgStudentRep.RowHeadersWidth = 51;
            dvgStudentRep.Size = new Size(1358, 600);
            dvgStudentRep.TabIndex = 0;
            dvgStudentRep.CellContentClick += dvgStudentRep_CellContentClick;
            // 
            // view1
            // 
            view1.BackColor = Color.RoyalBlue;
            view1.ForeColor = Color.White;
            view1.Location = new Point(846, 84);
            view1.Name = "view1";
            view1.Size = new Size(134, 36);
            view1.TabIndex = 32;
            view1.Text = "view";
            view1.UseVisualStyleBackColor = false;
            // 
            // txtStdId
            // 
            txtStdId.Location = new Point(577, 83);
            txtStdId.Name = "txtStdId";
            txtStdId.Size = new Size(200, 35);
            txtStdId.TabIndex = 31;
            // 
            // panel15
            // 
            panel15.Controls.Add(dvgStudentRep);
            panel15.Location = new Point(59, 153);
            panel15.Name = "panel15";
            panel15.Size = new Size(1358, 600);
            panel15.TabIndex = 30;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(view1);
            tabPage1.Controls.Add(txtStdId);
            tabPage1.Controls.Add(panel15);
            tabPage1.Controls.Add(pictureBoxPrint);
            tabPage1.Controls.Add(panel8);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label8);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 4);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1474, 655);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Student Report";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(416, 93);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 27);
            label5.TabIndex = 24;
            label5.Text = "Student Id:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(211, 113);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(351, 13);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(8, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 38);
            label1.TabIndex = 0;
            label1.Text = "Group Report: ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Location = new Point(299, 11);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(13, 31);
            panel4.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(211, 73);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 13);
            panel1.TabIndex = 3;
            // 
            // tabPageMarkAttendance
            // 
            tabPageMarkAttendance.Controls.Add(viewinsAtt);
            tabPageMarkAttendance.Controls.Add(txtGroupRep);
            tabPageMarkAttendance.Controls.Add(panel7);
            tabPageMarkAttendance.Controls.Add(pictureBox1);
            tabPageMarkAttendance.Controls.Add(panel6);
            tabPageMarkAttendance.Controls.Add(label3);
            tabPageMarkAttendance.Controls.Add(flowLayoutPanel1);
            tabPageMarkAttendance.Controls.Add(panel3);
            tabPageMarkAttendance.Controls.Add(panel2);
            tabPageMarkAttendance.Controls.Add(panel1);
            tabPageMarkAttendance.Controls.Add(label2);
            tabPageMarkAttendance.Controls.Add(label1);
            tabPageMarkAttendance.ForeColor = Color.Black;
            tabPageMarkAttendance.Location = new Point(4, 4);
            tabPageMarkAttendance.Margin = new Padding(4);
            tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            tabPageMarkAttendance.Padding = new Padding(4);
            tabPageMarkAttendance.Size = new Size(1474, 655);
            tabPageMarkAttendance.TabIndex = 0;
            tabPageMarkAttendance.Text = "Group Report";
            tabPageMarkAttendance.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label2.Location = new Point(115, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 27);
            label2.TabIndex = 1;
            label2.Text = "Date:";
            // 
            // GroupRep
            // 
            GroupRep.Alignment = TabAlignment.Bottom;
            GroupRep.Controls.Add(tabPageMarkAttendance);
            GroupRep.Controls.Add(tabPage1);
            GroupRep.Dock = DockStyle.Fill;
            GroupRep.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupRep.Location = new Point(0, 0);
            GroupRep.Margin = new Padding(0);
            GroupRep.Name = "GroupRep";
            GroupRep.SelectedIndex = 0;
            GroupRep.Size = new Size(1482, 696);
            GroupRep.TabIndex = 2;
            GroupRep.Click += GroupRep_Click;
            // 
            // UserControlReportInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GroupRep);
            Name = "UserControlReportInstructor";
            Size = new Size(1482, 696);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgGroupRepIns).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgStudentRep).EndInit();
            panel15.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            tabPageMarkAttendance.ResumeLayout(false);
            tabPageMarkAttendance.PerformLayout();
            GroupRep.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxPrint;
        private Panel panel8;
        private Label label8;
        private Button viewinsAtt;
        private TextBox txtGroupRep;
        private Panel panel7;
        public DataGridView dvgGroupRepIns;
        private PictureBox pictureBox1;
        private Panel panel6;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Panel panel5;
        private DateTimePicker dtRepGroup;
        private DataGridView dvgStudentRep;
        private Button view1;
        private TextBox txtStdId;
        private Panel panel15;
        private TabPage tabPage1;
        private Label label5;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private Panel panel1;
        private TabPage tabPageMarkAttendance;
        private Label label2;
        private TabControl GroupRep;
    }
}
