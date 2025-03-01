namespace Attendance
{
    partial class usercontrolAttendance
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabPageMarkAttendance = new TabPage();
            txtAtt = new TextBox();
            save = new Button();
            getAtt = new Button();
            panel7 = new Panel();
            dvgAtt = new DataGridView();
            panel6 = new Panel();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            panel5 = new Panel();
            dtAtt = new DateTimePicker();
            panel2 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageMarkAttendance.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgAtt).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageMarkAttendance
            // 
            tabPageMarkAttendance.BackColor = Color.White;
            tabPageMarkAttendance.Controls.Add(txtAtt);
            tabPageMarkAttendance.Controls.Add(save);
            tabPageMarkAttendance.Controls.Add(getAtt);
            tabPageMarkAttendance.Controls.Add(panel7);
            tabPageMarkAttendance.Controls.Add(panel6);
            tabPageMarkAttendance.Controls.Add(label3);
            tabPageMarkAttendance.Controls.Add(flowLayoutPanel1);
            tabPageMarkAttendance.Controls.Add(panel3);
            tabPageMarkAttendance.Controls.Add(panel2);
            tabPageMarkAttendance.Controls.Add(panel1);
            tabPageMarkAttendance.Controls.Add(label2);
            tabPageMarkAttendance.Controls.Add(label1);
            tabPageMarkAttendance.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPageMarkAttendance.ForeColor = Color.Black;
            tabPageMarkAttendance.Location = new Point(4, 4);
            tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            tabPageMarkAttendance.Padding = new Padding(3);
            tabPageMarkAttendance.Size = new Size(1474, 680);
            tabPageMarkAttendance.TabIndex = 0;
            tabPageMarkAttendance.Text = "Mark Attendance";
            // 
            // txtAtt
            // 
            txtAtt.BackColor = Color.White;
            txtAtt.BorderStyle = BorderStyle.None;
            txtAtt.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAtt.ForeColor = Color.Black;
            txtAtt.Location = new Point(613, 91);
            txtAtt.Name = "txtAtt";
            txtAtt.PlaceholderText = "Group";
            txtAtt.Size = new Size(200, 25);
            txtAtt.TabIndex = 13;
            // 
            // save
            // 
            save.BackColor = Color.RoyalBlue;
            save.Cursor = Cursors.Hand;
            save.ForeColor = Color.White;
            save.Location = new Point(1285, 94);
            save.Name = "save";
            save.Size = new Size(107, 39);
            save.TabIndex = 12;
            save.Text = "save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // getAtt
            // 
            getAtt.BackColor = Color.RoyalBlue;
            getAtt.Cursor = Cursors.Hand;
            getAtt.ForeColor = Color.White;
            getAtt.Location = new Point(859, 91);
            getAtt.Name = "getAtt";
            getAtt.Size = new Size(110, 39);
            getAtt.TabIndex = 11;
            getAtt.Text = "view";
            getAtt.UseVisualStyleBackColor = false;
            getAtt.Click += getAtt_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(dvgAtt);
            panel7.ForeColor = Color.Black;
            panel7.Location = new Point(57, 162);
            panel7.Name = "panel7";
            panel7.Size = new Size(1335, 471);
            panel7.TabIndex = 10;
            // 
            // dvgAtt
            // 
            dvgAtt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgAtt.BackgroundColor = Color.White;
            dvgAtt.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgAtt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgAtt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dvgAtt.DefaultCellStyle = dataGridViewCellStyle2;
            dvgAtt.Dock = DockStyle.Fill;
            dvgAtt.Location = new Point(0, 0);
            dvgAtt.Name = "dvgAtt";
            dvgAtt.RowHeadersWidth = 51;
            dvgAtt.Size = new Size(1335, 471);
            dvgAtt.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Location = new Point(613, 126);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 2);
            panel6.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(500, 100);
            label3.Name = "label3";
            label3.Size = new Size(88, 27);
            label3.TabIndex = 7;
            label3.Text = "Group:";
            label3.Click += label3_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Location = new Point(180, 125);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(270, 2);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(dtAtt);
            panel3.Location = new Point(171, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 35);
            panel3.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Location = new Point(229, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 35);
            panel5.TabIndex = 7;
            // 
            // dtAtt
            // 
            dtAtt.CustomFormat = "yyyy/MM/dd";
            dtAtt.Format = DateTimePickerFormat.Custom;
            dtAtt.Location = new Point(9, 0);
            dtAtt.Name = "dtAtt";
            dtAtt.Size = new Size(270, 36);
            dtAtt.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(180, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 10);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(180, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 10);
            panel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Location = new Point(230, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 23);
            panel4.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(72, 93);
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
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(296, 38);
            label1.TabIndex = 0;
            label1.Text = "Mark Attendance : ";
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPageMarkAttendance);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1482, 720);
            tabControl1.TabIndex = 0;
            // 
            // usercontrolAttendance
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControl1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "usercontrolAttendance";
            Size = new Size(1482, 720);
            tabPageMarkAttendance.ResumeLayout(false);
            tabPageMarkAttendance.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgAtt).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TabPage tabPageMarkAttendance;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtAtt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private Button save;
        private Button getAtt;
        private Panel panel7;
        private DataGridView dvgAtt;
        private TextBox txtAtt;
    }
}
