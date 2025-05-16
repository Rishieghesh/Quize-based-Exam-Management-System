namespace Quize_based_Exam_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exit = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_SelectUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LecturePannel = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_LecRegis = new Guna.UI2.WinForms.Guna2Button();
            this.LectWrong = new System.Windows.Forms.Label();
            this.btn_LecLogin = new Guna.UI2.WinForms.Guna2Button();
            this.ChekPass = new System.Windows.Forms.CheckBox();
            this.txt_LectureID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_LectPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentPannel = new Guna.UI2.WinForms.Guna2Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_StuPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_StuRegister = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Stu_wrong = new System.Windows.Forms.Label();
            this.btn_Stulogin = new Guna.UI2.WinForms.Guna2Button();
            this.txt_StuRegisNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LecturePannel.SuspendLayout();
            this.StudentPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exit.FillColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(859, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 31);
            this.exit.TabIndex = 0;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(145, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quiz Exam Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(337, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select User Type";
            // 
            // CB_SelectUser
            // 
            this.CB_SelectUser.BackColor = System.Drawing.Color.Transparent;
            this.CB_SelectUser.BorderColor = System.Drawing.Color.Black;
            this.CB_SelectUser.BorderRadius = 16;
            this.CB_SelectUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_SelectUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_SelectUser.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_SelectUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_SelectUser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CB_SelectUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CB_SelectUser.ItemHeight = 30;
            this.CB_SelectUser.Items.AddRange(new object[] {
            "STUDENT",
            "LECTURE"});
            this.CB_SelectUser.Location = new System.Drawing.Point(297, 153);
            this.CB_SelectUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_SelectUser.Name = "CB_SelectUser";
            this.CB_SelectUser.Size = new System.Drawing.Size(284, 36);
            this.CB_SelectUser.TabIndex = 3;
            this.CB_SelectUser.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // LecturePannel
            // 
            this.LecturePannel.BorderColor = System.Drawing.Color.Black;
            this.LecturePannel.BorderThickness = 2;
            this.LecturePannel.Controls.Add(this.btn_LecRegis);
            this.LecturePannel.Controls.Add(this.LectWrong);
            this.LecturePannel.Controls.Add(this.btn_LecLogin);
            this.LecturePannel.Controls.Add(this.ChekPass);
            this.LecturePannel.Controls.Add(this.txt_LectureID);
            this.LecturePannel.Controls.Add(this.txt_LectPass);
            this.LecturePannel.Controls.Add(this.label5);
            this.LecturePannel.Controls.Add(this.label4);
            this.LecturePannel.Controls.Add(this.label3);
            this.LecturePannel.FillColor = System.Drawing.Color.White;
            this.LecturePannel.Location = new System.Drawing.Point(55, 219);
            this.LecturePannel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LecturePannel.Name = "LecturePannel";
            this.LecturePannel.Size = new System.Drawing.Size(384, 388);
            this.LecturePannel.TabIndex = 4;
            this.LecturePannel.Paint += new System.Windows.Forms.PaintEventHandler(this.LecturePannel_Paint);
            // 
            // btn_LecRegis
            // 
            this.btn_LecRegis.BackColor = System.Drawing.Color.White;
            this.btn_LecRegis.BorderRadius = 14;
            this.btn_LecRegis.BorderThickness = 1;
            this.btn_LecRegis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LecRegis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LecRegis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LecRegis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LecRegis.FillColor = System.Drawing.Color.Maroon;
            this.btn_LecRegis.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_LecRegis.ForeColor = System.Drawing.Color.White;
            this.btn_LecRegis.Location = new System.Drawing.Point(188, 288);
            this.btn_LecRegis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LecRegis.Name = "btn_LecRegis";
            this.btn_LecRegis.Size = new System.Drawing.Size(152, 34);
            this.btn_LecRegis.TabIndex = 15;
            this.btn_LecRegis.Text = "Register";
            this.btn_LecRegis.Click += new System.EventHandler(this.btn_LecRegis_Click);
            // 
            // LectWrong
            // 
            this.LectWrong.AutoSize = true;
            this.LectWrong.BackColor = System.Drawing.Color.White;
            this.LectWrong.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LectWrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LectWrong.Location = new System.Drawing.Point(67, 354);
            this.LectWrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LectWrong.Name = "LectWrong";
            this.LectWrong.Size = new System.Drawing.Size(228, 18);
            this.LectWrong.TabIndex = 13;
            this.LectWrong.Text = "Wrong Password or Lecture ID";
            // 
            // btn_LecLogin
            // 
            this.btn_LecLogin.BackColor = System.Drawing.Color.White;
            this.btn_LecLogin.BorderRadius = 14;
            this.btn_LecLogin.BorderThickness = 1;
            this.btn_LecLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LecLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LecLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LecLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LecLogin.FillColor = System.Drawing.Color.Maroon;
            this.btn_LecLogin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_LecLogin.ForeColor = System.Drawing.Color.White;
            this.btn_LecLogin.Location = new System.Drawing.Point(31, 288);
            this.btn_LecLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LecLogin.Name = "btn_LecLogin";
            this.btn_LecLogin.Size = new System.Drawing.Size(152, 34);
            this.btn_LecLogin.TabIndex = 12;
            this.btn_LecLogin.Text = "Log in";
            this.btn_LecLogin.Click += new System.EventHandler(this.btn_LecLogin_Click);
            // 
            // ChekPass
            // 
            this.ChekPass.AutoSize = true;
            this.ChekPass.BackColor = System.Drawing.Color.White;
            this.ChekPass.Location = new System.Drawing.Point(128, 260);
            this.ChekPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChekPass.Name = "ChekPass";
            this.ChekPass.Size = new System.Drawing.Size(125, 20);
            this.ChekPass.TabIndex = 10;
            this.ChekPass.Text = "Show Password";
            this.ChekPass.UseVisualStyleBackColor = false;
            this.ChekPass.CheckedChanged += new System.EventHandler(this.ChekPass_CheckedChanged);
            // 
            // txt_LectureID
            // 
            this.txt_LectureID.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_LectureID.BorderRadius = 16;
            this.txt_LectureID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LectureID.DefaultText = "HNDIT001";
            this.txt_LectureID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_LectureID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_LectureID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LectureID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LectureID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LectureID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_LectureID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LectureID.Location = new System.Drawing.Point(31, 103);
            this.txt_LectureID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_LectureID.Name = "txt_LectureID";
            this.txt_LectureID.PasswordChar = '\0';
            this.txt_LectureID.PlaceholderText = "";
            this.txt_LectureID.SelectedText = "";
            this.txt_LectureID.Size = new System.Drawing.Size(309, 44);
            this.txt_LectureID.TabIndex = 9;
            this.txt_LectureID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_LectPass
            // 
            this.txt_LectPass.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_LectPass.BorderRadius = 16;
            this.txt_LectPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LectPass.DefaultText = "HNDIT";
            this.txt_LectPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_LectPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_LectPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LectPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LectPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LectPass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_LectPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LectPass.Location = new System.Drawing.Point(31, 207);
            this.txt_LectPass.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_LectPass.Name = "txt_LectPass";
            this.txt_LectPass.PasswordChar = '*';
            this.txt_LectPass.PlaceholderText = "";
            this.txt_LectPass.SelectedText = "";
            this.txt_LectPass.Size = new System.Drawing.Size(309, 44);
            this.txt_LectPass.TabIndex = 8;
            this.txt_LectPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_LectPass.TextChanged += new System.EventHandler(this.txt_LectPass_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(119, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(119, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lecture ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(89, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "LECTURE LOG IN";
            // 
            // StudentPannel
            // 
            this.StudentPannel.BorderColor = System.Drawing.Color.Black;
            this.StudentPannel.BorderThickness = 2;
            this.StudentPannel.Controls.Add(this.checkBox1);
            this.StudentPannel.Controls.Add(this.txt_StuPass);
            this.StudentPannel.Controls.Add(this.btn_StuRegister);
            this.StudentPannel.Controls.Add(this.label6);
            this.StudentPannel.Controls.Add(this.Stu_wrong);
            this.StudentPannel.Controls.Add(this.btn_Stulogin);
            this.StudentPannel.Controls.Add(this.txt_StuRegisNum);
            this.StudentPannel.Controls.Add(this.label9);
            this.StudentPannel.Controls.Add(this.label10);
            this.StudentPannel.FillColor = System.Drawing.Color.White;
            this.StudentPannel.Location = new System.Drawing.Point(480, 219);
            this.StudentPannel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentPannel.Name = "StudentPannel";
            this.StudentPannel.Size = new System.Drawing.Size(395, 388);
            this.StudentPannel.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(144, 260);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 20);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_StuPass
            // 
            this.txt_StuPass.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_StuPass.BorderRadius = 16;
            this.txt_StuPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_StuPass.DefaultText = "admin123";
            this.txt_StuPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_StuPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_StuPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_StuPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_StuPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_StuPass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_StuPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_StuPass.Location = new System.Drawing.Point(41, 207);
            this.txt_StuPass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_StuPass.Name = "txt_StuPass";
            this.txt_StuPass.PasswordChar = '*';
            this.txt_StuPass.PlaceholderText = "";
            this.txt_StuPass.SelectedText = "";
            this.txt_StuPass.Size = new System.Drawing.Size(309, 44);
            this.txt_StuPass.TabIndex = 15;
            this.txt_StuPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_StuRegister
            // 
            this.btn_StuRegister.BackColor = System.Drawing.Color.White;
            this.btn_StuRegister.BorderRadius = 14;
            this.btn_StuRegister.BorderThickness = 1;
            this.btn_StuRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_StuRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_StuRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_StuRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_StuRegister.FillColor = System.Drawing.Color.DarkGreen;
            this.btn_StuRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StuRegister.ForeColor = System.Drawing.Color.White;
            this.btn_StuRegister.Location = new System.Drawing.Point(201, 293);
            this.btn_StuRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_StuRegister.Name = "btn_StuRegister";
            this.btn_StuRegister.Size = new System.Drawing.Size(152, 34);
            this.btn_StuRegister.TabIndex = 14;
            this.btn_StuRegister.Text = "Resgister";
            this.btn_StuRegister.Click += new System.EventHandler(this.btn_StuRegister_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(140, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // Stu_wrong
            // 
            this.Stu_wrong.AutoSize = true;
            this.Stu_wrong.BackColor = System.Drawing.Color.White;
            this.Stu_wrong.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stu_wrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Stu_wrong.Location = new System.Drawing.Point(17, 354);
            this.Stu_wrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Stu_wrong.Name = "Stu_wrong";
            this.Stu_wrong.Size = new System.Drawing.Size(339, 18);
            this.Stu_wrong.TabIndex = 13;
            this.Stu_wrong.Text = "Wrong OR Unregistered Resgistation Number";
            // 
            // btn_Stulogin
            // 
            this.btn_Stulogin.BackColor = System.Drawing.Color.White;
            this.btn_Stulogin.BorderRadius = 14;
            this.btn_Stulogin.BorderThickness = 1;
            this.btn_Stulogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Stulogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Stulogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Stulogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Stulogin.FillColor = System.Drawing.Color.DarkGreen;
            this.btn_Stulogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stulogin.ForeColor = System.Drawing.Color.White;
            this.btn_Stulogin.Location = new System.Drawing.Point(41, 293);
            this.btn_Stulogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Stulogin.Name = "btn_Stulogin";
            this.btn_Stulogin.Size = new System.Drawing.Size(152, 34);
            this.btn_Stulogin.TabIndex = 12;
            this.btn_Stulogin.Text = "Log in";
            this.btn_Stulogin.Click += new System.EventHandler(this.btn_Stulogin_Click);
            // 
            // txt_StuRegisNum
            // 
            this.txt_StuRegisNum.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_StuRegisNum.BorderRadius = 16;
            this.txt_StuRegisNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_StuRegisNum.DefaultText = "ATI/IT/2021/F/005";
            this.txt_StuRegisNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_StuRegisNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_StuRegisNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_StuRegisNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_StuRegisNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_StuRegisNum.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_StuRegisNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_StuRegisNum.Location = new System.Drawing.Point(41, 103);
            this.txt_StuRegisNum.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_StuRegisNum.Name = "txt_StuRegisNum";
            this.txt_StuRegisNum.PasswordChar = '\0';
            this.txt_StuRegisNum.PlaceholderText = "";
            this.txt_StuRegisNum.SelectedText = "";
            this.txt_StuRegisNum.Size = new System.Drawing.Size(309, 44);
            this.txt_StuRegisNum.TabIndex = 9;
            this.txt_StuRegisNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(80, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Resgistation Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(68, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "STUDENT LOG IN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(267, 732);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(448, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Advanced Technological Intitute - Batticaloa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(220, 708);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(560, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "Srilankan Institute of Advanced Technological Education";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(891, 773);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StudentPannel);
            this.Controls.Add(this.LecturePannel);
            this.Controls.Add(this.CB_SelectUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LecturePannel.ResumeLayout(false);
            this.LecturePannel.PerformLayout();
            this.StudentPannel.ResumeLayout(false);
            this.StudentPannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox CB_SelectUser;
        private Guna.UI2.WinForms.Guna2Panel LecturePannel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChekPass;
        private Guna.UI2.WinForms.Guna2TextBox txt_LectureID;
        private Guna.UI2.WinForms.Guna2TextBox txt_LectPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel StudentPannel;
        private Guna.UI2.WinForms.Guna2Button btn_StuRegister;
        private System.Windows.Forms.Label Stu_wrong;
        private Guna.UI2.WinForms.Guna2Button btn_Stulogin;
        private Guna.UI2.WinForms.Guna2TextBox txt_StuRegisNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LectWrong;
        private Guna.UI2.WinForms.Guna2Button btn_LecLogin;
        private Guna.UI2.WinForms.Guna2TextBox txt_StuPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button btn_LecRegis;
    }
}

