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
using System.Web;
using System.Windows.Forms;

namespace Quize_based_Exam_Management_System.Lecture_User_Controls
{
    public partial class Lec_StuDetails : UserControl
    {
        public Lec_StuDetails()
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

                string Identity = Dep;

                Con.Open();
                DataTable dt = new DataTable();
                String Query = "select Stu_RegNum, Stu_FullName,Stu_MobNum,Stu_Gender,Stu_NIC,Stu_Gmail from tbl_student where Department='" + Identity + "'";

                adapt = new MySqlDataAdapter(Query, Con);

                adapt.Fill(dt);
                GridView_StuDeatils.DataSource = dt;
                Con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAll()
        {
            txt_StuRegiNum.Text = string.Empty;
            txt_FullName.Text = string.Empty;
            txt_gmail.Text = string.Empty;
            txt_MoNum.Text = string.Empty;
            txt_Nic.Text = string.Empty;
            CB_Gender.SelectedIndex = -1;
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            string Name = txt_FullName.Text;
            string Num = txt_MoNum.Text;
            string gmail = txt_gmail.Text;
            string NIC = txt_Nic.Text;
            string RegiNum = txt_StuRegiNum.Text;
            string Gender = CB_Gender.Text;

            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;

                Con.Open();
                string QueryUp = "UPDATE tbl_student SET Stu_FullName ='" + Name + "' , Stu_MobNum='" + Num + "', Stu_NIC ='" + NIC + "', Stu_Gender ='" + Gender + "',Stu_Gmail ='"+gmail+"'  WHERE Stu_RegNum = '" + RegiNum + "';   ";
                cmd = new MySqlCommand(QueryUp, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student detail updated Sucessfully!", "Reset Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Lec_StuDetails_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void GridView_StuDeatils_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_StuRegiNum.Text = GridView_StuDeatils.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_FullName.Text = GridView_StuDeatils.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_gmail.Text = GridView_StuDeatils.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_MoNum.Text = GridView_StuDeatils.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_Nic.Text = GridView_StuDeatils.Rows[e.RowIndex].Cells[4].Value.ToString();
                CB_Gender.Text = GridView_StuDeatils.Rows[e.RowIndex].Cells[3].Value.ToString();

                string cellValue = GridView_StuDeatils.Rows[e.RowIndex].Cells[3].Value.ToString();

                // Convert the cell value to an integer (assuming it's an integer)
                if (cellValue == "Male")
                {
                    // Set the selected index of the ComboBox
                    CB_Gender.SelectedIndex = 1;
                }
                else
                {
                    CB_Gender.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string RegiNum = txt_StuRegiNum.Text;


            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;

                Con.Open();
                string DeleQuery = "DELETE FROM tbl_student WHERE Stu_RegNum = '" + RegiNum + "';";

                cmd = new MySqlCommand(DeleQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student detail Deleted Sucessfully!", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DisplayData();
            ClearAll();
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
                String Query = "select Stu_FullName,Stu_MobNum,Stu_Gender,Stu_NIC,Stu_Gmail from tbl_student where Department='" + Identity + "' && Stu_RegNum = '"+txt_StuRegiNum.Text+"' ";

                adapt = new MySqlDataAdapter(Query, Con);

                adapt.Fill(dt);
                GridView_StuDeatils.DataSource = dt;
                Con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            string Depa =Form1.disDepart;
            string title = Depa + " Program Students - ATI Batticaloa";

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
            print.PrintDataGridView(GridView_StuDeatils);
        }
    }
}
