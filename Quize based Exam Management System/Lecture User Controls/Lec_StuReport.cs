using DGVPrinterHelper;
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

namespace Quize_based_Exam_Management_System.Lecture_User_Controls
{
    public partial class Lec_StuReport : UserControl
    {
        public Lec_StuReport()
        {
            InitializeComponent();
        }

        string SQLCon = "server=localhost;database=quizems;uid=root;pwd=''";

        private void count()
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

                lbl_TSC.Text = count.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Lec_StuReport_Load(object sender, EventArgs e)
        {
            count();
            String Dep = Form1.disDepart;

            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;
                MySqlDataAdapter adapt;



                Con.Open();
                DataTable dt = new DataTable();
                String Query = "select `Stu_RegiNum`, `Result_mrk1` as 'SET 01 Result', `Result_mrk2` as 'SET 02 Result', `Result_mrk3` as 'SET 03 Result', `Result_mrk4` as 'SET 04 Result', `Result_mrk5` as 'SET 05 Result', `Result_mrk6` as 'SET 06 Result" +
                    "' from tbl_marks where Stu_Depa='" + Dep + "' ";

                adapt = new MySqlDataAdapter(Query, Con);

                adapt.Fill(dt);
                GV_StuResult.DataSource = dt;
                Con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            string Depa = Form1.disDepart;
            string title = Depa + " Program Students Quiz Report";
          //  string text = ";

            DGVPrinter print = new DGVPrinter();
            print.Title = title;
            print.SubTitle = "Date :" + DateTime.Now.ToShortDateString();
            print.SubTitle = "Total count of Students is "+ lbl_TSC.Text;
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "ATI BATTICALOA" +
                "Srilankan Advanced Technological Institute";
            print.FooterSpacing = 15;
            print.PrintDataGridView(GV_StuResult);
        }
    }
}
