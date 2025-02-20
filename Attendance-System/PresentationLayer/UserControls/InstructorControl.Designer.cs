namespace Attendance_Management_System.PAL.User_Control
{
    partial class UserControlRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlRegister));
            tabControlInstructor = new TabControl();
            tabPageAddUser = new TabPage();
            pb_view = new PictureBox();
            pb_hide = new PictureBox();
            panel12 = new Panel();
            tb_address = new TextBox();
            label18 = new Label();
            tb_email = new TextBox();
            panel11 = new Panel();
            label17 = new Label();
            panel2 = new Panel();
            label16 = new Label();
            tb_phone = new MaskedTextBox();
            panel9 = new Panel();
            tb_password = new TextBox();
            label15 = new Label();
            rd_female = new RadioButton();
            rd_male = new RadioButton();
            buttonAdd = new Button();
            label5 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            tb_lname = new TextBox();
            label3 = new Label();
            tb_fname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchUser = new TabPage();
            btn_update = new Button();
            btn_delete = new Button();
            comboBox1 = new ComboBox();
            panel4 = new Panel();
            label9 = new Label();
            dgv_instructors = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fname = new DataGridViewTextBoxColumn();
            lname = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            pictureBoxSearch = new PictureBox();
            panel5 = new Panel();
            textBoxSearch = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tabPageUpdateInstructor = new TabPage();
            pb_show = new PictureBox();
            pb_notshow = new PictureBox();
            panel6 = new Panel();
            tb_add = new TextBox();
            label4 = new Label();
            tb_mail = new TextBox();
            panel7 = new Panel();
            label8 = new Label();
            panel8 = new Panel();
            label10 = new Label();
            tb_ph = new MaskedTextBox();
            panel10 = new Panel();
            tb_P = new TextBox();
            label11 = new Label();
            female = new RadioButton();
            male = new RadioButton();
            btn_saveUpdates = new Button();
            label12 = new Label();
            panel13 = new Panel();
            panel14 = new Panel();
            tb_LN = new TextBox();
            label13 = new Label();
            tb_FN = new TextBox();
            label19 = new Label();
            label14 = new Label();
            toolTip1 = new ToolTip(components);
            error_provider = new ErrorProvider(components);
            tabControlInstructor.SuspendLayout();
            tabPageAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_view).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_hide).BeginInit();
            tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_instructors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            tabPageUpdateInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_show).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_notshow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error_provider).BeginInit();
            SuspendLayout();
            // 
            // tabControlInstructor
            // 
            tabControlInstructor.Alignment = TabAlignment.Bottom;
            tabControlInstructor.Controls.Add(tabPageAddUser);
            tabControlInstructor.Controls.Add(tabPageSearchUser);
            tabControlInstructor.Controls.Add(tabPageUpdateInstructor);
            tabControlInstructor.Dock = DockStyle.Fill;
            tabControlInstructor.Font = new Font("Tahoma", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tabControlInstructor.Location = new Point(0, 0);
            tabControlInstructor.Name = "tabControlInstructor";
            tabControlInstructor.SelectedIndex = 0;
            tabControlInstructor.Size = new Size(1482, 720);
            tabControlInstructor.TabIndex = 0;
            // 
            // tabPageAddUser
            // 
            tabPageAddUser.Controls.Add(pb_view);
            tabPageAddUser.Controls.Add(pb_hide);
            tabPageAddUser.Controls.Add(panel12);
            tabPageAddUser.Controls.Add(tb_address);
            tabPageAddUser.Controls.Add(label18);
            tabPageAddUser.Controls.Add(tb_email);
            tabPageAddUser.Controls.Add(panel11);
            tabPageAddUser.Controls.Add(label17);
            tabPageAddUser.Controls.Add(panel2);
            tabPageAddUser.Controls.Add(label16);
            tabPageAddUser.Controls.Add(tb_phone);
            tabPageAddUser.Controls.Add(panel9);
            tabPageAddUser.Controls.Add(tb_password);
            tabPageAddUser.Controls.Add(label15);
            tabPageAddUser.Controls.Add(rd_female);
            tabPageAddUser.Controls.Add(rd_male);
            tabPageAddUser.Controls.Add(buttonAdd);
            tabPageAddUser.Controls.Add(label5);
            tabPageAddUser.Controls.Add(panel3);
            tabPageAddUser.Controls.Add(panel1);
            tabPageAddUser.Controls.Add(tb_lname);
            tabPageAddUser.Controls.Add(label3);
            tabPageAddUser.Controls.Add(tb_fname);
            tabPageAddUser.Controls.Add(label2);
            tabPageAddUser.Controls.Add(label1);
            tabPageAddUser.Font = new Font("Century Gothic", 10F);
            tabPageAddUser.ForeColor = Color.RoyalBlue;
            tabPageAddUser.Location = new Point(4, 4);
            tabPageAddUser.Name = "tabPageAddUser";
            tabPageAddUser.Padding = new Padding(3);
            tabPageAddUser.Size = new Size(1474, 679);
            tabPageAddUser.TabIndex = 0;
            tabPageAddUser.Text = "Add Instructor";
            tabPageAddUser.UseVisualStyleBackColor = true;
            tabPageAddUser.Click += tabPageAddStudent_Click;
            // 
            // pb_view
            // 
            pb_view.Image = (Image)resources.GetObject("pb_view.Image");
            pb_view.Location = new Point(1096, 284);
            pb_view.Name = "pb_view";
            pb_view.Size = new Size(35, 31);
            pb_view.SizeMode = PictureBoxSizeMode.Zoom;
            pb_view.TabIndex = 2;
            pb_view.TabStop = false;
            pb_view.Click += pb_view_Click;
            // 
            // pb_hide
            // 
            pb_hide.Image = (Image)resources.GetObject("pb_hide.Image");
            pb_hide.Location = new Point(1091, 284);
            pb_hide.Name = "pb_hide";
            pb_hide.Size = new Size(40, 31);
            pb_hide.SizeMode = PictureBoxSizeMode.Zoom;
            pb_hide.TabIndex = 1;
            pb_hide.TabStop = false;
            pb_hide.Click += pb_hide_Click;
            // 
            // panel12
            // 
            panel12.BackColor = Color.LightGray;
            panel12.Location = new Point(371, 551);
            panel12.Name = "panel12";
            panel12.Size = new Size(720, 2);
            panel12.TabIndex = 0;
            // 
            // tb_address
            // 
            tb_address.BorderStyle = BorderStyle.None;
            tb_address.Font = new Font("Tahoma", 13.8F);
            tb_address.Location = new Point(372, 495);
            tb_address.Multiline = true;
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(718, 50);
            tb_address.TabIndex = 0;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label18.Location = new Point(368, 464);
            label18.Name = "label18";
            label18.Size = new Size(100, 28);
            label18.TabIndex = 0;
            label18.Text = "Address:";
            label18.Click += label18_Click;
            // 
            // tb_email
            // 
            tb_email.BorderStyle = BorderStyle.None;
            tb_email.Font = new Font("Tahoma", 13.8F);
            tb_email.ForeColor = Color.Black;
            tb_email.Location = new Point(376, 282);
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "user@gmail.com";
            tb_email.Size = new Size(282, 28);
            tb_email.TabIndex = 0;
            tb_email.Text = "\r\n";
            // 
            // panel11
            // 
            panel11.BackColor = Color.LightGray;
            panel11.Location = new Point(376, 309);
            panel11.Name = "panel11";
            panel11.Size = new Size(282, 3);
            panel11.TabIndex = 0;
            panel11.Paint += panel11_Paint;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label17.Location = new Point(372, 254);
            label17.Name = "label17";
            label17.Size = new Size(74, 28);
            label17.TabIndex = 0;
            label17.Text = "Email:";
            label17.Click += label17_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(379, 425);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 2);
            panel2.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label16.Location = new Point(371, 365);
            label16.Name = "label16";
            label16.Size = new Size(83, 28);
            label16.TabIndex = 0;
            label16.Text = "Phone:";
            label16.Click += label16_Click;
            // 
            // tb_phone
            // 
            tb_phone.BorderStyle = BorderStyle.None;
            tb_phone.Font = new Font("Tahoma", 13.8F);
            tb_phone.ForeColor = Color.Black;
            tb_phone.Location = new Point(380, 394);
            tb_phone.Mask = "+00 000 0000000";
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(274, 28);
            tb_phone.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightGray;
            panel9.Location = new Point(817, 317);
            panel9.Name = "panel9";
            panel9.Size = new Size(270, 2);
            panel9.TabIndex = 0;
            // 
            // tb_password
            // 
            tb_password.BorderStyle = BorderStyle.None;
            tb_password.Font = new Font("Tahoma", 13.8F);
            tb_password.Location = new Point(817, 285);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(270, 28);
            tb_password.TabIndex = 0;
            tb_password.UseSystemPasswordChar = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label15.Location = new Point(814, 254);
            label15.Name = "label15";
            label15.Size = new Size(115, 28);
            label15.TabIndex = 0;
            label15.Text = "Password:";
            // 
            // rd_female
            // 
            rd_female.AutoSize = true;
            rd_female.Checked = true;
            rd_female.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            rd_female.Location = new Point(916, 395);
            rd_female.Name = "rd_female";
            rd_female.Size = new Size(105, 32);
            rd_female.TabIndex = 0;
            rd_female.TabStop = true;
            rd_female.Text = "Female";
            rd_female.UseVisualStyleBackColor = true;
            // 
            // rd_male
            // 
            rd_male.AutoSize = true;
            rd_male.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            rd_male.Location = new Point(916, 365);
            rd_male.Name = "rd_male";
            rd_male.Size = new Size(80, 32);
            rd_male.TabIndex = 0;
            rd_male.Text = "Male";
            rd_male.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.RoyalBlue;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Tahoma", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(372, 577);
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
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label5.Location = new Point(817, 365);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 0;
            label5.Text = "Gender:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(814, 228);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 2);
            panel3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(376, 230);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 0;
            // 
            // tb_lname
            // 
            tb_lname.BorderStyle = BorderStyle.None;
            tb_lname.Font = new Font("Tahoma", 13.8F);
            tb_lname.Location = new Point(813, 198);
            tb_lname.Name = "tb_lname";
            tb_lname.Size = new Size(270, 28);
            tb_lname.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label3.Location = new Point(814, 167);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 0;
            label3.Text = "Last Name:";
            label3.Click += label2_Click;
            // 
            // tb_fname
            // 
            tb_fname.BorderStyle = BorderStyle.None;
            tb_fname.Font = new Font("Tahoma", 13.8F);
            tb_fname.Location = new Point(375, 198);
            tb_fname.Name = "tb_fname";
            tb_fname.Size = new Size(270, 28);
            tb_fname.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label2.Location = new Point(376, 167);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 0;
            label2.Text = "First Name:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(633, 16);
            label1.Name = "label1";
            label1.Size = new Size(222, 34);
            label1.TabIndex = 0;
            label1.Text = "Add Instructor";
            // 
            // tabPageSearchUser
            // 
            tabPageSearchUser.BackColor = Color.Transparent;
            tabPageSearchUser.Controls.Add(btn_update);
            tabPageSearchUser.Controls.Add(btn_delete);
            tabPageSearchUser.Controls.Add(comboBox1);
            tabPageSearchUser.Controls.Add(panel4);
            tabPageSearchUser.Controls.Add(label9);
            tabPageSearchUser.Controls.Add(dgv_instructors);
            tabPageSearchUser.Controls.Add(pictureBoxSearch);
            tabPageSearchUser.Controls.Add(panel5);
            tabPageSearchUser.Controls.Add(textBoxSearch);
            tabPageSearchUser.Controls.Add(label6);
            tabPageSearchUser.Controls.Add(label7);
            tabPageSearchUser.Location = new Point(4, 4);
            tabPageSearchUser.Name = "tabPageSearchUser";
            tabPageSearchUser.Padding = new Padding(3);
            tabPageSearchUser.Size = new Size(1474, 679);
            tabPageSearchUser.TabIndex = 1;
            tabPageSearchUser.Text = "Search";
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.RoyalBlue;
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(1244, 142);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(106, 41);
            btn_update.TabIndex = 9;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.IndianRed;
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(1361, 142);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(99, 41);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Tahoma", 13.8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "-- SELECT --", "Name", "PhoneNo.", "CNIC" });
            comboBox1.Location = new Point(438, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 36);
            comboBox1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Location = new Point(438, 172);
            panel4.Name = "panel4";
            panel4.Size = new Size(261, 2);
            panel4.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label9.Location = new Point(437, 107);
            label9.Name = "label9";
            label9.Size = new Size(128, 27);
            label9.TabIndex = 0;
            label9.Text = "Search By:";
            // 
            // dgv_instructors
            // 
            dgv_instructors.AllowUserToAddRows = false;
            dgv_instructors.AllowUserToResizeColumns = false;
            dgv_instructors.AllowUserToResizeRows = false;
            dgv_instructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_instructors.BackgroundColor = Color.White;
            dgv_instructors.BorderStyle = BorderStyle.None;
            dgv_instructors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_instructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_instructors.Columns.AddRange(new DataGridViewColumn[] { id, fname, lname, email, password, phone, Address, Gender });
            dgv_instructors.Location = new Point(31, 210);
            dgv_instructors.Name = "dgv_instructors";
            dgv_instructors.RowHeadersWidth = 51;
            dgv_instructors.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_instructors.RowTemplate.Height = 26;
            dgv_instructors.ShowCellErrors = false;
            dgv_instructors.ShowEditingIcon = false;
            dgv_instructors.ShowRowErrors = false;
            dgv_instructors.Size = new Size(1429, 428);
            dgv_instructors.TabIndex = 0;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            // 
            // fname
            // 
            fname.DataPropertyName = "fname";
            fname.HeaderText = "First Name";
            fname.MinimumWidth = 6;
            fname.Name = "fname";
            // 
            // lname
            // 
            lname.DataPropertyName = "lname";
            lname.HeaderText = "Last Name";
            lname.MinimumWidth = 6;
            lname.Name = "lname";
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            // 
            // password
            // 
            password.DataPropertyName = "pass";
            password.HeaderText = "Password";
            password.MinimumWidth = 6;
            password.Name = "password";
            // 
            // phone
            // 
            phone.DataPropertyName = "Phone";
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Image = (Image)resources.GetObject("pictureBoxSearch.Image");
            pictureBoxSearch.Location = new Point(288, 150);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(20, 29);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 7;
            pictureBoxSearch.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Location = new Point(38, 181);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 2);
            panel5.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Tahoma", 13.8F);
            textBoxSearch.Location = new Point(38, 150);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(270, 28);
            textBoxSearch.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label6.Location = new Point(37, 107);
            label6.Name = "label6";
            label6.Size = new Size(96, 27);
            label6.TabIndex = 0;
            label6.Text = "Search:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(721, 13);
            label7.Name = "label7";
            label7.Size = new Size(112, 34);
            label7.TabIndex = 0;
            label7.Text = "Search";
            // 
            // tabPageUpdateInstructor
            // 
            tabPageUpdateInstructor.Controls.Add(pb_show);
            tabPageUpdateInstructor.Controls.Add(pb_notshow);
            tabPageUpdateInstructor.Controls.Add(panel6);
            tabPageUpdateInstructor.Controls.Add(tb_add);
            tabPageUpdateInstructor.Controls.Add(label4);
            tabPageUpdateInstructor.Controls.Add(tb_mail);
            tabPageUpdateInstructor.Controls.Add(panel7);
            tabPageUpdateInstructor.Controls.Add(label8);
            tabPageUpdateInstructor.Controls.Add(panel8);
            tabPageUpdateInstructor.Controls.Add(label10);
            tabPageUpdateInstructor.Controls.Add(tb_ph);
            tabPageUpdateInstructor.Controls.Add(panel10);
            tabPageUpdateInstructor.Controls.Add(tb_P);
            tabPageUpdateInstructor.Controls.Add(label11);
            tabPageUpdateInstructor.Controls.Add(female);
            tabPageUpdateInstructor.Controls.Add(male);
            tabPageUpdateInstructor.Controls.Add(btn_saveUpdates);
            tabPageUpdateInstructor.Controls.Add(label12);
            tabPageUpdateInstructor.Controls.Add(panel13);
            tabPageUpdateInstructor.Controls.Add(panel14);
            tabPageUpdateInstructor.Controls.Add(tb_LN);
            tabPageUpdateInstructor.Controls.Add(label13);
            tabPageUpdateInstructor.Controls.Add(tb_FN);
            tabPageUpdateInstructor.Controls.Add(label19);
            tabPageUpdateInstructor.Controls.Add(label14);
            tabPageUpdateInstructor.Location = new Point(4, 4);
            tabPageUpdateInstructor.Name = "tabPageUpdateInstructor";
            tabPageUpdateInstructor.Padding = new Padding(3);
            tabPageUpdateInstructor.Size = new Size(1474, 679);
            tabPageUpdateInstructor.TabIndex = 2;
            tabPageUpdateInstructor.Text = "Update Instructor";
            tabPageUpdateInstructor.UseVisualStyleBackColor = true;
            // 
            // pb_show
            // 
            pb_show.Image = (Image)resources.GetObject("pb_show.Image");
            pb_show.Location = new Point(1102, 277);
            pb_show.Name = "pb_show";
            pb_show.Size = new Size(35, 31);
            pb_show.SizeMode = PictureBoxSizeMode.Zoom;
            pb_show.TabIndex = 24;
            pb_show.TabStop = false;
            pb_show.Click += pb_show_Click;
            // 
            // pb_notshow
            // 
            pb_notshow.Image = (Image)resources.GetObject("pb_notshow.Image");
            pb_notshow.Location = new Point(1097, 277);
            pb_notshow.Name = "pb_notshow";
            pb_notshow.Size = new Size(40, 31);
            pb_notshow.SizeMode = PictureBoxSizeMode.Zoom;
            pb_notshow.TabIndex = 23;
            pb_notshow.TabStop = false;
            pb_notshow.Click += pb_notshow_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Location = new Point(380, 543);
            panel6.Name = "panel6";
            panel6.Size = new Size(720, 2);
            panel6.TabIndex = 1;
            // 
            // tb_add
            // 
            tb_add.BorderStyle = BorderStyle.None;
            tb_add.Font = new Font("Tahoma", 13.8F);
            tb_add.Location = new Point(381, 487);
            tb_add.Multiline = true;
            tb_add.Name = "tb_add";
            tb_add.Size = new Size(718, 50);
            tb_add.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label4.Location = new Point(377, 456);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 19;
            label4.Text = "Address:";
            // 
            // tb_mail
            // 
            tb_mail.BorderStyle = BorderStyle.None;
            tb_mail.Font = new Font("Tahoma", 13.8F);
            tb_mail.ForeColor = Color.Black;
            tb_mail.Location = new Point(385, 274);
            tb_mail.Name = "tb_mail";
            tb_mail.PlaceholderText = "user@gmail.com";
            tb_mail.Size = new Size(282, 28);
            tb_mail.TabIndex = 18;
            tb_mail.Text = "\r\n";
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightGray;
            panel7.Location = new Point(385, 301);
            panel7.Name = "panel7";
            panel7.Size = new Size(282, 3);
            panel7.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label8.Location = new Point(381, 246);
            label8.Name = "label8";
            label8.Size = new Size(74, 28);
            label8.TabIndex = 16;
            label8.Text = "Email:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightGray;
            panel8.Location = new Point(388, 417);
            panel8.Name = "panel8";
            panel8.Size = new Size(275, 2);
            panel8.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label10.Location = new Point(380, 357);
            label10.Name = "label10";
            label10.Size = new Size(83, 28);
            label10.TabIndex = 14;
            label10.Text = "Phone:";
            // 
            // tb_ph
            // 
            tb_ph.BorderStyle = BorderStyle.None;
            tb_ph.Font = new Font("Tahoma", 13.8F);
            tb_ph.ForeColor = Color.Black;
            tb_ph.Location = new Point(389, 386);
            tb_ph.Mask = "+00 000 0000000";
            tb_ph.Name = "tb_ph";
            tb_ph.Size = new Size(274, 28);
            tb_ph.TabIndex = 13;
            // 
            // panel10
            // 
            panel10.BackColor = Color.LightGray;
            panel10.Location = new Point(826, 309);
            panel10.Name = "panel10";
            panel10.Size = new Size(270, 2);
            panel10.TabIndex = 12;
            // 
            // tb_P
            // 
            tb_P.BorderStyle = BorderStyle.None;
            tb_P.Font = new Font("Tahoma", 13.8F);
            tb_P.Location = new Point(826, 277);
            tb_P.Name = "tb_P";
            tb_P.Size = new Size(270, 28);
            tb_P.TabIndex = 11;
            tb_P.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label11.Location = new Point(823, 246);
            label11.Name = "label11";
            label11.Size = new Size(115, 28);
            label11.TabIndex = 10;
            label11.Text = "Password:";
            // 
            // female
            // 
            female.AutoSize = true;
            female.Checked = true;
            female.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            female.Location = new Point(925, 387);
            female.Name = "female";
            female.Size = new Size(105, 32);
            female.TabIndex = 9;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            male.Location = new Point(925, 357);
            male.Name = "male";
            male.Size = new Size(80, 32);
            male.TabIndex = 8;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // btn_saveUpdates
            // 
            btn_saveUpdates.BackColor = Color.RoyalBlue;
            btn_saveUpdates.FlatAppearance.BorderSize = 0;
            btn_saveUpdates.FlatStyle = FlatStyle.Flat;
            btn_saveUpdates.Font = new Font("Tahoma", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_saveUpdates.ForeColor = Color.White;
            btn_saveUpdates.Location = new Point(381, 569);
            btn_saveUpdates.Name = "btn_saveUpdates";
            btn_saveUpdates.Size = new Size(114, 37);
            btn_saveUpdates.TabIndex = 7;
            btn_saveUpdates.Text = "Save";
            btn_saveUpdates.UseVisualStyleBackColor = false;
            btn_saveUpdates.Click += btn_saveUpdates_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label12.Location = new Point(826, 357);
            label12.Name = "label12";
            label12.Size = new Size(93, 28);
            label12.TabIndex = 6;
            label12.Text = "Gender:";
            // 
            // panel13
            // 
            panel13.BackColor = Color.LightGray;
            panel13.Location = new Point(823, 220);
            panel13.Name = "panel13";
            panel13.Size = new Size(270, 2);
            panel13.TabIndex = 5;
            // 
            // panel14
            // 
            panel14.BackColor = Color.LightGray;
            panel14.Location = new Point(385, 222);
            panel14.Name = "panel14";
            panel14.Size = new Size(270, 2);
            panel14.TabIndex = 4;
            // 
            // tb_LN
            // 
            tb_LN.BorderStyle = BorderStyle.None;
            tb_LN.Font = new Font("Tahoma", 13.8F);
            tb_LN.Location = new Point(822, 190);
            tb_LN.Name = "tb_LN";
            tb_LN.Size = new Size(270, 28);
            tb_LN.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label13.Location = new Point(823, 159);
            label13.Name = "label13";
            label13.Size = new Size(126, 28);
            label13.TabIndex = 2;
            label13.Text = "Last Name:";
            // 
            // tb_FN
            // 
            tb_FN.BorderStyle = BorderStyle.None;
            tb_FN.Font = new Font("Tahoma", 13.8F);
            tb_FN.Location = new Point(384, 190);
            tb_FN.Name = "tb_FN";
            tb_FN.Size = new Size(270, 28);
            tb_FN.TabIndex = 21;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Tahoma", 13.8F, FontStyle.Italic);
            label19.Location = new Point(385, 159);
            label19.Name = "label19";
            label19.Size = new Size(128, 28);
            label19.TabIndex = 22;
            label19.Text = "First Name:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.RoyalBlue;
            label14.Location = new Point(618, 16);
            label14.Name = "label14";
            label14.Size = new Size(270, 34);
            label14.TabIndex = 0;
            label14.Text = "Update Instructor";
            label14.Click += label14_Click;
            // 
            // error_provider
            // 
            error_provider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            error_provider.ContainerControl = this;
            // 
            // UserControlRegister
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(tabControlInstructor);
            Font = new Font("Century Gothic", 12F);
            ForeColor = Color.RoyalBlue;
            Margin = new Padding(5, 4, 5, 4);
            Name = "UserControlRegister";
            Size = new Size(1482, 720);
            tabControlInstructor.ResumeLayout(false);
            tabPageAddUser.ResumeLayout(false);
            tabPageAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_view).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_hide).EndInit();
            tabPageSearchUser.ResumeLayout(false);
            tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_instructors).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            tabPageUpdateInstructor.ResumeLayout(false);
            tabPageUpdateInstructor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_show).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_notshow).EndInit();
            ((System.ComponentModel.ISupportInitialize)error_provider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlInstructor;
        private System.Windows.Forms.TabPage tabPageAddUser;
        private System.Windows.Forms.RadioButton rd_female;
        private System.Windows.Forms.RadioButton rd_male;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchUser;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPageUpdateInstructor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox tb_phone;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label18;
        private Panel panel3;
        private TextBox tb_lname;
        private Label label3;
        private ErrorProvider error_provider;
        private Button btn_update;
        private Button btn_delete;
        private DataGridView dgv_instructors;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fname;
        private DataGridViewTextBoxColumn lname;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Gender;
        private Panel panel6;
        private TextBox tb_add;
        private Label label4;
        private TextBox tb_mail;
        private Panel panel7;
        private Label label8;
        private Panel panel8;
        private Label label10;
        private MaskedTextBox tb_ph;
        private Panel panel10;
        private TextBox tb_P;
        private Label label11;
        private RadioButton female;
        private RadioButton male;
        private Button btn_saveUpdates;
        private Label label12;
        private Panel panel13;
        private Panel panel14;
        private TextBox tb_LN;
        private Label label13;
        private TextBox tb_FN;
        private Label label19;
        private PictureBox pb_hide;
        private PictureBox pb_view;
        private PictureBox pb_show;
        private PictureBox pb_notshow;
    }
}
