using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize_based_Exam_Management_System.Student_user_controls
{
    public partial class UC_StuProf : UserControl
    {
        string SQLCon = "server=localhost;database=quizems;uid=root;pwd=''";


        public UC_StuProf()
        {
            InitializeComponent();
        }

        private void btn_ResetPass_Click(object sender, EventArgs e)
        {
           
            if (pnl_ResetPass.Visible == false)
            {
                pnl_ResetPass.Visible = true;
                txt_ConfirmPass.Text =string.Empty;
                txt_CurPass.Text = string.Empty;
                txt_NewPass.Text = string.Empty;
            }
            else
            {
                pnl_ResetPass.Visible = false;
            }
        }

        private void UC_StuProf_Load(object sender, EventArgs e)
        {
            pnl_ResetPass.Visible=false;
            Pro_Barcode.Visible = false;


            lbl_StuRegNo.Text = Form1.disStu;
           
            

            try
            {  
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader row;
                

                Con.Open();
                string Query = "Select* from tbl_student where Stu_RegNum='"+lbl_StuRegNo.Text+"'";
                cmd = new MySqlCommand(Query, Con);
                row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        lbl_stuFuName.Text = row[1].ToString();
                        lbl_StuPhoneNo.Text = row[2].ToString();
                        lbl_StuGender.Text = row[3].ToString();
                        lbl_StuNic.Text = row[4].ToString();
                        lbl_StuGmail.Text = row[6].ToString();
                        lbl_StuDepart.Text= row[7].ToString();
                    }


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }

        private string OLDPass;
        
        private void btn_PassConfirm_Click(object sender, EventArgs e)
        {
            String StuFormRegi = Form1.disStu;
    //----------------------------------------------------------------------------------------------------------------------------
            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;

                Con.Open();
                string pasChaQuery = "SELECT Stu_Pass FROM tbl_student WHERE Stu_RegNum  = @StuID";
                cmd = new MySqlCommand(pasChaQuery, Con);
                cmd.Parameters.AddWithValue("@StuID", StuFormRegi);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    OLDPass = result.ToString();
                }

                if (txt_CurPass.Text == txt_NewPass.Text)
                {

                    MessageBox.Show("Your Passwords are same , You can't change on it", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (txt_ConfirmPass.Text == txt_NewPass.Text && OLDPass == txt_CurPass.Text)
                {
                    try
                    {

                        string ChaPass = "UPDATE tbl_student SET Stu_Pass= '" + txt_ConfirmPass.Text + "' WHERE Stu_RegNum ='" + StuFormRegi + "';";
                        cmd = new MySqlCommand(ChaPass, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Reset Sucessfully", "Reset sucessfully", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        Con.Close();

                        txt_ConfirmPass.Text = string.Empty;
                        txt_CurPass.Text = string.Empty;
                        txt_NewPass.Text = string.Empty;
                        pnl_ResetPass.Visible = false;
                        Pro_Barcode.Visible = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                else
                {
                    MessageBox.Show("Wrong Attempt", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }




            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
