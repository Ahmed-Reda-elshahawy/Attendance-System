namespace Attendance_System.PresentationLayer.UserControls
{
    partial class StudentAttendanceControl
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblsSSAtt = new Label();
            sltSSAtt = new ComboBox();
            dvgAttStudent = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgAttStudent).BeginInit();
            SuspendLayout();
            // 
            // lblsSSAtt
            // 
            lblsSSAtt.AutoSize = true;
            lblsSSAtt.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            lblsSSAtt.Location = new Point(208, 132);
            lblsSSAtt.Name = "lblsSSAtt";
            lblsSSAtt.Size = new Size(156, 19);
            lblsSSAtt.TabIndex = 13;
            lblsSSAtt.Text = "Attendance Status";
            // 
            // sltSSAtt
            // 
            sltSSAtt.FormattingEnabled = true;
            sltSSAtt.Location = new Point(208, 166);
            sltSSAtt.Name = "sltSSAtt";
            sltSSAtt.Size = new Size(250, 31);
            sltSSAtt.TabIndex = 12;
            // 
            // dvgAttStudent
            // 
            dvgAttStudent.AllowUserToAddRows = false;
            dvgAttStudent.AllowUserToDeleteRows = false;
            dvgAttStudent.AllowUserToResizeColumns = false;
            dvgAttStudent.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dvgAttStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dvgAttStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgAttStudent.BackgroundColor = Color.White;
            dvgAttStudent.BorderStyle = BorderStyle.None;
            dvgAttStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvgAttStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9.75F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dvgAttStudent.DefaultCellStyle = dataGridViewCellStyle5;
            dvgAttStudent.GridColor = SystemColors.ActiveCaptionText;
            dvgAttStudent.Location = new Point(208, 295);
            dvgAttStudent.Name = "dvgAttStudent";
            dvgAttStudent.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.SteelBlue;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9.75F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dvgAttStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dvgAttStudent.RowHeadersWidth = 51;
            dvgAttStudent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvgAttStudent.RowTemplate.Height = 26;
            dvgAttStudent.ShowCellErrors = false;
            dvgAttStudent.ShowEditingIcon = false;
            dvgAttStudent.ShowRowErrors = false;
            dvgAttStudent.Size = new Size(1064, 364);
            dvgAttStudent.TabIndex = 1;
            dvgAttStudent.CellContentClick += dvgAttStudent_CellContentClick;
            // 
            // StudentAttendanceControl
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblsSSAtt);
            Controls.Add(sltSSAtt);
            Controls.Add(dvgAttStudent);
            Font = new Font("Century Gothic", 12F);
            ForeColor = Color.Black;
            Margin = new Padding(5, 4, 5, 4);
            Name = "StudentAttendanceControl";
            Size = new Size(1863, 1025);
            ((System.ComponentModel.ISupportInitialize)dvgAttStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Panel panel5;
        private DateTimePicker dtRepGroup;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private Label label2;
        private Label lblsSSAtt;
        private ComboBox sltSSAtt;
        private DataGridView dvgAttStudent;
    }
}
