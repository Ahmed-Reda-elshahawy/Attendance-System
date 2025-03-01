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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel6 = new Panel();
            lblsSSAtt = new Label();
            sltSSAtt = new ComboBox();
            dvgAttStudent = new DataGridView();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgAttStudent).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.Controls.Add(lblsSSAtt);
            panel6.Controls.Add(sltSSAtt);
            panel6.Controls.Add(dvgAttStudent);
            panel6.Dock = DockStyle.Fill;
            panel6.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1649, 716);
            panel6.TabIndex = 0;
            // 
            // lblsSSAtt
            // 
            lblsSSAtt.AutoSize = true;
            lblsSSAtt.Font = new Font("Tahoma", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblsSSAtt.ForeColor = Color.RoyalBlue;
            lblsSSAtt.Location = new Point(59, 118);
            lblsSSAtt.Name = "lblsSSAtt";
            lblsSSAtt.Size = new Size(199, 28);
            lblsSSAtt.TabIndex = 16;
            lblsSSAtt.Text = "Attendance Status";
            // 
            // sltSSAtt
            // 
            sltSSAtt.FormattingEnabled = true;
            sltSSAtt.Location = new Point(59, 158);
            sltSSAtt.Name = "sltSSAtt";
            sltSSAtt.Size = new Size(250, 36);
            sltSSAtt.TabIndex = 15;
            // 
            // dvgAttStudent
            // 
            dvgAttStudent.AllowUserToAddRows = false;
            dvgAttStudent.AllowUserToDeleteRows = false;
            dvgAttStudent.AllowUserToResizeColumns = false;
            dvgAttStudent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dvgAttStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dvgAttStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgAttStudent.BackgroundColor = Color.White;
            dvgAttStudent.BorderStyle = BorderStyle.None;
            dvgAttStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvgAttStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dvgAttStudent.DefaultCellStyle = dataGridViewCellStyle2;
            dvgAttStudent.GridColor = SystemColors.ActiveCaptionText;
            dvgAttStudent.Location = new Point(59, 235);
            dvgAttStudent.Name = "dvgAttStudent";
            dvgAttStudent.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dvgAttStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dvgAttStudent.RowHeadersWidth = 51;
            dvgAttStudent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvgAttStudent.RowTemplate.Height = 26;
            dvgAttStudent.ShowCellErrors = false;
            dvgAttStudent.ShowEditingIcon = false;
            dvgAttStudent.ShowRowErrors = false;
            dvgAttStudent.Size = new Size(1530, 364);
            dvgAttStudent.TabIndex = 14;
            // 
            // StudentAttendanceControl
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel6);
            Font = new Font("Century Gothic", 12F);
            ForeColor = Color.Black;
            Margin = new Padding(5, 4, 5, 4);
            Name = "StudentAttendanceControl";
            Size = new Size(1649, 716);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgAttStudent).EndInit();
            ResumeLayout(false);
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
        private Panel panel6;
        private Label lblsSSAtt;
        private ComboBox sltSSAtt;
        private DataGridView dvgAttStudent;
    }
}
