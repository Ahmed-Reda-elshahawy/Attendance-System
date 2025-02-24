namespace Attendance_Management_System.PAL.User_Control
{
    partial class StudentUserControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentUserControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            toolTip1 = new ToolTip(components);
            tPUpdate = new TabPage();
            pbNotshow = new PictureBox();
            tbGId = new TextBox();
            tbPass = new TextBox();
            tbaddress = new TextBox();
            tbEmail = new TextBox();
            tbLN = new TextBox();
            tbFN = new TextBox();
            pbShow = new PictureBox();
            panel4 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            label8 = new Label();
            panel7 = new Panel();
            label10 = new Label();
            panel8 = new Panel();
            label11 = new Label();
            panel13 = new Panel();
            label12 = new Label();
            tbPhone = new MaskedTextBox();
            panel14 = new Panel();
            label13 = new Label();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            btnSave = new Button();
            label14 = new Label();
            panel15 = new Panel();
            label19 = new Label();
            label20 = new Label();
            TPSearch = new TabPage();
            btn_update = new Button();
            btn_delete = new Button();
            comboBox1 = new ComboBox();
            label9 = new Label();
            dvgStudent = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fname = new DataGridViewTextBoxColumn();
            lname = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            pass = new DataGridViewTextBoxColumn();
            class_id = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            pictureBoxSearch = new PictureBox();
            panel5 = new Panel();
            textBoxSearch = new TextBox();
            label6 = new Label();
            label7 = new Label();
            TPAdd = new TabPage();
            pbHide = new PictureBox();
            tbGroupid = new TextBox();
            tbpassword = new TextBox();
            textBoxAddress = new TextBox();
            tboxEmail = new TextBox();
            tbLname = new TextBox();
            tbfname = new TextBox();
            pbView = new PictureBox();
            panel12 = new Panel();
            label18 = new Label();
            panel11 = new Panel();
            label17 = new Label();
            panel10 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label16 = new Label();
            tbPhon = new MaskedTextBox();
            panel9 = new Panel();
            label15 = new Label();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            buttonAdd = new Button();
            label5 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            btnStudent = new Label();
            tabControlRegister = new TabControl();
            error_provider = new ErrorProvider(components);
            tPUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNotshow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbShow).BeginInit();
            TPSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            TPAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbView).BeginInit();
            tabControlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)error_provider).BeginInit();
            SuspendLayout();
            // 
            // tPUpdate
            // 
            tPUpdate.Controls.Add(pbNotshow);
            tPUpdate.Controls.Add(tbGId);
            tPUpdate.Controls.Add(tbPass);
            tPUpdate.Controls.Add(tbaddress);
            tPUpdate.Controls.Add(tbEmail);
            tPUpdate.Controls.Add(tbLN);
            tPUpdate.Controls.Add(tbFN);
            tPUpdate.Controls.Add(pbShow);
            tPUpdate.Controls.Add(panel4);
            tPUpdate.Controls.Add(label1);
            tPUpdate.Controls.Add(panel6);
            tPUpdate.Controls.Add(label8);
            tPUpdate.Controls.Add(panel7);
            tPUpdate.Controls.Add(label10);
            tPUpdate.Controls.Add(panel8);
            tPUpdate.Controls.Add(label11);
            tPUpdate.Controls.Add(panel13);
            tPUpdate.Controls.Add(label12);
            tPUpdate.Controls.Add(tbPhone);
            tPUpdate.Controls.Add(panel14);
            tPUpdate.Controls.Add(label13);
            tPUpdate.Controls.Add(rbFemale);
            tPUpdate.Controls.Add(rbMale);
            tPUpdate.Controls.Add(btnSave);
            tPUpdate.Controls.Add(label14);
            tPUpdate.Controls.Add(panel15);
            tPUpdate.Controls.Add(label19);
            tPUpdate.Controls.Add(label20);
            tPUpdate.Location = new Point(4, 4);
            tPUpdate.Name = "tPUpdate";
            tPUpdate.Padding = new Padding(3);
            tPUpdate.Size = new Size(1093, 516);
            tPUpdate.TabIndex = 2;
            tPUpdate.Text = "Update Student";
            tPUpdate.UseVisualStyleBackColor = true;
            // 
            // pbNotshow
            // 
            pbNotshow.Image = (Image)resources.GetObject("pbNotshow.Image");
            pbNotshow.Location = new Point(793, 160);
            pbNotshow.Name = "pbNotshow";
            pbNotshow.Size = new Size(35, 19);
            pbNotshow.SizeMode = PictureBoxSizeMode.Zoom;
            pbNotshow.TabIndex = 55;
            pbNotshow.TabStop = false;
            pbNotshow.Click += pbNotshow_Click;
            // 
            // tbGId
            // 
            tbGId.BorderStyle = BorderStyle.None;
            tbGId.Font = new Font("Century Gothic", 10F);
            tbGId.Location = new Point(108, 313);
            tbGId.Name = "tbGId";
            tbGId.Size = new Size(248, 17);
            tbGId.TabIndex = 54;
            // 
            // tbPass
            // 
            tbPass.BorderStyle = BorderStyle.None;
            tbPass.Font = new Font("Century Gothic", 10F);
            tbPass.Location = new Point(547, 162);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(240, 17);
            tbPass.TabIndex = 53;
            // 
            // tbaddress
            // 
            tbaddress.BorderStyle = BorderStyle.None;
            tbaddress.Font = new Font("Century Gothic", 10F);
            tbaddress.Location = new Point(103, 380);
            tbaddress.Name = "tbaddress";
            tbaddress.Size = new Size(718, 17);
            tbaddress.TabIndex = 44;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Century Gothic", 10F);
            tbEmail.ForeColor = Color.DarkGray;
            tbEmail.Location = new Point(112, 162);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(239, 17);
            tbEmail.TabIndex = 43;
            tbEmail.Text = "alaa@gmail.com";
            // 
            // tbLN
            // 
            tbLN.BorderStyle = BorderStyle.None;
            tbLN.Font = new Font("Century Gothic", 10F);
            tbLN.Location = new Point(551, 87);
            tbLN.Name = "tbLN";
            tbLN.Size = new Size(270, 17);
            tbLN.TabIndex = 42;
            // 
            // tbFN
            // 
            tbFN.BorderStyle = BorderStyle.None;
            tbFN.Font = new Font("Century Gothic", 10F);
            tbFN.Location = new Point(107, 87);
            tbFN.Name = "tbFN";
            tbFN.Size = new Size(270, 17);
            tbFN.TabIndex = 41;
            // 
            // pbShow
            // 
            pbShow.Image = Attendance_System.Properties.Resources.view;
            pbShow.Location = new Point(793, 155);
            pbShow.Name = "pbShow";
            pbShow.Size = new Size(35, 27);
            pbShow.SizeMode = PictureBoxSizeMode.Zoom;
            pbShow.TabIndex = 51;
            pbShow.TabStop = false;
            pbShow.Click += pbShow_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Location = new Point(107, 398);
            panel4.Name = "panel4";
            panel4.Size = new Size(720, 2);
            panel4.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(104, 348);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 40;
            label1.Text = "Address:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Location = new Point(108, 330);
            panel6.Name = "panel6";
            panel6.Size = new Size(282, 3);
            panel6.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(104, 275);
            label8.Name = "label8";
            label8.Size = new Size(63, 17);
            label8.TabIndex = 38;
            label8.Text = "GroupId";
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightGray;
            panel7.Location = new Point(108, 253);
            panel7.Name = "panel7";
            panel7.Size = new Size(282, 3);
            panel7.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.RoyalBlue;
            label10.Location = new Point(104, 198);
            label10.Name = "label10";
            label10.Size = new Size(54, 17);
            label10.TabIndex = 23;
            label10.Text = "Phone:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightGray;
            panel8.Location = new Point(551, 180);
            panel8.Name = "panel8";
            panel8.Size = new Size(275, 2);
            panel8.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.RoyalBlue;
            label11.Location = new Point(547, 124);
            label11.Name = "label11";
            label11.Size = new Size(76, 17);
            label11.TabIndex = 34;
            label11.Text = "PassWord:";
            // 
            // panel13
            // 
            panel13.BackColor = Color.LightGray;
            panel13.Location = new Point(112, 180);
            panel13.Name = "panel13";
            panel13.Size = new Size(275, 2);
            panel13.TabIndex = 33;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.RoyalBlue;
            label12.Location = new Point(104, 124);
            label12.Name = "label12";
            label12.Size = new Size(50, 17);
            label12.TabIndex = 32;
            label12.Text = "Email:";
            // 
            // tbPhone
            // 
            tbPhone.BorderStyle = BorderStyle.None;
            tbPhone.ForeColor = Color.DarkGray;
            tbPhone.Location = new Point(111, 235);
            tbPhone.Mask = "+00 000 000000";
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(248, 16);
            tbPhone.TabIndex = 31;
            tbPhone.Text = "00000000000";
            // 
            // panel14
            // 
            panel14.BackColor = Color.LightGray;
            panel14.Location = new Point(551, 109);
            panel14.Name = "panel14";
            panel14.Size = new Size(270, 2);
            panel14.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.RoyalBlue;
            label13.Location = new Point(548, 56);
            label13.Name = "label13";
            label13.Size = new Size(79, 17);
            label13.TabIndex = 29;
            label13.Text = "LastName:";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Checked = true;
            rbFemale.Font = new Font("Century Gothic", 10F);
            rbFemale.ForeColor = Color.RoyalBlue;
            rbFemale.Location = new Point(635, 252);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 23);
            rbFemale.TabIndex = 28;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Century Gothic", 10F);
            rbMale.ForeColor = Color.RoyalBlue;
            rbMale.Location = new Point(635, 222);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 23);
            rbMale.TabIndex = 27;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(379, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 37);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.RoyalBlue;
            label14.Location = new Point(553, 235);
            label14.Name = "label14";
            label14.Size = new Size(63, 17);
            label14.TabIndex = 25;
            label14.Text = "Gender:";
            // 
            // panel15
            // 
            panel15.BackColor = Color.LightGray;
            panel15.Location = new Point(108, 109);
            panel15.Name = "panel15";
            panel15.Size = new Size(270, 2);
            panel15.TabIndex = 24;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.RoyalBlue;
            label19.Location = new Point(108, 56);
            label19.Name = "label19";
            label19.Size = new Size(79, 17);
            label19.TabIndex = 36;
            label19.Text = "FirstName:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.RoyalBlue;
            label20.Location = new Point(409, 17);
            label20.Name = "label20";
            label20.Size = new Size(164, 21);
            label20.TabIndex = 37;
            label20.Text = "Update Student";
            // 
            // TPSearch
            // 
            TPSearch.BackColor = Color.White;
            TPSearch.Controls.Add(btn_update);
            TPSearch.Controls.Add(btn_delete);
            TPSearch.Controls.Add(comboBox1);
            TPSearch.Controls.Add(label9);
            TPSearch.Controls.Add(dvgStudent);
            TPSearch.Controls.Add(pictureBoxSearch);
            TPSearch.Controls.Add(panel5);
            TPSearch.Controls.Add(textBoxSearch);
            TPSearch.Controls.Add(label6);
            TPSearch.Controls.Add(label7);
            TPSearch.Location = new Point(4, 4);
            TPSearch.Name = "TPSearch";
            TPSearch.Padding = new Padding(3);
            TPSearch.Size = new Size(1093, 516);
            TPSearch.TabIndex = 1;
            TPSearch.Text = "Search";
            TPSearch.Click += TPSearch_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.RoyalBlue;
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(695, 69);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(106, 41);
            btn_update.TabIndex = 10;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.IndianRed;
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(819, 69);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(99, 41);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Century Gothic", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "-- SELECT --", "First Name", "Last Name", "GroupId" });
            comboBox1.Location = new Point(406, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 25);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(523, 45);
            label9.Name = "label9";
            label9.Size = new Size(58, 17);
            label9.TabIndex = 0;
            label9.Text = "Search:";
            // 
            // dvgStudent
            // 
            dvgStudent.AllowUserToAddRows = false;
            dvgStudent.AllowUserToDeleteRows = false;
            dvgStudent.AllowUserToResizeColumns = false;
            dvgStudent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dvgStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dvgStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgStudent.BackgroundColor = Color.White;
            dvgStudent.BorderStyle = BorderStyle.None;
            dvgStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgStudent.Columns.AddRange(new DataGridViewColumn[] { id, fname, lname, email, pass, class_id, phone, address, Gender });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dvgStudent.DefaultCellStyle = dataGridViewCellStyle2;
            dvgStudent.GridColor = SystemColors.ActiveCaptionText;
            dvgStudent.Location = new Point(6, 152);
            dvgStudent.Name = "dvgStudent";
            dvgStudent.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dvgStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dvgStudent.RowHeadersWidth = 51;
            dvgStudent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvgStudent.RowTemplate.Height = 26;
            dvgStudent.ShowCellErrors = false;
            dvgStudent.ShowEditingIcon = false;
            dvgStudent.ShowRowErrors = false;
            dvgStudent.Size = new Size(1064, 364);
            dvgStudent.TabIndex = 0;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // fname
            // 
            fname.DataPropertyName = "fname";
            fname.HeaderText = "First Name";
            fname.MinimumWidth = 6;
            fname.Name = "fname";
            fname.ReadOnly = true;
            // 
            // lname
            // 
            lname.DataPropertyName = "lname";
            lname.HeaderText = "Last Name";
            lname.MinimumWidth = 6;
            lname.Name = "lname";
            lname.ReadOnly = true;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // pass
            // 
            pass.DataPropertyName = "pass";
            pass.HeaderText = "PassWord";
            pass.MinimumWidth = 6;
            pass.Name = "pass";
            pass.ReadOnly = true;
            // 
            // class_id
            // 
            class_id.DataPropertyName = "class_id";
            class_id.HeaderText = "GroupId";
            class_id.MinimumWidth = 6;
            class_id.Name = "class_id";
            class_id.ReadOnly = true;
            // 
            // phone
            // 
            phone.DataPropertyName = "Phone";
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.ReadOnly = true;
            // 
            // address
            // 
            address.DataPropertyName = "Address";
            address.HeaderText = "Address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Image = (Image)resources.GetObject("pictureBoxSearch.Image");
            pictureBoxSearch.Location = new Point(185, 71);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(27, 23);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 7;
            pictureBoxSearch.TabStop = false;
            pictureBoxSearch.Click += pictureBoxSearch_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Location = new Point(45, 92);
            panel5.Name = "panel5";
            panel5.Size = new Size(167, 2);
            panel5.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.ForeColor = Color.RoyalBlue;
            textBoxSearch.Location = new Point(76, 67);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(103, 25);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(22, 45);
            label6.Name = "label6";
            label6.Size = new Size(96, 18);
            label6.TabIndex = 0;
            label6.Text = "SearchById:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(406, 3);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 0;
            label7.Text = "Search";
            // 
            // TPAdd
            // 
            TPAdd.Controls.Add(pbHide);
            TPAdd.Controls.Add(tbGroupid);
            TPAdd.Controls.Add(tbpassword);
            TPAdd.Controls.Add(textBoxAddress);
            TPAdd.Controls.Add(tboxEmail);
            TPAdd.Controls.Add(tbLname);
            TPAdd.Controls.Add(tbfname);
            TPAdd.Controls.Add(pbView);
            TPAdd.Controls.Add(panel12);
            TPAdd.Controls.Add(label18);
            TPAdd.Controls.Add(panel11);
            TPAdd.Controls.Add(label17);
            TPAdd.Controls.Add(panel10);
            TPAdd.Controls.Add(label4);
            TPAdd.Controls.Add(panel3);
            TPAdd.Controls.Add(label3);
            TPAdd.Controls.Add(panel2);
            TPAdd.Controls.Add(label16);
            TPAdd.Controls.Add(tbPhon);
            TPAdd.Controls.Add(panel9);
            TPAdd.Controls.Add(label15);
            TPAdd.Controls.Add(radioButtonFemale);
            TPAdd.Controls.Add(radioButtonMale);
            TPAdd.Controls.Add(buttonAdd);
            TPAdd.Controls.Add(label5);
            TPAdd.Controls.Add(panel1);
            TPAdd.Controls.Add(label2);
            TPAdd.Controls.Add(btnStudent);
            TPAdd.Font = new Font("Century Gothic", 10F);
            TPAdd.Location = new Point(4, 4);
            TPAdd.Name = "TPAdd";
            TPAdd.Padding = new Padding(3);
            TPAdd.Size = new Size(1093, 516);
            TPAdd.TabIndex = 0;
            TPAdd.Text = "Add Student ";
            TPAdd.UseVisualStyleBackColor = true;
            TPAdd.Click += tabPageAddStudent_Click;
            // 
            // pbHide
            // 
            pbHide.Image = Attendance_System.Properties.Resources.hide;
            pbHide.Location = new Point(818, 155);
            pbHide.Name = "pbHide";
            pbHide.Size = new Size(35, 0);
            pbHide.SizeMode = PictureBoxSizeMode.Zoom;
            pbHide.TabIndex = 25;
            pbHide.TabStop = false;
            // 
            // tbGroupid
            // 
            tbGroupid.BorderStyle = BorderStyle.None;
            tbGroupid.Font = new Font("Century Gothic", 10F);
            tbGroupid.Location = new Point(108, 311);
            tbGroupid.Name = "tbGroupid";
            tbGroupid.Size = new Size(243, 17);
            tbGroupid.TabIndex = 24;
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Font = new Font("Century Gothic", 10F);
            tbpassword.Location = new Point(566, 155);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(214, 17);
            tbpassword.TabIndex = 23;
            // 
            // textBoxAddress
            // 
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxAddress.Font = new Font("Century Gothic", 10F);
            textBoxAddress.Location = new Point(103, 378);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(718, 17);
            textBoxAddress.TabIndex = 0;
            // 
            // tboxEmail
            // 
            tboxEmail.BorderStyle = BorderStyle.None;
            tboxEmail.Font = new Font("Century Gothic", 10F);
            tboxEmail.ForeColor = Color.DarkGray;
            tboxEmail.Location = new Point(112, 160);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(239, 17);
            tboxEmail.TabIndex = 0;
            tboxEmail.Text = "alaa@gmail.com";
            // 
            // tbLname
            // 
            tbLname.BorderStyle = BorderStyle.None;
            tbLname.Font = new Font("Century Gothic", 10F);
            tbLname.Location = new Point(551, 85);
            tbLname.Name = "tbLname";
            tbLname.Size = new Size(270, 17);
            tbLname.TabIndex = 0;
            // 
            // tbfname
            // 
            tbfname.BorderStyle = BorderStyle.None;
            tbfname.Font = new Font("Century Gothic", 10F);
            tbfname.Location = new Point(107, 85);
            tbfname.Name = "tbfname";
            tbfname.Size = new Size(270, 17);
            tbfname.TabIndex = 0;
            // 
            // pbView
            // 
            pbView.Image = Attendance_System.Properties.Resources.view;
            pbView.Location = new Point(786, 149);
            pbView.Name = "pbView";
            pbView.Size = new Size(35, 23);
            pbView.SizeMode = PictureBoxSizeMode.Zoom;
            pbView.TabIndex = 21;
            pbView.TabStop = false;
            // 
            // panel12
            // 
            panel12.BackColor = Color.LightGray;
            panel12.Location = new Point(107, 396);
            panel12.Name = "panel12";
            panel12.Size = new Size(720, 2);
            panel12.TabIndex = 0;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.RoyalBlue;
            label18.Location = new Point(104, 346);
            label18.Name = "label18";
            label18.Size = new Size(65, 17);
            label18.TabIndex = 0;
            label18.Text = "Address:";
            label18.Click += label18_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.LightGray;
            panel11.Location = new Point(108, 328);
            panel11.Name = "panel11";
            panel11.Size = new Size(282, 3);
            panel11.TabIndex = 0;
            panel11.Paint += panel11_Paint;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.RoyalBlue;
            label17.Location = new Point(104, 273);
            label17.Name = "label17";
            label17.Size = new Size(63, 17);
            label17.TabIndex = 0;
            label17.Text = "GroupId";
            label17.Click += label17_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.LightGray;
            panel10.Location = new Point(108, 251);
            panel10.Name = "panel10";
            panel10.Size = new Size(282, 3);
            panel10.TabIndex = 0;
            panel10.Paint += panel10_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(104, 196);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 0;
            label4.Text = "Phone:";
            label4.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(551, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 2);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(547, 122);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 0;
            label3.Text = "PassWord:";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(112, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 2);
            panel2.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.RoyalBlue;
            label16.Location = new Point(104, 122);
            label16.Name = "label16";
            label16.Size = new Size(50, 17);
            label16.TabIndex = 0;
            label16.Text = "Email:";
            label16.Click += label16_Click;
            // 
            // tbPhon
            // 
            tbPhon.BorderStyle = BorderStyle.None;
            tbPhon.ForeColor = Color.DarkGray;
            tbPhon.Location = new Point(111, 233);
            tbPhon.Mask = "+00 000 000000";
            tbPhon.Name = "tbPhon";
            tbPhon.Size = new Size(248, 17);
            tbPhon.TabIndex = 0;
            tbPhon.Text = "00000000000";
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightGray;
            panel9.Location = new Point(551, 107);
            panel9.Name = "panel9";
            panel9.Size = new Size(270, 2);
            panel9.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.RoyalBlue;
            label15.Location = new Point(548, 54);
            label15.Name = "label15";
            label15.Size = new Size(79, 17);
            label15.TabIndex = 0;
            label15.Text = "LastName:";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Checked = true;
            radioButtonFemale.Font = new Font("Century Gothic", 10F);
            radioButtonFemale.ForeColor = Color.RoyalBlue;
            radioButtonFemale.Location = new Point(635, 250);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(78, 23);
            radioButtonFemale.TabIndex = 0;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Century Gothic", 10F);
            radioButtonMale.ForeColor = Color.RoyalBlue;
            radioButtonMale.Location = new Point(635, 220);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(62, 23);
            radioButtonMale.TabIndex = 0;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.RoyalBlue;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(399, 423);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(114, 37);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(553, 233);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 0;
            label5.Text = "Gender:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(108, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(108, 54);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 0;
            label2.Text = "FirstName:";
            label2.Click += label2_Click;
            // 
            // btnStudent
            // 
            btnStudent.AutoSize = true;
            btnStudent.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudent.ForeColor = Color.RoyalBlue;
            btnStudent.Location = new Point(409, 24);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(133, 21);
            btnStudent.TabIndex = 0;
            btnStudent.Text = "Add Student";
            // 
            // tabControlRegister
            // 
            tabControlRegister.Alignment = TabAlignment.Bottom;
            tabControlRegister.Anchor = AnchorStyles.None;
            tabControlRegister.Controls.Add(TPAdd);
            tabControlRegister.Controls.Add(TPSearch);
            tabControlRegister.Controls.Add(tPUpdate);
            tabControlRegister.Font = new Font("Century Gothic", 9.75F);
            tabControlRegister.Location = new Point(98, 127);
            tabControlRegister.Name = "tabControlRegister";
            tabControlRegister.SelectedIndex = 0;
            tabControlRegister.Size = new Size(1101, 546);
            tabControlRegister.TabIndex = 0;
            // 
            // error_provider
            // 
            error_provider.ContainerControl = this;
            // 
            // StudentUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlRegister);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "StudentUserControl";
            Size = new Size(1242, 891);
            tPUpdate.ResumeLayout(false);
            tPUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbNotshow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbShow).EndInit();
            TPSearch.ResumeLayout(false);
            TPSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            TPAdd.ResumeLayout(false);
            TPAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbView).EndInit();
            tabControlRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)error_provider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private TabPage tPUpdate;
        private TextBox tbGId;
        private TextBox tbPass;
        private TextBox tbaddress;
        private TextBox tbEmail;
        private TextBox tbLN;
        private TextBox tbFN;
        private PictureBox pbShow;
        private Panel panel4;
        private Label label1;
        private Panel panel6;
        private Label label8;
        private Panel panel7;
        private Label label10;
        private Panel panel8;
        private Label label11;
        private Panel panel13;
        private Label label12;
        private MaskedTextBox tbPhone;
        private Panel panel14;
        private Label label13;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Button btnSave;
        private Label label14;
        private Panel panel15;
        private Label label19;
        private Label label20;
        private TabPage TPSearch;
        private Button btn_update;
        private Button btn_delete;
        private ComboBox comboBox1;
        private Label label9;
        private DataGridView dvgStudent;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fname;
        private DataGridViewTextBoxColumn lname;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn pass;
        private DataGridViewTextBoxColumn class_id;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn Gender;
        private PictureBox pictureBoxSearch;
        private Panel panel5;
        private TextBox textBoxSearch;
        private Label label6;
        private Label label7;
        private TabPage TPAdd;
        private TextBox tbGroupid;
        private TextBox tbpassword;
        private TextBox textBoxAddress;
        private TextBox tboxEmail;
        private TextBox tbLname;
        private TextBox tbfname;
        private PictureBox pbView;
        private Panel panel12;
        private Label label18;
        private Panel panel11;
        private Label label17;
        private Panel panel10;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label label16;
        private MaskedTextBox tbPhon;
        private Panel panel9;
        private Label label15;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private Button buttonAdd;
        private Label label5;
        private Panel panel1;
        private Label label2;
        private Label btnStudent;
        private TabControl tabControlRegister;
        private PictureBox pbHide;
        private PictureBox pbNotshow;
        private ErrorProvider error_provider;
    }
}
