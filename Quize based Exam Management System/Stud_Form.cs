using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize_based_Exam_Management_System
{
    public partial class Stud_Form : Form
    {
        public Stud_Form()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            uC_StuProf1.Visible = true;
            uC_StuResult1.Visible = false;
        }

        private void btn_UpdateQues_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quiz_form quiz_Form = new Quiz_form();
            quiz_Form.Show();
        }

        private void btn_StudentResult_Click(object sender, EventArgs e)
        {
            uC_StuProf1.Visible = false;
            uC_StuResult1.Visible = true;
        }

        private void Stud_Form_Load(object sender, EventArgs e)
        {
            lbl_StuRegiNo.Text = Form1.Stude;
            lbl_Depaartment.Text = Form1.disStuDepa;

            uC_StuProf1.Visible = false;
            uC_StuResult1.Visible = false;

        }

       

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Rest_Down_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
