namespace Attendance_System.PresentationLayer.Forms
{
    partial class UpdateForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            updateGroupControl1 = new UserControls.UpdateGroupControl();
            SuspendLayout();
            // 
            // updateGroupControl1
            // 
            updateGroupControl1.BackColor = Color.White;
            updateGroupControl1.Location = new Point(-1, 0);
            updateGroupControl1.Name = "updateGroupControl1";
            updateGroupControl1.Size = new Size(879, 636);
            updateGroupControl1.TabIndex = 0;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(881, 632);
            Controls.Add(updateGroupControl1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(881, 632);
            MinimizeBox = false;
            MinimumSize = new Size(881, 632);
            Name = "UpdateForm";
            Text = "UpdateForm";
            Load += UpdateForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UpdateGroupControl updateGroupControl1;
    }
}