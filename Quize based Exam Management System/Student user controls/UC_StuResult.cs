using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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

namespace Quize_based_Exam_Management_System.Student_user_controls
{
    public partial class UC_StuResult : UserControl
    {
        public UC_StuResult()
        {
            InitializeComponent();
        }

        string SQLCon = "server=localhost;database=quizems;uid=root;pwd=''";

        private void emg()
        {
            Res_Qu1_Result.Visible= false;
            Res_Qu2_Result.Visible= false;
            Res_Qu3_Result.Visible= false;
            Res_Qu4_Result.Visible= false;
            Res_Qu5_Result.Visible= false;
            Res_Qu6_Result.Visible= false;

        }
            

        private void UC_StuResult_Load(object sender, EventArgs e)
        {
            

              try
              {
                  MySqlConnection conn = new MySqlConnection(SQLCon);
                  MySqlCommand cmd;
                  MySqlDataReader row;

                  conn.Open();
                String Query = "Select * From tbl_marks where Stu_RegiNum=@Username";

                cmd = new MySqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@Username", Form1.disStu);
                
                row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        Res_Qu1_Marks.Text = row[2].ToString();
                        Res_Qu2_Marks.Text = row[3].ToString();
                        Res_Qu3_Marks.Text = row[4].ToString();
                        Res_Qu4_Marks.Text = row[5].ToString();
                        Res_Qu5_Marks.Text = row[6].ToString();
                        Res_Qu6_Marks.Text = row[7].ToString();

                        Res_Qu1_Gra.Text = row[14].ToString();
                        Res_Qu2_Gra.Text = row[15].ToString();
                        Res_Qu3_Gra.Text = row[16].ToString();
                        Res_Qu4_Gra.Text = row[17].ToString();
                        Res_Qu5_Gra.Text = row[18].ToString();
                        Res_Qu6_Gra.Text = row[19].ToString();

                        if(Res_Qu1_Gra.Text=="E"|| Res_Qu1_Gra.Text=="D"|| Res_Qu1_Gra.Text == "D+")
                        {
                            Res_Qu1_Result.Text = "Failed";
                        }
                        else if(Res_Qu1_Gra.Text==string.Empty)
                        {
                            Res_Qu1_Result.Text = "Pending";
                        }
                        else
                        {
                            Res_Qu1_Result.Text = "Pass";
                        }


                        if (Res_Qu2_Gra.Text == "E" || Res_Qu2_Gra.Text == "D" || Res_Qu2_Gra.Text == "D+")
                        {
                            Res_Qu2_Result.Text = "Failed";
                        }
                        else if  (Res_Qu2_Gra.Text == string.Empty)
                        {
                            Res_Qu2_Result.Text = "Pending";
                        }
                        else
                        {
                            Res_Qu2_Result.Text = "Pass";
                        }


                        if (Res_Qu3_Gra.Text == "E" || Res_Qu3_Gra.Text == "D" || Res_Qu3_Gra.Text == "D+")
                        {
                            Res_Qu3_Result.Text = "Failed";
                        }
                        else if (Res_Qu3_Gra.Text == string.Empty)
                        {
                            Res_Qu3_Result.Text = "Pending";
                        }
                        else
                        {
                            Res_Qu3_Result.Text = "Pass";
                        }


                        if (Res_Qu4_Gra.Text == "E" || Res_Qu4_Gra.Text == "D" || Res_Qu4_Gra.Text == "D+")
                        {
                            Res_Qu4_Result.Text = "Failed";
                        }
                        else if (Res_Qu4_Gra.Text == string.Empty)
                        {
                            Res_Qu4_Result.Text = "Pending";
                        }
                        else
                        {
                            Res_Qu4_Result.Text = "Pass";
                        }


                        if (Res_Qu5_Gra.Text == "E" || Res_Qu5_Gra.Text == "D" || Res_Qu5_Gra.Text == "D+")
                        {
                            Res_Qu5_Result.Text = "Failed";
                        }
                        else if (Res_Qu5_Gra.Text == string.Empty)
                        {
                            Res_Qu5_Result.Text = "Pending";
                        }
                        else
                        {
                            Res_Qu5_Result.Text = "Pass";
                        }


                        if (Res_Qu6_Gra.Text == "E" || Res_Qu6_Gra.Text == "D" || Res_Qu6_Gra.Text == "D+")
                        {
                            Res_Qu6_Result.Text = "Failed";
                        }
                        else if (Res_Qu6_Gra.Text == string.Empty)
                        {
                            Res_Qu6_Result.Text = "Pending";
                        }
                        else
                        {
                            Res_Qu6_Result.Text = "Pass";
                        }
                    }


                }

            }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }

           
        }
    }
}
