using Quize_based_Exam_Management_System.Student_user_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Quize_based_Exam_Management_System.Lecture;
using System.Security.Cryptography;
using System.Threading;
using System.Linq.Expressions;
using MySqlX.XDevAPI.Common;
using Google.Protobuf.WellKnownTypes;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Quize_based_Exam_Management_System
{
    public partial class Quiz_form : Form
    {

        string SQLCon = "server=localhost;database=quizems;uid=root;pwd=''";


        public Quiz_form()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void DisplayQues()
        {
             if (lbl_QueSet.Text == "01")
            {
                SetQue = "Mark_Set1";
                date = "Date_Mrk1";
                NamRes = "Result_mrk1";


            }
            else if (lbl_QueSet.Text == "02")
            {
                SetQue = "Mark_Set2";
                date = "Date_Mrk2";
                NamRes = "Result_mrk2";
            }
            else if (lbl_QueSet.Text == "03")
            {
                SetQue = "Mark_Set3";
                date = "Date_Mrk3";
                NamRes = "Result_mrk3";

            }
            else if (lbl_QueSet.Text == "04")
            {
                SetQue = "Mark_Set4";
                date = "Date_Mrk4";
                NamRes = "Result_mrk4";

            }
            else if (lbl_QueSet.Text == "05")
            {
                SetQue = "Mark_Set5";
                date = "Date_Mrk5";
                NamRes = "Result_mrk5";
            }
            else
            {
                SetQue = "Mark_Set6";
                date = "Date_Mrk6";
                NamRes = "Result_mrk6";
            }

            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader row;


                Con.Open();
                string Query = "Select * from tbl_marks where Stu_RegiNum='" + lbl_RegiNum.Text + "'";
                cmd = new MySqlCommand(Query, Con);
                row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        
                        label7.Text = row[1].ToString();

                    }


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            //----------------------------------------------- For Display Label Values ----------------------------------------------

            lbl_RegiNum.Text = Form1.Stude;
            lbl_Department.Text = Form1.disStuDepa;


            if (UC_ApprovalQuiz.LecT == lbl_Department.Text)
            {
                lbl_QueSet.Text = UC_ApprovalQuiz.QueSET;
            }

            DateTime dateTime = DateTime.UtcNow.Date;
            lbl_Date.Text = dateTime.ToString("d/MM/yyyy");

            DateTime Time = DateTime.Now;
            lbl_Time.Text = Time.ToString("hh:mm");

            lbl_QueNo.Text = Convert.ToString(Qnum);

            //*******************************************************************************************************************************


            //-------------------------------------------------- For Display Question ---------------------------------------------------------  

            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader row;


                string ID = lbl_Department.Text + lbl_QueSet.Text + lbl_QueNo.Text;

                Con.Open();
                string Query = "SELECT * FROM tbl_quiz WHERE Que_ID LIKE @ID";
                cmd = new MySqlCommand(Query, Con);

                // Add a parameter for the LIKE condition
                cmd.Parameters.AddWithValue("@ID", $"{ID}%");

                row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        lbl_Question.Text = row[4].ToString();
                        lbl_OptA.Text = row[5].ToString();
                        lbl_OptB.Text = row[6].ToString();
                        lbl_OptC.Text = row[7].ToString();
                        lbl_OptD.Text = row[8].ToString();

                        if (lbl_Question.Text.Length > 120)
                        {
                            // Split the text into lines with a maximum length of 70 characters
                            int maxLineLength = 120;
                            string originalText = lbl_Question.Text;
                            StringBuilder formattedText = new StringBuilder();

                            for (int i = 0; i < originalText.Length; i += maxLineLength)
                            {
                                int length = Math.Min(maxLineLength, originalText.Length - i);
                                formattedText.AppendLine(originalText.Substring(i, length));
                            }

                            // Set the formatted text to the label
                            lbl_Question.Text = formattedText.ToString();
                        }

                        if (lbl_OptA.Text.Length > 60 || lbl_OptB.Text.Length > 60 || lbl_OptC.Text.Length > 60 || lbl_OptD.Text.Length > 60)
                        {
                            // Split the text into lines with a maximum length of 60 characters for RB_OptionA
                            int maxLineLength = 60;

                            // Process RB_OptionA text
                            string originalTextA = lbl_OptA.Text;
                            StringBuilder formattedTextA = new StringBuilder();

                            for (int i = 0; i < originalTextA.Length; i += maxLineLength)
                            {
                                int length = Math.Min(maxLineLength, originalTextA.Length - i);
                                formattedTextA.AppendLine(originalTextA.Substring(i, length));
                            }

                            // Set the formatted text to lbl_OptA
                            lbl_OptA.Text = formattedTextA.ToString();

                            // Process RB_OptionB text
                            string originalTextB = lbl_OptB.Text;
                            StringBuilder formattedTextB = new StringBuilder();

                            for (int i = 0; i < originalTextB.Length; i += maxLineLength)
                            {
                                int length = Math.Min(maxLineLength, originalTextB.Length - i);
                                formattedTextB.AppendLine(originalTextB.Substring(i, length));
                            }

                            // Set the formatted text to lbl_OptB
                            lbl_OptB.Text = formattedTextB.ToString();

                            // Process RB_OptionC text
                            string originalTextC = lbl_OptC.Text;
                            StringBuilder formattedTextC = new StringBuilder();

                            for (int i = 0; i < originalTextC.Length; i += maxLineLength)
                            {
                                int length = Math.Min(maxLineLength, originalTextC.Length - i);
                                formattedTextC.AppendLine(originalTextC.Substring(i, length));
                            }

                            // Set the formatted text to lbl_OptC
                            lbl_OptC.Text = formattedTextC.ToString();

                            // Process lbl_OptD text
                            string originalTextD = lbl_OptD.Text;
                            StringBuilder formattedTextD = new StringBuilder();

                            for (int i = 0; i < originalTextD.Length; i += maxLineLength)
                            {
                                int length = Math.Min(maxLineLength, originalTextD.Length - i);
                                formattedTextD.AppendLine(originalTextD.Substring(i, length));
                            }

                            // Set the formatted text to lbl_OptD
                            RB_OptionD.Text = formattedTextD.ToString();
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
//*************************************************************************************************************************************
   //------------------------------- Defined Variables for Calculate marks -------------------------------------------------


                
                private int Qnum = 1;
                
        private static int count;
        private static int QueToCount
        {
            get { return count; }
            set { count = value; }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------

        private void countQue()
        {

            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;

                string Identity = lbl_Department.Text + lbl_QueSet.Text;
                Con.Open();
                String Query_DisplayNum = "SELECT COUNT(Que_ID) FROM tbl_quiz WHERE Que_ID LIKE @Identity";
                cmd = new MySqlCommand(Query_DisplayNum, Con);

                // Add a parameter for the LIKE condition
                cmd.Parameters.AddWithValue("@Identity", $"{Identity}%");

                count = Convert.ToInt32(cmd.ExecuteScalar());              
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

//**************************************************************************************************************************

        private string CRTAns;
        private int TemCAns =0;

        private static double FinalMark;
        private static double MarkAssume
        {
            get { return FinalMark; }
            set { FinalMark = value; }
        }

        private void MarksGen()
        {
//---------------------------------------------- For Option Checked -----------------------------------------------------------

            string StuAns;

            if (RB_OptionA.Checked)
            {
                StuAns = lbl_OptA.Text;
                
            }
            else if (RB_OptionB.Checked)
            {
                StuAns = lbl_OptB.Text;
            }
            else if (RB_OptionC.Checked)
            {
                StuAns = lbl_OptC.Text;
            }
            else
            {
                StuAns = lbl_OptD.Text;
               
            }

            string CheckAns = StuAns;            


            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                              
                Con.Open();
                string Identity = lbl_Department.Text + lbl_QueSet.Text + lbl_QueNo.Text;
                String Query_Answer = "SELECT Que_Ans FROM tbl_quiz WHERE Que_ID LIKE @Identity";
                cmd = new MySqlCommand(Query_Answer, Con);
                    
                // Add a parameter for the LIKE condition
                cmd.Parameters.AddWithValue("@Identity", $"{Identity}%");

                 // Use ExecuteScalar directly
                 object result = cmd.ExecuteScalar();

                 // Check for NULL values
                 CRTAns = result.ToString();  
                 
                 
                if(CRTAns == CheckAns)
                {
                    double temp = ++TemCAns;
                    double Pcount = Quiz_form.QueToCount;

                    double Marks = (temp / Pcount) * 100;
                    Quiz_form.FinalMark=Marks;
                    

                }
                else
                {
                    double temp = TemCAns;
                    double Pcount = Quiz_form.QueToCount;

                    double Marks = (temp/ Pcount) * 100;
                    Quiz_form.FinalMark = Marks;
                    
                }
                 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private static string SetQue;
        private static string QueSET
        {
            get { return SetQue; }
            set { SetQue = value; }
        }

        private static string date;
        private static string QueDate
        {
            get { return date; }
            set { date = value; }
        }

        private static string Res;
        private static string SRES
        {
            get { return Res; }
            set { Res = value; }
        }

        private static string NamRes;
        private static string NASRES
        {
            get { return NamRes; }
            set { NamRes = value; }
        }

        private void ADDMarks()
        {
          /*  if (lbl_QueSet.Text == "01")
            {
                SetQue = "Mark_Set1";
                date = "Date_Mrk1";
                NamRes = "Result_mrk1";


            }
            else if (lbl_QueSet.Text == "02")
            {
                SetQue = "Mark_Set2";
                date = "Date_Mrk2";
                NamRes = "Result_mrk2";
            }
            else if (lbl_QueSet.Text == "03")
            {
                SetQue = "Mark_Set3";
                date = "Date_Mrk3";
                NamRes = "Result_mrk3";

            }
            else if (lbl_QueSet.Text == "04")
            {
                SetQue = "Mark_Set4";
                date = "Date_Mrk4";
                NamRes = "Result_mrk4";

            }
            else if (lbl_QueSet.Text == "05")
            {
                SetQue = "Mark_Set5";
                date = "Date_Mrk5";
                NamRes = "Result_mrk5";
            }
            else
            {
                SetQue = "Mark_Set6";
                date = "Date_Mrk6";
                NamRes = "Result_mrk6";
            } 
            */
            double M = Quiz_form.MarkAssume;
            

            if (M >= 85)
            {
                Res = "A+";
            }
            else if(75<=M && M <= 84)
            {
                Res = "A";
            }
            else if (70 <= M && M <= 74)
            {
                Res= "A-";
            }
            else if(65<=M && M <= 69)
            {
                Res = "B+";
            }
            else if (60 <= M && M <= 64)
            {
                Res = "B";
            }
            else if (55 <= M && M <= 59)
            {
                Res = "B-";
            }
            else if (50 <= M && M <= 54)
            {
                Res = "C+";
            }
            else if (45 <= M && M <= 49)
            {
                Res = "C";
            }
            else if (40 <= M && M <=44)
            {
                Res = "C-";
            }
            else if (35 <= M && M <= 39)
            {
                Res = "D+";
            }
            else if (30 <= M && M<=34 )
            {
                Res = "D";
            }
            else
            {
                Res = "E";
            }


            string OutputMark = Quiz_form.MarkAssume.ToString("0.00");

             using (MySqlConnection conn = new MySqlConnection(SQLCon))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        try
                        {
                            conn.Open();
                                                        
                            string SET = Quiz_form.QueSET;
                            string SEDA = Quiz_form.QueDate;
                            string ResR = Quiz_form.SRES;
                            string ResNam = Quiz_form.NASRES;

                            
                            DateTime dateTime = DateTime.UtcNow.Date;
                            string SetDate = dateTime.ToString("yyyy-MM-dd");

                            string query = $"UPDATE tbl_marks SET `{SET}` = @OutputMark , `{SEDA}` = @Date ,`{ResNam}` = '"+ResR+"' WHERE Stu_RegiNum = @RegiNum";

                            cmd.CommandText = query;
                            cmd.Connection = conn;

                            
                            cmd.Parameters.Add("@OutputMark", MySqlDbType.VarChar).Value = OutputMark;
                                                                                   
                            cmd.Parameters.Add("@Date", MySqlDbType.VarChar).Value = lbl_Date.Text;
                                                       
                            cmd.Parameters.Add("@RegiNum", MySqlDbType.VarChar).Value = lbl_RegiNum.Text;

                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {                            
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
             }

            this.Hide();
            Stud_Form Stufrm = new Stud_Form();
            Stufrm.Show();
        

        }

//*********************************************************************************************************************************





























        private void btn_StuHome_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to go student home page?", "Closing Quiz",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question   );
           
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Stud_Form Stufrm = new Stud_Form();
                Stufrm.Show();

                Calculator calfrm = new Calculator();
                calfrm.Hide();


            }    
        }

        private void btn_Calculator_Click(object sender, EventArgs e)
        {
            this.Show();
            Calculator calfrm = new Calculator();
            calfrm.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
          var Exit=  MessageBox.Show("If you exit the application will close & Your Quiz attenace did not acceptable,Do you want to exit?" ,
                "Exit Application " ,MessageBoxButtons.YesNo , MessageBoxIcon.Question);

            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

       
        private void btn_Finish_Click(object sender, EventArgs e)
        {

            if (RB_OptionA.Checked == true || RB_OptionB.Checked == true || RB_OptionC.Checked == true || RB_OptionD.Checked == true)
            {
                MarksGen();
                ADDMarks();               

            }
            else
            {
                MessageBox.Show("Please select the Answer", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel_Questions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clearall()
        {
            lbl_Date.Text=string.Empty;
            lbl_OptA.Text=string.Empty;
            lbl_OptB.Text=string.Empty;
            lbl_OptC.Text= string.Empty;
            lbl_OptD.Text= string.Empty;
            lbl_QueSet.Text= string.Empty;
            lbl_Question.Text= string.Empty;
            lbl_Time.Text= string.Empty;
           
        }





        private static string Available;
        private static string CheckAvail
        {
            get { return Available; }
            set { Available = value; }
        }

        private void Quiz_form_Load(object sender, EventArgs e)
        {
          
           


            if (lbl_RegiNum.Text != string.Empty)
            {
                DisplayQues();
                if (lbl_QueSet.Text == "QS")
                {
                    clearall();
                    var msg = MessageBox.Show("NO Quiz is Approved for you ", "QUIZ not Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (msg == DialogResult.OK)
                    {
                        this.Hide();
                        Stud_Form Stufrm = new Stud_Form();
                        Stufrm.Show();
                    }
                    else
                    {
                        this.Hide();
                        Stud_Form Stufrm = new Stud_Form();
                        Stufrm.Show();
                    }

                }
                else if (lbl_Question.Text == string.Empty)
                {
                    clearall();
                    var msg = MessageBox.Show("The Question set is empty ", "No Questions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (msg == DialogResult.OK)
                    {
                        this.Hide();
                        Stud_Form Stufrm = new Stud_Form();
                        Stufrm.Show();
                    }

                }

                else
                {
                    countQue();
                }
            }




        }

        
        private void btn_next_Click(object sender, EventArgs e)
        {
           

            if (RB_OptionA.Checked==true ||RB_OptionB.Checked==true||RB_OptionC.Checked==true||RB_OptionD.Checked==true)
            {
               
                MarksGen();

                int next = Qnum++;
                lbl_QueNo.Text = Convert.ToString(next);

                if (count > next)
                {
                    DisplayQues();
                    
                }
                else
                {
                    var complete = MessageBox.Show("Your Quiz set is completed", "Completed Successfully", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (complete == DialogResult.OK||complete==DialogResult.Cancel)
                    {
                        ADDMarks();

                        this.Close();
                        Stud_Form Stufrm = new Stud_Form();
                        Stufrm.Show();
                    }
                }
//------------------------------------------* For Options Clear *-----------------------------------------------------------------
                        RB_OptionA.Checked = false;
                        RB_OptionB.Checked = false;
                        RB_OptionC.Checked = false;
                        RB_OptionD.Checked = false;            
            }

            else
            {
                MessageBox.Show("Please Select the option","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
//****************************************************************************************************************************


        }
    }
}
