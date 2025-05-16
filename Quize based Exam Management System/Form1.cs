using New_User_Form;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Quize_based_Exam_Management_System.Lecture;

namespace Quize_based_Exam_Management_System
{
    public partial class Form1 : Form
    {
        string SQLCon = "server=localhost;database=quizems;uid=root;pwd=''";


        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_SelectUser.SelectedIndex==0 )
            {
                StudentPannel.Visible = true;
                LecturePannel.Visible = false;
                LectWrong.Visible = false;
                Stu_wrong.Visible = false;
            }

            else
            {
                StudentPannel.Visible = false;
                LecturePannel.Visible = true;
                LectWrong.Visible = false;
                Stu_wrong.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentPannel.Visible = false;
            LecturePannel.Visible = false;

        }


        public static string username;
        public static string disuser
        {
            get { return username; }
            set { username = value; }
        }

        public static string Stude;
        public static string disStu
        {
            get { return Stude; }
            set { Stude = value; }
        }

        public static string Studpart;
        public static string disStuDepa
        {
            get { return Studpart; }
            set { Studpart = value; }
        }


        public static string PubDepart;
        public static string disDepart
        {
            get { return PubDepart; }
            set { PubDepart = value; }
        }


        private void btn_LecLogin_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;

                Con.Open();
                String Query = "Select * From tbl_lecture where Lecture_ID=@Username and LecPassword = @Password";

                cmd = new MySqlCommand(Query, Con);
                cmd.Parameters.AddWithValue("@Username",txt_LectureID.Text);
                cmd.Parameters.AddWithValue("@Password", txt_LectPass.Text);
                dr = cmd.ExecuteReader();

                                  
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            
                            disuser = txt_LectureID.Text;
                        string PD;
                            if (txt_LectureID.Text.Substring(0,4)=="HNDI")
                            {
                                 PD = "HNDIT"; 
                            }
                            else if(txt_LectureID.Text.Substring(0, 4) == "HNDE")
                            {
                                PD = "HNDE";
                            }
                            else if (txt_LectureID.Text.Substring(0, 4) == "HNDA")
                            {
                                PD = "HNDA";
                            }
                            else
                            {
                                PD = "HNDTHM";
                            }

                        PubDepart = PD;
                            

                        this.Hide();
                            Lecture_Form le = new Lecture_Form(this);
                            le.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter the Valid Lecture ID or Password ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LectWrong.Visible = true;
                    }
               



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void ChekPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ChekPass.Checked==true) 
            {
                txt_LectPass.PasswordChar = '\0';
                ChekPass.Text = "Hide Password";
                                           
            }

            else
            {
                txt_LectPass.PasswordChar = '*';
                ChekPass.Text = "Show Password";
            }
        }

        private void btn_StuRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            StuRegis StuReg = new StuRegis();
            StuReg.Show();
        }

        private void btn_Stulogin_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;

                Con.Open();
                String StuQuery = "Select * From tbl_student where Stu_RegNum=@Username1 and Stu_Pass = @Password1";

                cmd = new MySqlCommand(StuQuery, Con);
                cmd.Parameters.AddWithValue("@Username1", txt_StuRegisNum.Text);
                cmd.Parameters.AddWithValue("@Password1", txt_StuPass.Text);
                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Stude = txt_StuRegisNum.Text;
                        String finddepment = txt_StuRegisNum.Text.Substring(0, 5);
                        string StuTemp;

                        if (finddepment == "BAT/I" || finddepment == "BAT-I")
                        {
                          StuTemp = "HNDIT";
                        }
                        else if (finddepment == "BAT/A" || finddepment == "BAT-A")
                        {
                            StuTemp = "HNDA";
                        }
                        else if (finddepment == "BAT/E" || finddepment == "BAT/E")
                        {
                            StuTemp = "HNDE";
                        }
                        else
                        {
                            StuTemp = "HNDTHM";
                        }


                       Studpart = StuTemp ;

                        this.Hide();
                        Stud_Form STF = new Stud_Form();
                        STF.Show();

                    }

                }
                else
                {
                    MessageBox.Show("Please enter the Valid Registation Number or Password ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Stu_wrong.Visible = true;
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBox1.Checked==true)
            {
               txt_StuPass.PasswordChar = '\0';
                checkBox1.Text = "Hide Password";
            }
            else
            {
                txt_StuPass.PasswordChar = '*';
                checkBox1.Text = "Show Password";
            }
                
        }

        private void btn_LecRegis_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecRegis Regis = new LecRegis();
            Regis.Show();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forget_Password forget_Password =new Forget_Password();
            forget_Password.Show();
        }

        private void txt_LectPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void LecturePannel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
