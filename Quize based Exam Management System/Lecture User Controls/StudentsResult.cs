using DGVPrinterHelper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize_based_Exam_Management_System.Lecture
{
    public partial class StudentsResult : UserControl
    {
        public StudentsResult()
        {
            InitializeComponent();
        }

        string SQLCon = "server=localhost;database=quizems;uid=root;pwd=''";

        private void DisplayData()
        {
            String Dep = Form1.disDepart;
            
            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;
                MySqlDataAdapter adapt;

                

                Con.Open();
                DataTable dt = new DataTable();
                String Query = "select `Stu_RegiNum`, `Mark_Set1` as 'Quiz SET 01', `Mark_Set2` as 'Quiz SET 02', `Mark_Set3` as 'Quiz SET 03', `Mark_Set4` as 'Quiz SET 04', `Mark_Set5` as 'Quiz SET 05', `Mark_Set6` as 'Quiz SET 06' from tbl_marks where Stu_Depa='" + Dep + "' ";

                adapt = new MySqlDataAdapter(Query, Con);

                adapt.Fill(dt);
                GV_QueRes.DataSource = dt;
                Con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void countAttenties()
        {
            int count;
            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;

                string Identity = Form1.disDepart;
                Con.Open();
                String Query_DisplayNum = "SELECT COUNT(Stu_RegiNum) FROM tbl_marks WHERE Stu_Depa LIKE @Identity";
                cmd = new MySqlCommand(Query_DisplayNum, Con);

                // Add a parameter for the LIKE condition
                cmd.Parameters.AddWithValue("@Identity", $"{Identity}%");
                count = Convert.ToInt32(cmd.ExecuteScalar());
                
                lbl_NumAtt.Text = count.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void StudentsResult_Load(object sender, EventArgs e)
        {
            countAttenties();        
            txt_StuRegiNum.Text = string.Empty;
            CB_Qset.SelectedIndex = -1;
            DisplayData();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            countAttenties();
            txt_StuRegiNum.Text = string.Empty;
            CB_Qset.SelectedIndex = -1;
            DisplayData();
        }

        private void btn_PrintStuRes_Click(object sender, EventArgs e)
        {
            string Depa = Form1.disDepart;
            string title = Depa + " Program Students Quiz Results";

            DGVPrinter print = new DGVPrinter();
            print.Title = title;
            print.SubTitle = "Date :" + DateTime.Now.ToShortDateString();
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "ATI BATTICALOA" +
                "Srilankan Advanced Technological Institute";
            print.FooterSpacing = 15;
            print.PrintDataGridView(GV_QueRes);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String Dep = Form1.disDepart;
            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;
                MySqlDataAdapter adapt;

                string Identity = Dep;

                Con.Open();
                DataTable dt = new DataTable();
                String Query = "select Stu_RegiNum,`Mark_Set1` as 'Quiz SET 01', `Mark_Set2` as 'Quiz SET 02', `Mark_Set3` as 'Quiz SET 03', `Mark_Set4` as 'Quiz SET 04', `Mark_Set5`  as 'Quiz SET 05', `Mark_Set6` as 'Quiz SET 06'  from tbl_marks where Stu_Depa='" + Identity + "' &&  Stu_RegiNum = '" + txt_StuRegiNum.Text + "' ";

                adapt = new MySqlDataAdapter(Query, Con);

                adapt.Fill(dt);
                GV_QueRes.DataSource = dt;
                Con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       
        private void CB_Qset_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string TemQset;
            string TemDte;
            String Dep = Form1.disDepart;
           
            
            if(CB_Qset.SelectedIndex == 0)
            {
               

                try
                {
                    MySqlConnection Con = new MySqlConnection(SQLCon);
                    MySqlCommand cmd;
                    MySqlDataReader dr;
                    MySqlDataAdapter adapt;



                    Con.Open();
                    DataTable dt = new DataTable();
                    String Query = "select Stu_RegiNum, Mark_Set1 as 'Quiz SET 01', Date_Mrk1 from tbl_marks where Stu_Depa='" + Dep + "' ";

                    adapt = new MySqlDataAdapter(Query, Con);

                    adapt.Fill(dt);
                    GV_QueRes.DataSource = dt;
                    Con.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
           else  if (CB_Qset.SelectedIndex == 1)
            {

                try
                {
                    MySqlConnection Con = new MySqlConnection(SQLCon);
                    MySqlCommand cmd;
                    MySqlDataReader dr;
                    MySqlDataAdapter adapt;



                    Con.Open();
                    DataTable dt = new DataTable();
                    String Query = "select Stu_RegiNum, Mark_Set2 as 'Quiz SET 02', Date_Mrk2 from tbl_marks where Stu_Depa='" + Dep + "' ";

                    adapt = new MySqlDataAdapter(Query, Con);

                    adapt.Fill(dt);
                    GV_QueRes.DataSource = dt;
                    Con.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (CB_Qset.SelectedIndex == 2)
            {

                try
                {
                    MySqlConnection Con = new MySqlConnection(SQLCon);
                    MySqlCommand cmd;
                    MySqlDataReader dr;
                    MySqlDataAdapter adapt;



                    Con.Open();
                    DataTable dt = new DataTable();
                    String Query = "select Stu_RegiNum, Mark_Set3 as 'Quiz SET 03', Date_Mrk3 from tbl_marks where Stu_Depa='" + Dep + "' ";

                    adapt = new MySqlDataAdapter(Query, Con);

                    adapt.Fill(dt);
                    GV_QueRes.DataSource = dt;
                    Con.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (CB_Qset.SelectedIndex == 3)
            {

                try
                {
                    MySqlConnection Con = new MySqlConnection(SQLCon);
                    MySqlCommand cmd;
                    MySqlDataReader dr;
                    MySqlDataAdapter adapt;



                    Con.Open();
                    DataTable dt = new DataTable();
                    String Query = "select Stu_RegiNum, Mark_Set4 as 'Quiz SET 04', Date_Mrk4 from tbl_marks where Stu_Depa='" + Dep + "' ";

                    adapt = new MySqlDataAdapter(Query, Con);

                    adapt.Fill(dt);
                    GV_QueRes.DataSource = dt;
                    Con.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (CB_Qset.SelectedIndex == 4)
            {

                try
                {
                    MySqlConnection Con = new MySqlConnection(SQLCon);
                    MySqlCommand cmd;
                    MySqlDataReader dr;
                    MySqlDataAdapter adapt;



                    Con.Open();
                    DataTable dt = new DataTable();
                    String Query = "select Stu_RegiNum, Mark_Set5 as 'Quiz SET 05', Date_Mrk5 from tbl_marks where Stu_Depa='" + Dep + "' ";

                    adapt = new MySqlDataAdapter(Query, Con);

                    adapt.Fill(dt);
                    GV_QueRes.DataSource = dt;
                    Con.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (CB_Qset.SelectedIndex == 5)
            {

                try
                {
                    MySqlConnection Con = new MySqlConnection(SQLCon);
                    MySqlCommand cmd;
                    MySqlDataReader dr;
                    MySqlDataAdapter adapt;



                    Con.Open();
                    DataTable dt = new DataTable();
                    String Query = "select Stu_RegiNum, Mark_Set6 as 'Quiz SET 06', Date_Mrk6 from tbl_marks where Stu_Depa='" + Dep + "' ";

                    adapt = new MySqlDataAdapter(Query, Con);

                    adapt.Fill(dt);
                    GV_QueRes.DataSource = dt;
                    Con.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DisplayData();
            }

           


           
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (CB_Qset.SelectedIndex == -1)
            {
                try
                {
                    MySqlConnection Con = new MySqlConnection(SQLCon);
                    MySqlCommand cmd;
                    MySqlDataReader dr;
                    MySqlDataAdapter adapt;



                    Con.Open();
                    DataTable dt = new DataTable();
                    string Query = "UPDATE tbl_marks SET " +
                                "Mark_Set1='0', Mark_Set2='0', Mark_Set3='0', Mark_Set4='0', Mark_Set5='0', Mark_Set6='0', " +
                                "Date_Mrk1='', Date_Mrk2='', Date_Mrk3='', Date_Mrk4='', Date_Mrk5='', Date_Mrk6='', " +
                                "Result_mrk1='', Result_mrk2='', Result_mrk3='', Result_mrk4='', Result_mrk5='', Result_mrk6='' " +
                                "WHERE Stu_RegiNum = '" + txt_StuRegiNum.Text + "'";




                    cmd = new MySqlCommand(Query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student result restore Successfully", "Restored Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Con.Close();
                    DisplayData();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("You can't restore seperate Question Set result", "Restored Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }

        private void GV_QueRes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_StuRegiNum.Text = GV_QueRes.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
