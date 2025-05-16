using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize_based_Exam_Management_System.Lecture
{
    public partial class UC_ApprovalQuiz : UserControl
    {
        public UC_ApprovalQuiz()
        {
            InitializeComponent();
        }

        public static string LecT;

        public static string DisLec
        {
            get { return LecT; }
            set { LecT = value; }
        }

        
        public static string QueSET;

        public static string DISQUE
        {
            get { return QueSET; }
            set { QueSET = value; }
        }

        private void LECT()
        {
            String TempLec = Form1.disuser;

                    if (TempLec.Substring(0, 5)=="HNDIT")
                    {
                        LecT = "HNDIT";
                    } else if (TempLec.Substring(0, 5) == "HNDE0")
                    {
                        LecT = "HNDE";
                    } else if (TempLec.Substring(0, 5) == "HNDA0")
                    {
                         LecT = "HNDA";
                    }
                    else
                    {
                         LecT = "HNDTHM";
                    }
        }

        private void btn_Ques1_Click(object sender, EventArgs e)
        {
            if(btn_Ques2.Text=="Approved"|| btn_Ques3.Text == "Approved"|| btn_Ques4.Text == "Approved"|| btn_Ques5.Text == "Approved"|| btn_Ques6.Text == "Approved")
            {
                MessageBox.Show("Already Question set was approved", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (btn_Ques1.Text == "Approve")
                {
                    btn_Ques1.FillColor = Color.DarkGreen;
                    btn_Ques1.Text = "Approved";
                    QueSET = "01";
                    LECT();



                    MessageBox.Show("Question Set 01 is Approved Sucessfully", "Approval Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                
                
                }
                else if (btn_Ques1.Text == "Approved")
                {
                    btn_Ques1.Text = "Approve";
                    btn_Ques1.FillColor = Color.Maroon;
                }
            }
           

        }

        private void btn_Ques2_Click(object sender, EventArgs e)
        {
            if (btn_Ques1.Text == "Approved" || btn_Ques3.Text == "Approved" || btn_Ques4.Text == "Approved" || btn_Ques5.Text == "Approved" || btn_Ques6.Text == "Approved")
            {
                MessageBox.Show("Already Question set was approved", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (btn_Ques2.Text == "Approve")
                {
                    btn_Ques2.FillColor = Color.DarkGreen;
                    btn_Ques2.Text = "Approved";
                    QueSET = "02";
                    LECT();
                    MessageBox.Show("Question Set 02 is Approved Sucessfully", "Approval Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (btn_Ques2.Text == "Approved")
                {
                    btn_Ques2.Text = "Approve";
                    btn_Ques2.FillColor = Color.Maroon;
                }
            }
        }

        private void btn_Ques3_Click(object sender, EventArgs e)
        {
            if (btn_Ques2.Text == "Approved" || btn_Ques1.Text == "Approved" || btn_Ques4.Text == "Approved" || btn_Ques5.Text == "Approved" || btn_Ques6.Text == "Approved")
            {
                MessageBox.Show("Already Question set was approved", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (btn_Ques3.Text == "Approve")
                {
                    btn_Ques3.FillColor = Color.DarkGreen;
                    btn_Ques3.Text = "Approved";
                    QueSET = "03";
                    LECT();
                    MessageBox.Show("Question Set 03 is Approved Sucessfully", "Approval Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (btn_Ques3.Text == "Approved")
                {
                    btn_Ques3.Text = "Approve";
                    btn_Ques3.FillColor = Color.Maroon;
                }
            }
        }

        private void btn_Ques4_Click(object sender, EventArgs e)
        {
            if (btn_Ques2.Text == "Approved" || btn_Ques3.Text == "Approved" || btn_Ques1.Text == "Approved" || btn_Ques5.Text == "Approved" || btn_Ques6.Text == "Approved")
            {
                MessageBox.Show("Already Question set was approved", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (btn_Ques4.Text == "Approve")
                {
                    btn_Ques4.FillColor = Color.DarkGreen;
                    btn_Ques4.Text = "Approved";
                    QueSET = "04";
                    LECT();
                    MessageBox.Show("Question Set 04 is Approved Sucessfully", "Approval Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (btn_Ques4.Text == "Approved")
                {
                    btn_Ques4.Text = "Approve";
                    btn_Ques4.FillColor = Color.Maroon;
                }
            }
        }

        private void btn_Ques5_Click(object sender, EventArgs e)
        {
            if (btn_Ques2.Text == "Approved" || btn_Ques3.Text == "Approved" || btn_Ques4.Text == "Approved" || btn_Ques1.Text == "Approved" || btn_Ques6.Text == "Approved")
            {
                MessageBox.Show("Already Question set was approved", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (btn_Ques5.Text == "Approve")
                {
                    btn_Ques5.FillColor = Color.DarkGreen;
                    btn_Ques5.Text = "Approved";
                    QueSET = "05";
                    LECT();
                    MessageBox.Show("Question Set 05 is Approved Sucessfully", "Approval Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (btn_Ques5.Text == "Approved")
                {
                    btn_Ques5.Text = "Approve";
                    btn_Ques5.FillColor = Color.Maroon;
                }
            }
        }

        private void btn_Ques6_Click(object sender, EventArgs e)
        {
            if (btn_Ques2.Text == "Approved" || btn_Ques3.Text == "Approved" || btn_Ques4.Text == "Approved" || btn_Ques5.Text == "Approved" || btn_Ques1.Text == "Approved")
            {
                MessageBox.Show("Already Question set was approved", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (btn_Ques6.Text == "Approve")
                {
                    btn_Ques6.FillColor = Color.DarkGreen;
                    btn_Ques6.Text = "Approved";
                    QueSET = "06";
                    LECT();
                    MessageBox.Show("Question Set 06 is Approved Sucessfully", "Approval Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (btn_Ques6.Text == "Approved")
                {
                    btn_Ques6.Text = "Approve";
                    btn_Ques6.FillColor = Color.Maroon;
                }
            }


        }
    }
}
