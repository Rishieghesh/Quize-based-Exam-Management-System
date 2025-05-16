using Guna.UI2.Native;
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
using Quize_based_Exam_Management_System.Lecture;
using MySql.Data.MySqlClient;


namespace Quize_based_Exam_Management_System
{
    public partial class Lecture_Form : Form
    {
        Form1 f1;
         
              

        public Lecture_Form(Form1 frm1)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.f1 = frm1;
        }

        public static string Depart;
        public static string DisDepart
        {
            get { return Depart; }
            set { Depart = value; }
        }



        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        string SQLCon = "server=localhost;database=quizems;uid=root;pwd=''";

        private void Lecture_Form_Load(object sender, EventArgs e)
        {
            lbl_Lecture.Text = Form1.disuser;
            string LecIDD = lbl_Lecture.Text;

            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;

                Con.Open();
                string Query = "Select*from tbl_lecture where Lecture_ID ='" + LecIDD + "'";
                cmd = new MySqlCommand(Query, Con);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lbl_Department.Text = dr[4].ToString();
                        Depart =lbl_Department.Text;
                    }
                }
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //---------------------------- For visible User Controls ----------------------------------------
            ContentPannel.Visible = true;
            lec_StuDetails1.Visible = false;
            lec_StuReport1.Visible = false;
            studentsResult1.Visible = false;
            lec_UpdateQue1.Visible = false;
            lec_Profile1.Visible = false;
            add_Question1.Visible =false;
            uC_ApprovalQuiz1.Visible= false;
        }

        private void btn_AddQus_Click(object sender, EventArgs e)
        {
            ContentPannel.Visible = true;
            add_Question1.Visible = true;
            lec_UpdateQue1.Visible = false;
            lec_Profile1.Visible = false;
            uC_ApprovalQuiz1.Visible = false;
            studentsResult1.Visible = false;
            lec_StuReport1.Visible = false;
            lec_StuDetails1 .Visible = false;



        }

        private void btn_UpdateQues_Click(object sender, EventArgs e)
        {

            uC_ApprovalQuiz1.Visible = false;
            ContentPannel.Visible = true;
            lec_UpdateQue1.Visible = true;
            add_Question1.Visible = false;
            lec_Profile1.Visible = false;
            studentsResult1.Visible = false;
           lec_StuDetails1.Visible = false;
            lec_StuReport1.Visible = false;


        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Minimized;
        }

        private void btn_Rest_Down_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState=FormWindowState.Normal;
            }
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            ContentPannel.Visible = true;
            lec_Profile1.Visible=true;
            add_Question1.Visible = false;
            lec_UpdateQue1.Visible = false;
            uC_ApprovalQuiz1.Visible = false;
            lec_StuDetails1.Visible = false;
            studentsResult1.Visible=false;
            lec_StuReport1.Visible = false;
                              
                
                   
        }

           private void ContentPannel_Paint(object sender, PaintEventArgs e)
           {

           }



           private void btn_StuDetails_Click(object sender, EventArgs e)
           {
                ContentPannel.Visible = true;
                lec_StuDetails1.Visible = true;
                lec_StuReport1.Visible=false;
                studentsResult1.Visible = false;
                lec_UpdateQue1.Visible = false;
                lec_Profile1.Visible = false;
                add_Question1.Visible = false;
            uC_ApprovalQuiz1.Visible = false;
            lec_StuReport1.Visible = false;
        }

        private void btn_StuReport_Click(object sender, EventArgs e)
        {
            ContentPannel.Visible = true;
            lec_StuDetails1.Visible = false;
            lec_StuReport1.Visible = true;
            studentsResult1.Visible = false;
            lec_UpdateQue1.Visible = false;
            lec_Profile1.Visible = false;
            add_Question1.Visible = false;
            uC_ApprovalQuiz1.Visible = false;
        }

          private void btn_StudentResult_Click(object sender, EventArgs e)
          {
              ContentPannel.Visible = true;

              lec_StuDetails1.Visible = false;
              lec_StuReport1.Visible = false;
              studentsResult1.Visible = true;
              lec_UpdateQue1.Visible = false;
              lec_Profile1.Visible = false;
              add_Question1.Visible = false;
              uC_ApprovalQuiz1.Visible = false;

        }

        

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ContentPannel.Visible = true;
            uC_ApprovalQuiz1.Visible = true;
            lec_Profile1.Visible = false;
            add_Question1.Visible = false;
            lec_UpdateQue1.Visible = false;
            lec_StuDetails1.Visible=false;
            studentsResult1.Visible = false;
            /*  studentsDetails1.Visible = false;
              studentReport1.Visible = false;
              
              update_Question1.Visible = false;
               */
        }

        private void PannelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
