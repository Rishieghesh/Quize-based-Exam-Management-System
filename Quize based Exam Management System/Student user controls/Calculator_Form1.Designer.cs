namespace Quize_based_Exam_Management_System.Student_user_controls
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_nums = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.nul1 = new Guna.UI2.WinForms.Guna2Button();
            this.nul0 = new Guna.UI2.WinForms.Guna2Button();
            this.nul4 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_multi = new Guna.UI2.WinForms.Guna2Button();
            this.nul5 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_divide = new Guna.UI2.WinForms.Guna2Button();
            this.nul9 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_plus = new Guna.UI2.WinForms.Guna2Button();
            this.nul3 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_minus = new Guna.UI2.WinForms.Guna2Button();
            this.nul6 = new Guna.UI2.WinForms.Guna2Button();
            this.nul8 = new Guna.UI2.WinForms.Guna2Button();
            this.nul2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_equal = new Guna.UI2.WinForms.Guna2Button();
            this.nul7 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dot = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_nums);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 69);
            this.panel1.TabIndex = 0;
            // 
            // txt_nums
            // 
            this.txt_nums.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nums.DefaultText = "0";
            this.txt_nums.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nums.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nums.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nums.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nums.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nums.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_nums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_nums.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nums.Location = new System.Drawing.Point(0, 0);
            this.txt_nums.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nums.Name = "txt_nums";
            this.txt_nums.PasswordChar = '\0';
            this.txt_nums.PlaceholderText = "";
            this.txt_nums.SelectedText = "";
            this.txt_nums.Size = new System.Drawing.Size(221, 77);
            this.txt_nums.TabIndex = 0;
            this.txt_nums.TextChanged += new System.EventHandler(this.txt_nums_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Controls.Add(this.nul1);
            this.panel2.Controls.Add(this.nul0);
            this.panel2.Controls.Add(this.nul4);
            this.panel2.Controls.Add(this.btn_multi);
            this.panel2.Controls.Add(this.nul5);
            this.panel2.Controls.Add(this.btn_divide);
            this.panel2.Controls.Add(this.nul9);
            this.panel2.Controls.Add(this.btn_plus);
            this.panel2.Controls.Add(this.nul3);
            this.panel2.Controls.Add(this.btn_minus);
            this.panel2.Controls.Add(this.nul6);
            this.panel2.Controls.Add(this.nul8);
            this.panel2.Controls.Add(this.nul2);
            this.panel2.Controls.Add(this.btn_equal);
            this.panel2.Controls.Add(this.nul7);
            this.panel2.Controls.Add(this.btn_dot);
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 246);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BorderRadius = 10;
            this.btn_Clear.BorderThickness = 1;
            this.btn_Clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Clear.FillColor = System.Drawing.Color.Orange;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(8, 3);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(41, 38);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Text = "C";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // nul1
            // 
            this.nul1.BorderRadius = 10;
            this.nul1.BorderThickness = 1;
            this.nul1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nul1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nul1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nul1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nul1.FillColor = System.Drawing.Color.Gainsboro;
            this.nul1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nul1.ForeColor = System.Drawing.Color.Black;
            this.nul1.Location = new System.Drawing.Point(8, 47);
            this.nul1.Name = "nul1";
            this.nul1.Size = new System.Drawing.Size(41, 38);
            this.nul1.TabIndex = 4;
            this.nul1.Text = "1";
            this.nul1.Click += new System.EventHandler(this.nul1_Click);
            // 
            // nul0
            // 
            this.nul0.BorderRadius = 10;
            this.nul0.BorderThickness = 1;
            this.nul0.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nul0.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nul0.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nul0.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nul0.FillColor = System.Drawing.Color.Gainsboro;
            this.nul0.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nul0.ForeColor = System.Drawing.Color.Black;
            this.nul0.Location = new System.Drawing.Point(64, 179);
            this.nul0.Name = "nul0";
            this.nul0.Size = new System.Drawing.Size(41, 38);
            this.nul0.TabIndex = 16;
            this.nul0.Text = "0";
            this.nul0.Click += new System.EventHandler(this.nul0_Click);
            // 
            // nul4
            // 
            this.nul4.BorderRadius = 10;
            this.nul4.BorderThickness = 1;
            this.nul4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nul4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nul4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nul4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nul4.FillColor = System.Drawing.Color.Gainsboro;
            this.nul4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nul4.ForeColor = System.Drawing.Color.Black;
            this.nul4.Location = new System.Drawing.Point(8, 91);
            this.nul4.Name = "nul4";
            this.nul4.Size = new System.Drawing.Size(41, 38);
            this.nul4.TabIndex = 7;
            this.nul4.Text = "4";
            this.nul4.Click += new System.EventHandler(this.nul4_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.BorderRadius = 10;
            this.btn_multi.BorderThickness = 1;
            this.btn_multi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_multi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_multi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_multi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_multi.FillColor = System.Drawing.Color.Orange;
            this.btn_multi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_multi.ForeColor = System.Drawing.Color.Black;
            this.btn_multi.Location = new System.Drawing.Point(176, 135);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(41, 38);
            this.btn_multi.TabIndex = 1;
            this.btn_multi.Text = "*";
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // nul5
            // 
            this.nul5.BorderRadius = 10;
            this.nul5.BorderThickness = 1;
            this.nul5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nul5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nul5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nul5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nul5.FillColor = System.Drawing.Color.Gainsboro;
            this.nul5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nul5.ForeColor = System.Drawing.Color.Black;
            this.nul5.Location = new System.Drawing.Point(64, 91);
            this.nul5.Name = "nul5";
            this.nul5.Size = new System.Drawing.Size(41, 38);
            this.nul5.TabIndex = 8;
            this.nul5.Text = "5";
            this.nul5.Click += new System.EventHandler(this.nul5_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.BorderRadius = 10;
            this.btn_divide.BorderThickness = 1;
            this.btn_divide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_divide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_divide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_divide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_divide.FillColor = System.Drawing.Color.Orange;
            this.btn_divide.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_divide.ForeColor = System.Drawing.Color.Black;
            this.btn_divide.Location = new System.Drawing.Point(176, 179);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(41, 38);
            this.btn_divide.TabIndex = 2;
            this.btn_divide.Text = "/";
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // nul9
            // 
            this.nul9.BorderRadius = 10;
            this.nul9.BorderThickness = 1;
            this.nul9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nul9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nul9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nul9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nul9.FillColor = System.Drawing.Color.Gainsboro;
            this.nul9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nul9.ForeColor = System.Drawing.Color.Black;
            this.nul9.Location = new System.Drawing.Point(120, 135);
            this.nul9.Name = "nul9";
            this.nul9.Size = new System.Drawing.Size(41, 38);
            this.nul9.TabIndex = 15;
            this.nul9.Text = "9";
            this.nul9.Click += new System.EventHandler(this.nul9_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BorderRadius = 10;
            this.btn_plus.BorderThickness = 1;
            this.btn_plus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_plus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_plus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_plus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_plus.FillColor = System.Drawing.Color.Orange;
            this.btn_plus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_plus.ForeColor = System.Drawing.Color.Black;
            this.btn_plus.Location = new System.Drawing.Point(176, 91);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(41, 38);
            this.btn_plus.TabIndex = 11;
            this.btn_plus.Text = "+";
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // nul3
            // 
            this.nul3.BorderRadius = 10;
            this.nul3.BorderThickness = 1;
            this.nul3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nul3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nul3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nul3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nul3.FillColor = System.Drawing.Color.Gainsboro;
            this.nul3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nul3.ForeColor = System.Drawing.Color.Black;
            this.nul3.Location = new System.Drawing.Point(120, 47);
            this.nul3.Name = "nul3";
            this.nul3.Size = new System.Drawing.Size(41, 38);
            this.nul3.TabIndex = 6;
            this.nul3.Text = "3";
            this.nul3.Click += new System.EventHandler(this.nul3_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BorderRadius = 10;
            this.btn_minus.BorderThickness = 1;
            this.btn_minus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_minus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_minus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_minus.FillColor = System.Drawing.Color.Orange;
            this.btn_minus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_minus.ForeColor = System.Drawing.Color.Black;
            this.btn_minus.Location = new System.Drawing.Point(176, 47);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(41, 38);
            this.btn_minus.TabIndex = 10;
            this.btn_minus.Text = "-";
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // nul6
            // 
            this.nul6.BorderRadius = 10;
            this.nul6.BorderThickness = 1;
            this.nul6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nul6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nul6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nul6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nul6.FillColor = System.Drawing.Color.Gainsboro;
            this.nul6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nul6.ForeColor = System.Drawing.Color.Black;
            this.nul6.Location = new System.Drawing.Point(120, 91);
            this.nul6.Name = "nul6";
            this.nul6.Size = new System.Drawing.Size(41, 38);
            this.nul6.TabIndex = 9;
            this.nul6.Text = "6";
            this.nul6.Click += new System.EventHandler(this.nul6_Click);
            // 
            // nul8
            // 
            this.nul8.BorderRadius = 10;
            this.nul8.BorderThickness = 1;
            this.nul8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nul8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nul8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nul8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nul8.FillColor = System.Drawing.Color.Gainsboro;
            this.nul8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nul8.ForeColor = System.Drawing.Color.Black;
            this.nul8.Location = new System.Drawing.Point(64, 135);
            this.nul8.Name = "nul8";
            this.nul8.Size = new System.Drawing.Size(41, 38);
            this.nul8.TabIndex = 14;
            this.nul8.Text = "8";
            this.nul8.Click += new System.EventHandler(this.nul8_Click);
            // 
            // nul2
            // 
            this.nul2.BorderRadius = 10;
            this.nul2.BorderThickness = 1;
            this.nul2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nul2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nul2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nul2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nul2.FillColor = System.Drawing.Color.Gainsboro;
            this.nul2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nul2.ForeColor = System.Drawing.Color.Black;
            this.nul2.Location = new System.Drawing.Point(64, 47);
            this.nul2.Name = "nul2";
            this.nul2.Size = new System.Drawing.Size(41, 38);
            this.nul2.TabIndex = 5;
            this.nul2.Text = "2";
            this.nul2.Click += new System.EventHandler(this.nul2_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.BorderRadius = 10;
            this.btn_equal.BorderThickness = 1;
            this.btn_equal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_equal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_equal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_equal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_equal.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_equal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_equal.ForeColor = System.Drawing.Color.Black;
            this.btn_equal.Location = new System.Drawing.Point(120, 179);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(41, 38);
            this.btn_equal.TabIndex = 3;
            this.btn_equal.Text = "=";
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // nul7
            // 
            this.nul7.BorderRadius = 10;
            this.nul7.BorderThickness = 1;
            this.nul7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nul7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nul7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nul7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nul7.FillColor = System.Drawing.Color.Gainsboro;
            this.nul7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nul7.ForeColor = System.Drawing.Color.Black;
            this.nul7.Location = new System.Drawing.Point(8, 135);
            this.nul7.Name = "nul7";
            this.nul7.Size = new System.Drawing.Size(41, 38);
            this.nul7.TabIndex = 13;
            this.nul7.Text = "7";
            this.nul7.Click += new System.EventHandler(this.nul7_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.BorderRadius = 10;
            this.btn_dot.BorderThickness = 1;
            this.btn_dot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dot.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_dot.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_dot.ForeColor = System.Drawing.Color.Black;
            this.btn_dot.Location = new System.Drawing.Point(8, 179);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(41, 38);
            this.btn_dot.TabIndex = 12;
            this.btn_dot.Text = ".";
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(223, 304);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_Clear;
        private Guna.UI2.WinForms.Guna2Button nul9;
        private Guna.UI2.WinForms.Guna2Button nul8;
        private Guna.UI2.WinForms.Guna2Button nul7;
        private Guna.UI2.WinForms.Guna2Button btn_dot;
        private Guna.UI2.WinForms.Guna2Button btn_plus;
        private Guna.UI2.WinForms.Guna2Button btn_minus;
        private Guna.UI2.WinForms.Guna2Button nul6;
        private Guna.UI2.WinForms.Guna2Button nul5;
        private Guna.UI2.WinForms.Guna2Button nul4;
        private Guna.UI2.WinForms.Guna2Button nul3;
        private Guna.UI2.WinForms.Guna2Button nul2;
        private Guna.UI2.WinForms.Guna2Button nul1;
        private Guna.UI2.WinForms.Guna2Button btn_equal;
        private Guna.UI2.WinForms.Guna2Button btn_divide;
        private Guna.UI2.WinForms.Guna2Button btn_multi;
        private Guna.UI2.WinForms.Guna2TextBox txt_nums;
        private Guna.UI2.WinForms.Guna2Button nul0;
    }
}