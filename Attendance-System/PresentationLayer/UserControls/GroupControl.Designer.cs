namespace Attendance_System.PresentationLayer.UserControls
{
    partial class GroupControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupControl));
            tabControlG = new TabControl();
            tabPageAddG = new TabPage();
            LblInvlideSLT = new Label();
            LblInvalidNumOfStudent = new Label();
            LblInvalidCode = new Label();
            InvlideSLT = new PictureBox();
            InvalidNumOfStudent = new PictureBox();
            InvalidCode = new PictureBox();
            btnAddG = new Button();
            panel5 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            txtDiscription = new TextBox();
            txtNOS = new TextBox();
            sltINS = new ComboBox();
            txtGC = new TextBox();
            lblinstructorSelect = new Label();
            lblDiscription = new Label();
            lblnumofS = new Label();
            lblGC = new Label();
            LbLAddG = new Label();
            tabPageSearchG = new TabPage();
            btnGUpdate = new Button();
            btnGDelete = new Button();
            lblSINS = new Label();
            lblSGC = new Label();
            sltSGI = new ComboBox();
            sltSGC = new ComboBox();
            dgvG = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            GroupCode = new DataGridViewTextBoxColumn();
            NumOfStudent = new DataGridViewTextBoxColumn();
            InstructorName = new DataGridViewTextBoxColumn();
            Discription = new DataGridViewTextBoxColumn();
            LblSearch = new Label();
            tabControlG.SuspendLayout();
            tabPageAddG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InvlideSLT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvalidNumOfStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvalidCode).BeginInit();
            tabPageSearchG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvG).BeginInit();
            SuspendLayout();
            // 
            // tabControlG
            // 
            tabControlG.Alignment = TabAlignment.Bottom;
            tabControlG.Controls.Add(tabPageAddG);
            tabControlG.Controls.Add(tabPageSearchG);
            tabControlG.Dock = DockStyle.Fill;
            tabControlG.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            tabControlG.Location = new Point(0, 0);
            tabControlG.Name = "tabControlG";
            tabControlG.SelectedIndex = 0;
            tabControlG.Size = new Size(1487, 692);
            tabControlG.TabIndex = 0;
            // 
            // tabPageAddG
            // 
            tabPageAddG.Controls.Add(LblInvlideSLT);
            tabPageAddG.Controls.Add(LblInvalidNumOfStudent);
            tabPageAddG.Controls.Add(LblInvalidCode);
            tabPageAddG.Controls.Add(InvlideSLT);
            tabPageAddG.Controls.Add(InvalidNumOfStudent);
            tabPageAddG.Controls.Add(InvalidCode);
            tabPageAddG.Controls.Add(btnAddG);
            tabPageAddG.Controls.Add(panel5);
            tabPageAddG.Controls.Add(panel3);
            tabPageAddG.Controls.Add(panel4);
            tabPageAddG.Controls.Add(panel1);
            tabPageAddG.Controls.Add(txtDiscription);
            tabPageAddG.Controls.Add(txtNOS);
            tabPageAddG.Controls.Add(sltINS);
            tabPageAddG.Controls.Add(txtGC);
            tabPageAddG.Controls.Add(lblinstructorSelect);
            tabPageAddG.Controls.Add(lblDiscription);
            tabPageAddG.Controls.Add(lblnumofS);
            tabPageAddG.Controls.Add(lblGC);
            tabPageAddG.Controls.Add(LbLAddG);
            tabPageAddG.Font = new Font("Century Gothic", 10F);
            tabPageAddG.ForeColor = Color.RoyalBlue;
            tabPageAddG.Location = new Point(4, 4);
            tabPageAddG.Name = "tabPageAddG";
            tabPageAddG.Padding = new Padding(3);
            tabPageAddG.Size = new Size(1479, 651);
            tabPageAddG.TabIndex = 0;
            tabPageAddG.Text = "Add Group";
            tabPageAddG.UseVisualStyleBackColor = true;
            // 
            // LblInvlideSLT
            // 
            LblInvlideSLT.AutoSize = true;
            LblInvlideSLT.Location = new Point(643, 357);
            LblInvlideSLT.Name = "LblInvlideSLT";
            LblInvlideSLT.Size = new Size(60, 21);
            LblInvlideSLT.TabIndex = 6;
            LblInvlideSLT.Text = "label1";
            // 
            // LblInvalidNumOfStudent
            // 
            LblInvalidNumOfStudent.AutoSize = true;
            LblInvalidNumOfStudent.Location = new Point(1229, 209);
            LblInvalidNumOfStudent.Name = "LblInvalidNumOfStudent";
            LblInvalidNumOfStudent.Size = new Size(60, 21);
            LblInvalidNumOfStudent.TabIndex = 6;
            LblInvalidNumOfStudent.Text = "label1";
            // 
            // LblInvalidCode
            // 
            LblInvalidCode.AutoSize = true;
            LblInvalidCode.Location = new Point(609, 209);
            LblInvalidCode.Name = "LblInvalidCode";
            LblInvalidCode.Size = new Size(60, 21);
            LblInvalidCode.TabIndex = 6;
            LblInvalidCode.Text = "label1";
            // 
            // InvlideSLT
            // 
            InvlideSLT.Image = (Image)resources.GetObject("InvlideSLT.Image");
            InvlideSLT.Location = new Point(595, 331);
            InvlideSLT.Name = "InvlideSLT";
            InvlideSLT.Size = new Size(42, 48);
            InvlideSLT.TabIndex = 5;
            InvlideSLT.TabStop = false;
            // 
            // InvalidNumOfStudent
            // 
            InvalidNumOfStudent.Image = (Image)resources.GetObject("InvalidNumOfStudent.Image");
            InvalidNumOfStudent.Location = new Point(1181, 182);
            InvalidNumOfStudent.Name = "InvalidNumOfStudent";
            InvalidNumOfStudent.Size = new Size(42, 48);
            InvalidNumOfStudent.TabIndex = 5;
            InvalidNumOfStudent.TabStop = false;
            // 
            // InvalidCode
            // 
            InvalidCode.Image = (Image)resources.GetObject("InvalidCode.Image");
            InvalidCode.Location = new Point(561, 182);
            InvalidCode.Name = "InvalidCode";
            InvalidCode.Size = new Size(42, 48);
            InvalidCode.TabIndex = 5;
            InvalidCode.TabStop = false;
            // 
            // btnAddG
            // 
            btnAddG.BackColor = Color.RoyalBlue;
            btnAddG.FlatStyle = FlatStyle.Flat;
            btnAddG.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnAddG.ForeColor = Color.White;
            btnAddG.Location = new Point(623, 552);
            btnAddG.Name = "btnAddG";
            btnAddG.Size = new Size(138, 50);
            btnAddG.TabIndex = 4;
            btnAddG.Text = "Add Group";
            btnAddG.UseVisualStyleBackColor = false;
            btnAddG.Click += btnAddG_Click;
            // 
            // panel5
            // 
            panel5.Location = new Point(889, 466);
            panel5.Name = "panel5";
            panel5.Size = new Size(317, 2);
            panel5.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Location = new Point(889, 228);
            panel3.Name = "panel3";
            panel3.Size = new Size(307, 2);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Location = new Point(282, 228);
            panel4.Name = "panel4";
            panel4.Size = new Size(307, 2);
            panel4.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Location = new Point(889, 236);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 1);
            panel1.TabIndex = 3;
            // 
            // txtDiscription
            // 
            txtDiscription.BackColor = SystemColors.InactiveBorder;
            txtDiscription.BorderStyle = BorderStyle.None;
            txtDiscription.Location = new Point(889, 331);
            txtDiscription.Multiline = true;
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(317, 137);
            txtDiscription.TabIndex = 1;
            txtDiscription.TextChanged += textBox2_TextChanged;
            // 
            // txtNOS
            // 
            txtNOS.BorderStyle = BorderStyle.None;
            txtNOS.Location = new Point(888, 209);
            txtNOS.Name = "txtNOS";
            txtNOS.Size = new Size(305, 21);
            txtNOS.TabIndex = 1;
            txtNOS.TextChanged += textBox2_TextChanged;
            // 
            // sltINS
            // 
            sltINS.FormattingEnabled = true;
            sltINS.Location = new Point(282, 349);
            sltINS.Name = "sltINS";
            sltINS.Size = new Size(307, 29);
            sltINS.TabIndex = 2;
            // 
            // txtGC
            // 
            txtGC.BorderStyle = BorderStyle.None;
            txtGC.Location = new Point(282, 202);
            txtGC.Name = "txtGC";
            txtGC.Size = new Size(305, 21);
            txtGC.TabIndex = 1;
            // 
            // lblinstructorSelect
            // 
            lblinstructorSelect.AutoSize = true;
            lblinstructorSelect.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lblinstructorSelect.Location = new Point(282, 300);
            lblinstructorSelect.Name = "lblinstructorSelect";
            lblinstructorSelect.Size = new Size(112, 28);
            lblinstructorSelect.TabIndex = 0;
            lblinstructorSelect.Text = "Instructor";
            lblinstructorSelect.Click += label1_Click;
            // 
            // lblDiscription
            // 
            lblDiscription.AutoSize = true;
            lblDiscription.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lblDiscription.Location = new Point(889, 300);
            lblDiscription.Name = "lblDiscription";
            lblDiscription.Size = new Size(118, 28);
            lblDiscription.TabIndex = 0;
            lblDiscription.Text = "Discription";
            lblDiscription.Click += label1_Click;
            // 
            // lblnumofS
            // 
            lblnumofS.AutoSize = true;
            lblnumofS.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lblnumofS.Location = new Point(889, 147);
            lblnumofS.Name = "lblnumofS";
            lblnumofS.Size = new Size(209, 28);
            lblnumofS.TabIndex = 0;
            lblnumofS.Text = "Number Of Student";
            lblnumofS.Click += label1_Click;
            // 
            // lblGC
            // 
            lblGC.AutoSize = true;
            lblGC.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            lblGC.Location = new Point(282, 147);
            lblGC.Name = "lblGC";
            lblGC.Size = new Size(131, 28);
            lblGC.TabIndex = 0;
            lblGC.Text = "Group Code";
            lblGC.Click += label1_Click;
            // 
            // LbLAddG
            // 
            LbLAddG.AutoSize = true;
            LbLAddG.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            LbLAddG.Location = new Point(24, 23);
            LbLAddG.Name = "LbLAddG";
            LbLAddG.Size = new Size(120, 28);
            LbLAddG.TabIndex = 0;
            LbLAddG.Text = "Add Group";
            LbLAddG.Click += label1_Click;
            // 
            // tabPageSearchG
            // 
            tabPageSearchG.Controls.Add(btnGUpdate);
            tabPageSearchG.Controls.Add(btnGDelete);
            tabPageSearchG.Controls.Add(lblSINS);
            tabPageSearchG.Controls.Add(lblSGC);
            tabPageSearchG.Controls.Add(sltSGI);
            tabPageSearchG.Controls.Add(sltSGC);
            tabPageSearchG.Controls.Add(dgvG);
            tabPageSearchG.Controls.Add(LblSearch);
            tabPageSearchG.Font = new Font("Century Gothic", 10F);
            tabPageSearchG.ForeColor = Color.RoyalBlue;
            tabPageSearchG.Location = new Point(4, 4);
            tabPageSearchG.Name = "tabPageSearchG";
            tabPageSearchG.Padding = new Padding(3);
            tabPageSearchG.Size = new Size(1479, 651);
            tabPageSearchG.TabIndex = 1;
            tabPageSearchG.Text = "Search";
            tabPageSearchG.UseVisualStyleBackColor = true;
            // 
            // btnGUpdate
            // 
            btnGUpdate.BackColor = Color.RoyalBlue;
            btnGUpdate.FlatStyle = FlatStyle.Flat;
            btnGUpdate.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnGUpdate.ForeColor = Color.White;
            btnGUpdate.Location = new Point(1261, 86);
            btnGUpdate.Name = "btnGUpdate";
            btnGUpdate.Size = new Size(109, 44);
            btnGUpdate.TabIndex = 4;
            btnGUpdate.Text = "Update";
            btnGUpdate.UseVisualStyleBackColor = false;
            btnGUpdate.Click += btnGUpdate_Click;
            // 
            // btnGDelete
            // 
            btnGDelete.BackColor = Color.OrangeRed;
            btnGDelete.FlatStyle = FlatStyle.Flat;
            btnGDelete.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnGDelete.ForeColor = Color.White;
            btnGDelete.Location = new Point(1060, 86);
            btnGDelete.Name = "btnGDelete";
            btnGDelete.Size = new Size(109, 44);
            btnGDelete.TabIndex = 4;
            btnGDelete.Text = "Delete";
            btnGDelete.UseVisualStyleBackColor = false;
            btnGDelete.Click += btnGDelete_Click;
            // 
            // lblSINS
            // 
            lblSINS.AutoSize = true;
            lblSINS.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            lblSINS.Location = new Point(504, 60);
            lblSINS.Name = "lblSINS";
            lblSINS.Size = new Size(138, 19);
            lblSINS.TabIndex = 3;
            lblSINS.Text = "Instructor Name";
            // 
            // lblSGC
            // 
            lblSGC.AutoSize = true;
            lblSGC.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            lblSGC.Location = new Point(33, 60);
            lblSGC.Name = "lblSGC";
            lblSGC.Size = new Size(111, 19);
            lblSGC.TabIndex = 3;
            lblSGC.Text = "Group Code";
            // 
            // sltSGI
            // 
            sltSGI.FormattingEnabled = true;
            sltSGI.Location = new Point(504, 94);
            sltSGI.Name = "sltSGI";
            sltSGI.Size = new Size(250, 29);
            sltSGI.TabIndex = 2;
            // 
            // sltSGC
            // 
            sltSGC.FormattingEnabled = true;
            sltSGC.Location = new Point(33, 94);
            sltSGC.Name = "sltSGC";
            sltSGC.Size = new Size(250, 29);
            sltSGC.TabIndex = 2;
            // 
            // dgvG
            // 
            dgvG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvG.BackgroundColor = Color.White;
            dgvG.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvG.Columns.AddRange(new DataGridViewColumn[] { ID, GroupCode, NumOfStudent, InstructorName, Discription });
            dgvG.Location = new Point(24, 182);
            dgvG.Name = "dgvG";
            dgvG.RowHeadersWidth = 51;
            dgvG.Size = new Size(1431, 466);
            dgvG.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // GroupCode
            // 
            GroupCode.HeaderText = "Group Code";
            GroupCode.MinimumWidth = 6;
            GroupCode.Name = "GroupCode";
            // 
            // NumOfStudent
            // 
            NumOfStudent.HeaderText = "Number Of Student";
            NumOfStudent.MinimumWidth = 6;
            NumOfStudent.Name = "NumOfStudent";
            // 
            // InstructorName
            // 
            InstructorName.HeaderText = "Instructor Name";
            InstructorName.MinimumWidth = 6;
            InstructorName.Name = "InstructorName";
            // 
            // Discription
            // 
            Discription.HeaderText = "Group Discription";
            Discription.MinimumWidth = 6;
            Discription.Name = "Discription";
            // 
            // LblSearch
            // 
            LblSearch.AutoSize = true;
            LblSearch.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            LblSearch.Location = new Point(8, 8);
            LblSearch.Name = "LblSearch";
            LblSearch.Size = new Size(81, 28);
            LblSearch.TabIndex = 0;
            LblSearch.Text = "Serach";
            // 
            // GroupControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlG);
            Name = "GroupControl";
            Size = new Size(1487, 692);
            tabControlG.ResumeLayout(false);
            tabPageAddG.ResumeLayout(false);
            tabPageAddG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InvlideSLT).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvalidNumOfStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvalidCode).EndInit();
            tabPageSearchG.ResumeLayout(false);
            tabPageSearchG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlG;
        private TabPage tabPageAddG;
        private TabPage tabPageSearchG;
        private Label LbLAddG;
        private ComboBox sltINS;
        private TextBox txtGC;
        private Label lblinstructorSelect;
        private Label lblnumofS;
        private Label lblGC;
        private Panel panel1;
        private TextBox txtNOS;
        private Panel panel3;
        private Panel panel4;
        private Label LblSearch;
        private DataGridView dgvG;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn GroupCode;
        private DataGridViewTextBoxColumn NumOfStudent;
        private DataGridViewTextBoxColumn InstructorName;
        private DataGridViewTextBoxColumn Discription;
        private Panel panel5;
        private TextBox txtDiscription;
        private Label lblDiscription;
        private Button btnAddG;
        private ComboBox sltSGI;
        private ComboBox sltSGC;
        private Button btnGUpdate;
        private Button btnGDelete;
        private Label lblSINS;
        private Label lblSGC;
        private PictureBox InvlideSLT;
        private PictureBox InvalidNumOfStudent;
        private PictureBox InvalidCode;
        private Label LblInvlideSLT;
        private Label LblInvalidNumOfStudent;
        private Label LblInvalidCode;
    }
}
