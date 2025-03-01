namespace Report
{
    partial class UserControlReportAttendance
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlReportAttendance));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            GroupRep = new TabControl();
            tabPageMarkAttendance = new TabPage();
            view = new Button();
            txtGroupRep = new TextBox();
            panel7 = new Panel();
            dvgGroupRep = new DataGridView();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            panel5 = new Panel();
            dtRepGroup = new DateTimePicker();
            panel2 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tabPage1 = new TabPage();
            view1 = new Button();
            txtStdId = new TextBox();
            panel15 = new Panel();
            dvgStudentRep = new DataGridView();
            pictureBoxPrint = new PictureBox();
            panel8 = new Panel();
            label5 = new Label();
            label8 = new Label();
            GroupRep.SuspendLayout();
            tabPageMarkAttendance.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgGroupRep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgStudentRep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).BeginInit();
            SuspendLayout();
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
            GroupRep.TabIndex = 1;
            GroupRep.Click += GroupRep_Click;
            // 
            // tabPageMarkAttendance
            // 
            tabPageMarkAttendance.BackColor = Color.White;
            tabPageMarkAttendance.Controls.Add(view);
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
            tabPageMarkAttendance.Location = new Point(4, 4);
            tabPageMarkAttendance.Margin = new Padding(4);
            tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            tabPageMarkAttendance.Padding = new Padding(4);
            tabPageMarkAttendance.Size = new Size(1474, 655);
            tabPageMarkAttendance.TabIndex = 0;
            tabPageMarkAttendance.Text = "Group Report";
            // 
            // view
            // 
            view.BackColor = Color.RoyalBlue;
            view.ForeColor = Color.White;
            view.Location = new Point(906, 87);
            view.Name = "view";
            view.Size = new Size(113, 42);
            view.TabIndex = 31;
            view.Text = "view";
            view.UseVisualStyleBackColor = false;
            view.Click += view_Click;
            // 
            // txtGroupRep
            // 
            txtGroupRep.BackColor = Color.White;
            txtGroupRep.BorderStyle = BorderStyle.None;
            txtGroupRep.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGroupRep.Location = new Point(676, 88);
            txtGroupRep.Name = "txtGroupRep";
            txtGroupRep.PlaceholderText = "Group";
            txtGroupRep.Size = new Size(204, 25);
            txtGroupRep.TabIndex = 30;
            txtGroupRep.TextChanged += txtGroupRep_TextChanged;
            // 
            // panel7
            // 
            panel7.Controls.Add(dvgGroupRep);
            panel7.Location = new Point(60, 151);
            panel7.Name = "panel7";
            panel7.Size = new Size(1360, 571);
            panel7.TabIndex = 29;
            // 
            // dvgGroupRep
            // 
            dvgGroupRep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgGroupRep.BackgroundColor = Color.White;
            dvgGroupRep.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dvgGroupRep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dvgGroupRep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dvgGroupRep.DefaultCellStyle = dataGridViewCellStyle6;
            dvgGroupRep.Dock = DockStyle.Fill;
            dvgGroupRep.Location = new Point(0, 0);
            dvgGroupRep.Name = "dvgGroupRep";
            dvgGroupRep.RowHeadersWidth = 51;
            dvgGroupRep.Size = new Size(1360, 571);
            dvgGroupRep.TabIndex = 0;
            dvgGroupRep.CellContentClick += dvgGroupRep_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1368, 28);
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
            panel6.Location = new Point(676, 121);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 3);
            panel6.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label3.Location = new Point(577, 94);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 27);
            label3.TabIndex = 7;
            label3.Text = "Group:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Location = new Point(172, 126);
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
            panel3.Location = new Point(160, 91);
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
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(172, 121);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(351, 13);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(172, 81);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 13);
            panel1.TabIndex = 3;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label2.Location = new Point(72, 91);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 27);
            label2.TabIndex = 1;
            label2.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(4, 4);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 38);
            label1.TabIndex = 0;
            label1.Text = "Group Report: ";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(view1);
            tabPage1.Controls.Add(txtStdId);
            tabPage1.Controls.Add(panel15);
            tabPage1.Controls.Add(pictureBoxPrint);
            tabPage1.Controls.Add(panel8);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label8);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1474, 655);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Student Report";
            tabPage1.Click += tabPage1_Click;
            // 
            // view1
            // 
            view1.BackColor = Color.RoyalBlue;
            view1.ForeColor = Color.White;
            view1.Location = new Point(453, 98);
            view1.Name = "view1";
            view1.Size = new Size(134, 36);
            view1.TabIndex = 32;
            view1.Text = "view";
            view1.UseVisualStyleBackColor = false;
            view1.Click += view1_Click;
            // 
            // txtStdId
            // 
            txtStdId.BorderStyle = BorderStyle.None;
            txtStdId.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStdId.Location = new Point(227, 100);
            txtStdId.Name = "txtStdId";
            txtStdId.PlaceholderText = "Student id";
            txtStdId.Size = new Size(200, 25);
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
            // dvgStudentRep
            // 
            dvgStudentRep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgStudentRep.BackgroundColor = Color.White;
            dvgStudentRep.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dvgStudentRep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dvgStudentRep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dvgStudentRep.DefaultCellStyle = dataGridViewCellStyle8;
            dvgStudentRep.Dock = DockStyle.Fill;
            dvgStudentRep.Location = new Point(0, 0);
            dvgStudentRep.Name = "dvgStudentRep";
            dvgStudentRep.RowHeadersWidth = 51;
            dvgStudentRep.Size = new Size(1358, 600);
            dvgStudentRep.TabIndex = 0;
            // 
            // pictureBoxPrint
            // 
            pictureBoxPrint.Cursor = Cursors.Hand;
            pictureBoxPrint.Image = (Image)resources.GetObject("pictureBoxPrint.Image");
            pictureBoxPrint.Location = new Point(1365, 19);
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
            panel8.Location = new Point(227, 133);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 3);
            panel8.TabIndex = 26;
            panel8.Paint += panel8_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(62, 103);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 27);
            label5.TabIndex = 24;
            label5.Text = "Student Id:";
            label5.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(20, 19);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(244, 38);
            label8.TabIndex = 14;
            label8.Text = "Student Report: ";
            label8.Click += label8_Click;
            // 
            // UserControlReportAttendance
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(GroupRep);
            Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.RoyalBlue;
            Margin = new Padding(6, 5, 6, 5);
            Name = "UserControlReportAttendance";
            Size = new Size(1482, 696);
            GroupRep.ResumeLayout(false);
            tabPageMarkAttendance.ResumeLayout(false);
            tabPageMarkAttendance.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgGroupRep).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgStudentRep).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl GroupRep;
        private System.Windows.Forms.TabPage tabPageMarkAttendance;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtRepGroup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxPrint;
        private PictureBox pictureBox1;
        private Panel panel7;
        private Panel panel15;
        //public one
        public DataGridView dvgGroupRep;
        private DataGridView dvgStudentRep;
        private TextBox txtGroupRep;
        private Button view;
        private TextBox txtStdId;
        private Button view1;
    }
}
