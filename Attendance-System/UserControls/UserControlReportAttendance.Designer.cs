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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlReportAttendance));
            tabControlReport = new TabControl();
            tabPageMarkAttendance = new TabPage();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            comboBoxClass = new ComboBox();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            panel5 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tabPage1 = new TabPage();
            pictureBoxPrint = new PictureBox();
            panel8 = new Panel();
            comboBox2 = new ComboBox();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            panel9 = new Panel();
            comboBox3 = new ComboBox();
            label6 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel10 = new Panel();
            panel11 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            label7 = new Label();
            label8 = new Label();
            tabControlReport.SuspendLayout();
            tabPageMarkAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel10.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlReport
            // 
            tabControlReport.Alignment = TabAlignment.Bottom;
            tabControlReport.Anchor = AnchorStyles.None;
            tabControlReport.Controls.Add(tabPageMarkAttendance);
            tabControlReport.Controls.Add(tabPage1);
            tabControlReport.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlReport.Location = new Point(155, 22);
            tabControlReport.Margin = new Padding(4);
            tabControlReport.Name = "tabControlReport";
            tabControlReport.SelectedIndex = 0;
            tabControlReport.Size = new Size(1173, 513);
            tabControlReport.TabIndex = 1;
            // 
            // tabPageMarkAttendance
            // 
            tabPageMarkAttendance.Controls.Add(pictureBox1);
            tabPageMarkAttendance.Controls.Add(dataGridView1);
            tabPageMarkAttendance.Controls.Add(panel6);
            tabPageMarkAttendance.Controls.Add(comboBoxClass);
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
            tabPageMarkAttendance.Size = new Size(1165, 472);
            tabPageMarkAttendance.TabIndex = 0;
            tabPageMarkAttendance.Text = "Group Report";
            tabPageMarkAttendance.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1104, 8);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column6, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(58, 161);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1098, 303);
            dataGridView1.TabIndex = 10;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Student_Name";
            Column2.HeaderText = "Student Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "StdNo";
            Column6.HeaderText = "StdNo";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Group_Name";
            Column3.HeaderText = "Group";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Attendance_Date";
            Column4.HeaderText = "Date";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Attendance_Status";
            Column5.HeaderText = "Status";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Location = new Point(680, 132);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(351, 3);
            panel6.TabIndex = 9;
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.Flat;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(680, 97);
            comboBoxClass.Margin = new Padding(4);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(349, 36);
            comboBoxClass.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(676, 61);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 7;
            label3.Text = "Group:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Location = new Point(143, 132);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(351, 3);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Location = new Point(131, 97);
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
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(12, 0);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(349, 35);
            dateTimePicker1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(143, 127);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(351, 13);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(143, 87);
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
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(139, 61);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 1;
            label2.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(67, 31, 125);
            label1.Location = new Point(4, 4);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 0;
            label1.Text = "Group Report: ";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBoxPrint);
            tabPage1.Controls.Add(panel8);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(panel9);
            tabPage1.Controls.Add(comboBox3);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(flowLayoutPanel2);
            tabPage1.Controls.Add(panel10);
            tabPage1.Controls.Add(panel12);
            tabPage1.Controls.Add(panel13);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1165, 472);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Student Report";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPrint
            // 
            pictureBoxPrint.Cursor = Cursors.Hand;
            pictureBoxPrint.Image = (Image)resources.GetObject("pictureBoxPrint.Image");
            pictureBoxPrint.Location = new Point(1108, 4);
            pictureBoxPrint.Margin = new Padding(4);
            pictureBoxPrint.Name = "pictureBoxPrint";
            pictureBoxPrint.Size = new Size(52, 53);
            pictureBoxPrint.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPrint.TabIndex = 27;
            pictureBoxPrint.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Location = new Point(864, 136);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(267, 3);
            panel8.TabIndex = 26;
            panel8.Paint += panel8_Paint;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(864, 101);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(267, 36);
            comboBox2.TabIndex = 25;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(859, 65);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 19);
            label5.TabIndex = 24;
            label5.Text = "Student Number:";
            label5.Click += label5_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView2.Location = new Point(62, 161);
            dataGridView2.Margin = new Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1098, 303);
            dataGridView2.TabIndex = 23;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Student_Name";
            dataGridViewTextBoxColumn1.HeaderText = "Student Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "StdNo";
            dataGridViewTextBoxColumn2.HeaderText = "StdNo";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Group_Name";
            dataGridViewTextBoxColumn3.HeaderText = "Group";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Attendance_Date";
            dataGridViewTextBoxColumn4.HeaderText = "Date";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Attendance_Status";
            dataGridViewTextBoxColumn5.HeaderText = "Status";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.Location = new Point(494, 132);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(351, 3);
            panel9.TabIndex = 22;
            panel9.Paint += panel9_Paint;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(494, 97);
            comboBox3.Margin = new Padding(4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(349, 36);
            comboBox3.TabIndex = 21;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(490, 61);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 19);
            label6.TabIndex = 20;
            label6.Text = "Group:";
            label6.Click += label6_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.LightGray;
            flowLayoutPanel2.Location = new Point(88, 132);
            flowLayoutPanel2.Margin = new Padding(4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(351, 3);
            flowLayoutPanel2.TabIndex = 19;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(dateTimePicker2);
            panel10.Location = new Point(77, 97);
            panel10.Margin = new Padding(4);
            panel10.Name = "panel10";
            panel10.Size = new Size(374, 31);
            panel10.TabIndex = 18;
            panel10.Paint += panel10_Paint;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Transparent;
            panel11.Location = new Point(306, 0);
            panel11.Margin = new Padding(4);
            panel11.Name = "panel11";
            panel11.Size = new Size(13, 31);
            panel11.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy/MM";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(12, 0);
            dateTimePicker2.Margin = new Padding(4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(349, 35);
            dateTimePicker2.TabIndex = 7;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Transparent;
            panel12.Location = new Point(88, 127);
            panel12.Margin = new Padding(4);
            panel12.Name = "panel12";
            panel12.Size = new Size(351, 13);
            panel12.TabIndex = 17;
            panel12.Paint += panel12_Paint;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Transparent;
            panel13.Controls.Add(panel14);
            panel13.Location = new Point(88, 87);
            panel13.Margin = new Padding(4);
            panel13.Name = "panel13";
            panel13.Size = new Size(351, 13);
            panel13.TabIndex = 16;
            panel13.Paint += panel13_Paint;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Transparent;
            panel14.Location = new Point(299, 11);
            panel14.Margin = new Padding(4);
            panel14.Name = "panel14";
            panel14.Size = new Size(13, 31);
            panel14.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(84, 61);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(52, 19);
            label7.TabIndex = 15;
            label7.Text = "Date:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(7, 4);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(152, 23);
            label8.TabIndex = 14;
            label8.Text = "Group Report: ";
            label8.Click += label8_Click;
            // 
            // UserControlReportAttendance
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlReport);
            Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.RoyalBlue;
            Margin = new Padding(6, 5, 6, 5);
            Name = "UserControlReportAttendance";
            Size = new Size(1537, 724);
            tabControlReport.ResumeLayout(false);
            tabPageMarkAttendance.ResumeLayout(false);
            tabPageMarkAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel10.ResumeLayout(false);
            panel13.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReport;
        private System.Windows.Forms.TabPage tabPageMarkAttendance;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxPrint;
        private PictureBox pictureBox1;
    }
}
