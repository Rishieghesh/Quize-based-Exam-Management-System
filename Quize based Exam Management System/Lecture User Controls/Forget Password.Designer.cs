namespace Quize_based_Exam_Management_System.Lecture
{
    partial class Forget_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forget_Password));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Pro_Barcode = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btn_Conform = new Guna.UI2.WinForms.Guna2Button();
            this.label31 = new System.Windows.Forms.Label();
            this.txt_Lec_Res_ConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_FPLectID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Con = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_ResetPass = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_BarCodeRead = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pro_Barcode)).BeginInit();
            this.pnl_ResetPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.guna2Panel1.Controls.Add(this.label22);
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.btn_Exit);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(572, 26);
            this.guna2Panel1.TabIndex = 119;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Exit.FillColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(533, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(23, 26);
            this.btn_Exit.TabIndex = 38;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(226, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(246, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(135, 16);
            this.label22.TabIndex = 120;
            this.label22.Text = "QEMS -ATI Batticaloa";
            // 
            // Pro_Barcode
            // 
            this.Pro_Barcode.BackColor = System.Drawing.Color.Transparent;
            this.Pro_Barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pro_Barcode.FillColor = System.Drawing.Color.DarkRed;
            this.Pro_Barcode.Image = ((System.Drawing.Image)(resources.GetObject("Pro_Barcode.Image")));
            this.Pro_Barcode.ImageRotate = 0F;
            this.Pro_Barcode.Location = new System.Drawing.Point(26, 74);
            this.Pro_Barcode.Name = "Pro_Barcode";
            this.Pro_Barcode.Size = new System.Drawing.Size(147, 142);
            this.Pro_Barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pro_Barcode.TabIndex = 120;
            this.Pro_Barcode.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label30.Location = new System.Drawing.Point(198, 90);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(18, 25);
            this.label30.TabIndex = 131;
            this.label30.Text = ":";
            // 
            // btn_Conform
            // 
            this.btn_Conform.BorderRadius = 16;
            this.btn_Conform.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Conform.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Conform.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Conform.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Conform.FillColor = System.Drawing.Color.Maroon;
            this.btn_Conform.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_Conform.ForeColor = System.Drawing.Color.White;
            this.btn_Conform.Image = ((System.Drawing.Image)(resources.GetObject("btn_Conform.Image")));
            this.btn_Conform.Location = new System.Drawing.Point(308, 132);
            this.btn_Conform.Name = "btn_Conform";
            this.btn_Conform.Size = new System.Drawing.Size(147, 32);
            this.btn_Conform.TabIndex = 128;
            this.btn_Conform.Text = "Conform";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label31.Location = new System.Drawing.Point(198, 50);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(18, 25);
            this.label31.TabIndex = 130;
            this.label31.Text = ":";
            // 
            // txt_Lec_Res_ConfirmPass
            // 
            this.txt_Lec_Res_ConfirmPass.BorderColor = System.Drawing.Color.Black;
            this.txt_Lec_Res_ConfirmPass.BorderRadius = 15;
            this.txt_Lec_Res_ConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Lec_Res_ConfirmPass.DefaultText = "";
            this.txt_Lec_Res_ConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Lec_Res_ConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Lec_Res_ConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Lec_Res_ConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Lec_Res_ConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Lec_Res_ConfirmPass.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Lec_Res_ConfirmPass.ForeColor = System.Drawing.Color.Black;
            this.txt_Lec_Res_ConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Lec_Res_ConfirmPass.Location = new System.Drawing.Point(223, 83);
            this.txt_Lec_Res_ConfirmPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Lec_Res_ConfirmPass.Name = "txt_Lec_Res_ConfirmPass";
            this.txt_Lec_Res_ConfirmPass.PasswordChar = '\0';
            this.txt_Lec_Res_ConfirmPass.PlaceholderText = "";
            this.txt_Lec_Res_ConfirmPass.SelectedText = "";
            this.txt_Lec_Res_ConfirmPass.Size = new System.Drawing.Size(232, 32);
            this.txt_Lec_Res_ConfirmPass.TabIndex = 127;
            // 
            // txt_FPLectID
            // 
            this.txt_FPLectID.BorderColor = System.Drawing.Color.Black;
            this.txt_FPLectID.BorderRadius = 15;
            this.txt_FPLectID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FPLectID.DefaultText = "";
            this.txt_FPLectID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_FPLectID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_FPLectID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_FPLectID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_FPLectID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_FPLectID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_FPLectID.ForeColor = System.Drawing.Color.Black;
            this.txt_FPLectID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_FPLectID.Location = new System.Drawing.Point(324, 91);
            this.txt_FPLectID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_FPLectID.Name = "txt_FPLectID";
            this.txt_FPLectID.PasswordChar = '\0';
            this.txt_FPLectID.PlaceholderText = "";
            this.txt_FPLectID.SelectedText = "";
            this.txt_FPLectID.Size = new System.Drawing.Size(232, 32);
            this.txt_FPLectID.TabIndex = 126;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(20, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 22);
            this.label17.TabIndex = 124;
            this.label17.Text = "Confirm Password";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(20, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 22);
            this.label16.TabIndex = 123;
            this.label16.Text = "New Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(147, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(211, 31);
            this.label14.TabIndex = 121;
            this.label14.Text = "Forget Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(299, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 134;
            this.label1.Text = ":";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.BorderRadius = 15;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(223, 43);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(232, 32);
            this.guna2TextBox1.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(182, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 132;
            this.label2.Text = "Lecture ID";
            // 
            // btn_Con
            // 
            this.btn_Con.BorderRadius = 16;
            this.btn_Con.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Con.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Con.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Con.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Con.FillColor = System.Drawing.Color.Maroon;
            this.btn_Con.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_Con.ForeColor = System.Drawing.Color.White;
            this.btn_Con.Image = ((System.Drawing.Image)(resources.GetObject("btn_Con.Image")));
            this.btn_Con.Location = new System.Drawing.Point(409, 184);
            this.btn_Con.Name = "btn_Con";
            this.btn_Con.Size = new System.Drawing.Size(147, 32);
            this.btn_Con.TabIndex = 137;
            this.btn_Con.Text = "Conform";
            this.btn_Con.Click += new System.EventHandler(this.btn_Con_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(137, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 31);
            this.label4.TabIndex = 138;
            this.label4.Text = "Reset Password";
            // 
            // pnl_ResetPass
            // 
            this.pnl_ResetPass.Controls.Add(this.guna2TextBox1);
            this.pnl_ResetPass.Controls.Add(this.label4);
            this.pnl_ResetPass.Controls.Add(this.label16);
            this.pnl_ResetPass.Controls.Add(this.label31);
            this.pnl_ResetPass.Controls.Add(this.label17);
            this.pnl_ResetPass.Controls.Add(this.label30);
            this.pnl_ResetPass.Controls.Add(this.txt_Lec_Res_ConfirmPass);
            this.pnl_ResetPass.Controls.Add(this.btn_Conform);
            this.pnl_ResetPass.Location = new System.Drawing.Point(26, 222);
            this.pnl_ResetPass.Name = "pnl_ResetPass";
            this.pnl_ResetPass.Size = new System.Drawing.Size(498, 172);
            this.pnl_ResetPass.TabIndex = 139;
            // 
            // txt_BarCodeRead
            // 
            this.txt_BarCodeRead.BorderColor = System.Drawing.Color.Black;
            this.txt_BarCodeRead.BorderRadius = 15;
            this.txt_BarCodeRead.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_BarCodeRead.DefaultText = "";
            this.txt_BarCodeRead.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_BarCodeRead.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_BarCodeRead.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_BarCodeRead.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_BarCodeRead.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_BarCodeRead.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_BarCodeRead.ForeColor = System.Drawing.Color.Black;
            this.txt_BarCodeRead.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_BarCodeRead.Location = new System.Drawing.Point(186, 144);
            this.txt_BarCodeRead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_BarCodeRead.Name = "txt_BarCodeRead";
            this.txt_BarCodeRead.PasswordChar = '●';
            this.txt_BarCodeRead.PlaceholderText = "";
            this.txt_BarCodeRead.SelectedText = "";
            this.txt_BarCodeRead.Size = new System.Drawing.Size(232, 32);
            this.txt_BarCodeRead.TabIndex = 140;
            this.txt_BarCodeRead.UseSystemPasswordChar = true;
            // 
            // Forget_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 405);
            this.Controls.Add(this.txt_BarCodeRead);
            this.Controls.Add(this.pnl_ResetPass);
            this.Controls.Add(this.btn_Con);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_FPLectID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Pro_Barcode);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forget_Password";
            this.Text = "Forget_Password";
            this.Load += new System.EventHandler(this.Forget_Password_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pro_Barcode)).EndInit();
            this.pnl_ResetPass.ResumeLayout(false);
            this.pnl_ResetPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label22;
        private Guna.UI2.WinForms.Guna2PictureBox Pro_Barcode;
        private System.Windows.Forms.Label label30;
        private Guna.UI2.WinForms.Guna2Button btn_Conform;
        private System.Windows.Forms.Label label31;
        private Guna.UI2.WinForms.Guna2TextBox txt_Lec_Res_ConfirmPass;
        private Guna.UI2.WinForms.Guna2TextBox txt_FPLectID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_Con;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel pnl_ResetPass;
        private Guna.UI2.WinForms.Guna2TextBox txt_BarCodeRead;
    }
}