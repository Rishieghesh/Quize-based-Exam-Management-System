using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize_based_Exam_Management_System
{
    public partial class LecRegis : Form
    {
        public LecRegis()
        {
            InitializeComponent();
        }
        string SQLCon = "server=localhost;database=quizems;uid=root;pwd=''";

        

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LecRegis_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible= false;
            clearall();
        }

        private void clearall()
        {
            txt_Fname.Text = string.Empty;
            txt_Lname.Text = string.Empty;
            txt_Nic.Text = string.Empty;
            txt_Pass.Text = string.Empty;
            txt_Phone.Text = string.Empty;
            txt_LecID.Text = string.Empty;
            Combo_Department.SelectedIndex= -1;
            txt_pass1.Text = string.Empty;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btn_StuRegister_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(SQLCon);
            if (string.IsNullOrEmpty(txt_Fname.Text) || string.IsNullOrEmpty(txt_Lname.Text) || string.IsNullOrEmpty(Combo_Department.Text) || string.IsNullOrEmpty(txt_Nic.Text) || string.IsNullOrEmpty(txt_LecID.Text) || string.IsNullOrEmpty(txt_pass1.Text) || string.IsNullOrEmpty(txt_Pass.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            else  if (txt_LecID.Text == string.Empty|| txt_LecID.Text.Substring(1,3) == "HND")
            {
                MessageBox.Show("Invalid Lecture ID ", "Invalid Attempt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_Phone.Text.Substring(0, 3) == "+947" || txt_Phone.Text.Length != 12)
            {
                MessageBox.Show("Invalid Mobile Number", "Invalid Attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else  if (txt_pass1.Text != txt_Pass.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    connection.Open();

                    string iquery = "INSERT INTO tbl_lecture(Lecture_ID,`Lecture_Name`, `Lecture_MobNum`, `LecPassword`, `Department`) VALUES ('"+txt_LecID.Text+"',@Lecture_Name, @Lecture_MobNum, @LecPassword, @Department)";

                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.Parameters.AddWithValue("@Lecture_Name", txt_Fname.Text+" "+txt_Lname.Text);
                    commandDatabase.Parameters.AddWithValue("@Lecture_MobNum", txt_Phone.Text);
                    commandDatabase.Parameters.AddWithValue("@LecPassword", txt_pass1.Text);
                    commandDatabase.Parameters.AddWithValue("@Department", Combo_Department.Text);

                    commandDatabase.ExecuteNonQuery();

                    MessageBox.Show("Lecture Registered Successfully", "Registered Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearall();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }


            }
        }
    }
}
