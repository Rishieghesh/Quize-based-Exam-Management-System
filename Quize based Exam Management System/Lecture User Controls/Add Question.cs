using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Quize_based_Exam_Management_System.Lecture
{
    public partial class Add_Question : UserControl
    {

    //------------------------------------ Make Sql connection-----------------------------------------------------------------------
        string SQLCon = "server=localhost;database=quizems;uid=root;pwd=''";

        public static Add_Question instance;


        public Add_Question()
        {
            InitializeComponent();
            instance = this;
            
        }


        private void Add_Question_Load(object sender, EventArgs e)
        {
            Clear();
            Combo_QuesSet.SelectedIndex = -1;         
            txt_Qnum.Text = "0";
        }

        private void Clear()
        {
            Combo_Answer.SelectedIndex = -1;
            txt_Question.Text = string.Empty;
            txt_optionA.Text = string.Empty;
            txt_optionB.Text = string.Empty;
            txt_optionC.Text = string.Empty;
            txt_optionD.Text = string.Empty;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            string Answer;

            if (Combo_Answer.SelectedIndex == 0)
            {
                Answer = txt_optionA.Text;
            }
            else if (Combo_Answer.SelectedIndex == 1)
            {
                Answer = txt_optionB.Text;
            }
            else if (Combo_Answer.SelectedIndex == 2)
            {
                Answer = txt_optionC.Text;
            }
            else
            {
                Answer = txt_optionD.Text;
            }


            MySqlConnection Con = new MySqlConnection(SQLCon);
            MySqlCommand cmd;
            MySqlDataReader dr;

            string QIII;

            String Dept = Lecture_Form.DisDepart;

//------------------- Form Question Identification -------------------------------------------------------

            string QID = Dept + Combo_QuesSet.Text + txt_Qnum.Text ;
            String Qset = Combo_QuesSet.Text;
            string QNo = txt_Qnum.Text.ToString();
            string Question = txt_Question.Text;
            string OpA = txt_optionA.Text;
            string OpB = txt_optionB.Text;
            string OpC = txt_optionC.Text;
            string OpD = txt_optionD.Text;
            String Ans = Answer;


            if (txt_optionA.Text==""||txt_optionB.Text=="" ||txt_optionC.Text=="" ||txt_optionD.Text=="" ||txt_Question.Text=="" || txt_Qnum.Text == "" ||Combo_Answer.SelectedIndex==-1)
            
            {
                MessageBox.Show("System did not accept it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else {

            //------------------------------------Questions are added in database---------------------------------------------------------
              
                try { 
                Con.Open();

                cmd = new MySqlCommand("insert into tbl_quiz(Que_ID, Que_Set, Que_Num, Que_OptA, Que_OptB ,Que_OptC ,Que_OptD, Que_Ans,Que_Question,Department) values('" + QID + "','" + Qset + "','" + QNo + "', '" + OpA + "', '" + OpB + "' , '" + OpC + "' , '" + OpD + "' , '" + Ans + "','"+Question+"','"+ Dept + "' )",Con) ;
                cmd.ExecuteNonQuery();

            //-----------------------------------Question Added Message----------------------------------
                
                MessageBox.Show("Question Added Successfully", "Question Added Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();

            //--------------------------for clear all textboxes and combo boxes------------------------------------------
                Clear();
                QuesNum();

                }                                
                catch (Exception ex)
                {
                    Con.Close();
                    MessageBox.Show(ex.Message , "Warning" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }                       


            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data is not save, So data will loss", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               Clear();
               Combo_QuesSet.SelectedIndex = -1;
                oriQueNum();
            }           
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            if(txt_Question.Text==string.Empty || txt_optionA.Text == string.Empty || txt_optionB.Text == string.Empty || txt_optionC.Text == string.Empty || txt_optionD.Text==string.Empty||Combo_Answer.SelectedIndex==-1)
            {
                if (MessageBox.Show("Your Question Set is finish." + "Are you agree with it? ", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Clear();
                    Combo_QuesSet.SelectedIndex = -1;
                    oriQueNum();
                }
            }

            else
            {
                string Answer;

                if (Combo_Answer.SelectedIndex == 0)
                {
                    Answer = txt_optionA.Text;
                }
                else if (Combo_Answer.SelectedIndex == 1)
                {
                    Answer = txt_optionB.Text;
                }
                else if (Combo_Answer.SelectedIndex == 2)
                {
                    Answer = txt_optionC.Text;
                }
                else
                {
                    Answer = txt_optionD.Text;
                }

                String Dept = Form1.disuser;
                String IDform = Dept.Substring(0, 5);

                //------------------- Form Question Identification -------------------------------------------------------

                string QID = IDform + Combo_QuesSet.Text + txt_Qnum.Text;
                String Qset = Combo_QuesSet.Text;
                string QNo = txt_Qnum.Text.ToString();
                string Question = txt_Question.Text;
                string OpA = txt_optionA.Text;
                string OpB = txt_optionB.Text;
                string OpC = txt_optionC.Text;
                string OpD = txt_optionD.Text;
                String Ans = Answer;
                try
                {
                    MySqlConnection Con = new MySqlConnection(SQLCon);
                    MySqlCommand cmd;
                    MySqlDataReader dr;

                    Con.Open();

                    cmd = new MySqlCommand("insert into tbl_quiz(Que_ID, Que_Set, Que_Num, Que_OptA, Que_OptB ,Que_OptC ,Que_OptD, Que_Ans,Que_Question) values('" + QID + "','" + Qset + "','" + QNo + "', '" + OpA + "', '" + OpB + "' , '" + OpC + "' , '" + OpD + "' , '" + Ans + "','" + Question + "' )", Con);
                    cmd.ExecuteNonQuery();

                    //-----------------------------------Question Added Message----------------------------------

                    MessageBox.Show("Question Added Successfully and Your Question Set is finish. ", "Question set completed Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();

                    //--------------------------for clear all textboxes and combo boxes------------------------------------------
                    Combo_QuesSet.SelectedIndex = -1;
                    Clear();
                    oriQueNum();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void oriQueNum()
        {
            String Lec = Form1.disuser;
            String Dep = Lec.Substring(0, 5);


            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;

                string Identity = Dep + Combo_QuesSet.Text;
                Con.Open();
                String Query_DisplayNum = "SELECT COUNT(Que_ID) FROM tbl_quiz WHERE Que_ID LIKE @Identity";
                cmd = new MySqlCommand(Query_DisplayNum, Con);

                // Add a parameter for the LIKE condition
                cmd.Parameters.AddWithValue("@Identity", $"{Identity}%");

                int count = Convert.ToInt32(cmd.ExecuteScalar()) ;
                // LBL_Q_num.Text = count.ToString();
                txt_Qnum.Text = count.ToString();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void QuesNum()
        {
            String Lec = Form1.disuser;
            String Dep = Lec.Substring(0, 5);

            
                try
                {
                    MySqlConnection Con = new MySqlConnection(SQLCon);
                    MySqlCommand cmd;
                    MySqlDataReader dr;

                    string Identity = Dep + Combo_QuesSet.Text;
                    Con.Open();
                    String Query_DisplayNum = "SELECT COUNT(Que_ID) FROM tbl_quiz WHERE Que_ID LIKE @Identity";
                    cmd = new MySqlCommand(Query_DisplayNum, Con);

                    // Add a parameter for the LIKE condition
                    cmd.Parameters.AddWithValue("@Identity", $"{Identity}%");

                    int count = Convert.ToInt32(cmd.ExecuteScalar())+1;
                   // LBL_Q_num.Text = count.ToString();
                    txt_Qnum.Text = count.ToString();
            }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            


        }

        private void Combo_QuesSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            QuesNum();

        }
       

        private void Combo_Answer_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }

}

