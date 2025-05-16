using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize_based_Exam_Management_System.Lecture
{
    public partial class Lec_Profile : UserControl
    {
        public Lec_Profile()
        {
            InitializeComponent();
        }
        string SQLCon = "server=localhost;database=quizems;uid=root;pwd=''";

        private void btn_ResetPass_Click(object sender, EventArgs e)
        {
            if (Pnl_resetPass.Visible==false)
            {
                Pnl_resetPass.Visible = true;
                txt_Lec_Res_ConfirmPass.Text = string.Empty;
                txt_Lec_Res_CurPass.Text = string.Empty;
                txt_Lec_Res_NewPass.Text = string.Empty;
            }
            else
            {
                Pnl_resetPass.Visible = false;
            }
        }

        private string OLDPass;

        private void btn_Conform_Click(object sender, EventArgs e)
        {
            
            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;

                Con.Open();
                string pasChaQuery = "SELECT LecPassword FROM tbl_lecture WHERE Lecture_ID = @LectureID";
                using ( cmd = new MySqlCommand(pasChaQuery, Con))
                {
                    // Use parameterized queries to avoid SQL injection
                    cmd.Parameters.AddWithValue("@LectureID", txt_LecID.Text);

                    // ExecuteScalar returns object, so you need to handle possible null values
                    object result = cmd.ExecuteScalar();

                    // Check for null before converting to string
                    if (result != null)
                    {
                        OLDPass = result.ToString();
                    }


                    if (txt_Lec_Res_CurPass.Text == txt_Lec_Res_NewPass.Text)
                {

                    MessageBox.Show("Your Passwords are same , You can't change on it", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

                else if (txt_Lec_Res_ConfirmPass.Text == txt_Lec_Res_NewPass.Text && OLDPass == txt_Lec_Res_CurPass.Text)
                {
                    if (txt_Lec_Res_ConfirmPass.Text == txt_Lec_Res_NewPass.Text)
                    {
                        txt_Lec_Res_NewPass.PasswordChar = '*';
                        txt_Lec_Res_ConfirmPass.PasswordChar = '*';
                        txt_Lec_Res_CurPass.PasswordChar = '*';

                        try
                        {
                            
                            string ChaPass = "UPDATE tbl_lecture SET LecPassword= '" + txt_Lec_Res_ConfirmPass.Text + "' WHERE Lecture_ID='" + lbl_LecID.Text + "';";
                            cmd = new MySqlCommand(ChaPass, Con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Password Reset Sucessfully", "Reset sucessfully", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            Con.Close();
                            txt_Lec_Res_ConfirmPass.Text = string.Empty;
                            txt_Lec_Res_CurPass.Text = string.Empty;
                            txt_Lec_Res_NewPass.Text = string.Empty;
                            pnl_Lec_ChangeProfile.Visible = false;
                            Pnl_resetPass.Visible = false;
                            Pro_Barcode.Visible = false;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                

                }

                else
                {
                    MessageBox.Show("Wrong Attempt", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            }




            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }        

           
        }

       

        private void Lec_Profile_Load(object sender, EventArgs e)
        {
            Pnl_LecProDisplay.Visible = true;
            pnl_Lec_ChangeProfile.Visible = false;
            Pnl_resetPass.Visible=false;
            Pro_Barcode.Visible=false;
            txt_Lec_Res_ConfirmPass.Text = string.Empty;
            txt_Lec_Res_CurPass.Text = string.Empty;
            txt_Lec_Res_NewPass.Text = string.Empty;

            //------------------------------- For Display Data About Lecture --------------------------------------------------------
            lbl_LecID.Text=   Form1.disuser;
                txt_LecID.Text = Form1.disuser;

            try
            {
               MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;

                Con.Open();
                string Query = "Select*from tbl_lecture where Lecture_ID ='" + txt_LecID.Text+"'";
                cmd = new MySqlCommand(Query, Con);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read()) 
                    {
                        lbl_LecID.Text = dr[0].ToString();
                        lbl_Name.Text = dr[1].ToString();
                        lbl_MobiNum.Text = dr[2].ToString();    
                        label3.Text = dr[4].ToString();
                        txt_LecName.Text = dr[1].ToString();
                        txt_LecMobiNum.Text = dr[2].ToString();
                    }
                }
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           





        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
           if (Pnl_LecProDisplay.Visible == true)
            {
                Pnl_LecProDisplay.Visible = false;
                pnl_Lec_ChangeProfile.Visible = true;
            }
            else
            {
                Pnl_LecProDisplay.Visible = true;
                pnl_Lec_ChangeProfile.Visible = false;
            }
            
           
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
    //------------------------------- For Display Lecture Details -------------------------------------------------
            String Num = txt_LecMobiNum.Text;
            String Name = txt_LecName.Text;

            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;

                Con.Open();
                string QueryUp = "UPDATE tbl_lecture SET Lecture_Name ='" + Name + "' , Lecture_MobNum='" + Num + "' WHERE Lecture_ID = '" + txt_LecID.Text + "';   ";
                cmd = new MySqlCommand(QueryUp, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reset Successfully", "Question Added Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

                string Query2 = "Select*from tbl_lecture where Lecture_ID ='" + txt_LecID.Text + "'";
                cmd = new MySqlCommand(Query2, Con);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lbl_LecID.Text = dr[0].ToString();
                        lbl_Name.Text = dr[1].ToString();
                        lbl_MobiNum.Text = dr[2].ToString();
                        label3.Text = dr[4].ToString();
                        txt_LecName.Text = dr[1].ToString();
                        txt_LecMobiNum.Text = dr[2].ToString();
                    }
                }

                Con.Close();


                pnl_Lec_ChangeProfile.Visible= false;
                Pnl_LecProDisplay.Visible= true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txt_LecName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
