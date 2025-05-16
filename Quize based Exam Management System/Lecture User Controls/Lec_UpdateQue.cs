using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize_based_Exam_Management_System.Lecture
{
    public partial class Lec_UpdateQue : UserControl
    {
        public Lec_UpdateQue()
        {
            InitializeComponent();
        }

        string SQLCon = "server=localhost;database=quizems;uid=root;pwd=''";

        private void ClearAll()
        {
            txt_optionA.Text = string.Empty;
            txt_optionB.Text = string.Empty;
            txt_optionC.Text = string.Empty;
            txt_optionD.Text = string.Empty;
            txt_question.Text = string.Empty;
            Combo_Answer.SelectedIndex = -1;
            lbl_Qnum.Text = "00";

        }

        private void Display()
        {
            String QSet = Combo_Qset.Text;
            string Depart = Form1.disDepart;
            string Identity = Depart + QSet;

            try
            {
                using (MySqlConnection con = new MySqlConnection(SQLCon))
                {
                    con.Open();

                    DataTable dt = new DataTable();
                    string query = "SELECT Que_Set, Que_Num, Que_Question, Que_OptA, Que_OptB, Que_OptC, Que_OptD, Que_Ans FROM tbl_quiz WHERE Que_ID LIKE @Identity";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Identity", $"{Identity}%");

                        using (MySqlDataAdapter adapt = new MySqlDataAdapter(cmd))
                        {
                            adapt.Fill(dt);
                            GridView_Que.DataSource = dt;
                        }
                    }
                } // The connection will be automatically closed here

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void btn_update_Click(object sender, EventArgs e)
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
            String Depa = Form1.disDepart;
            string ID = Depa + Combo_Qset.Text + lbl_Qnum.Text;

            string Ans = Answer;
            string Que = txt_question.Text;
            string opA = txt_optionA.Text;
            string opB = txt_optionB.Text;
            string opC = txt_optionC.Text;
            string opD = txt_optionD.Text;
            
           

            MySqlConnection Con = new MySqlConnection(SQLCon);
            MySqlCommand cmd;
            MySqlDataReader dr;
            MySqlDataAdapter adapt;

            try
            {

                Con.Open();

                string UptQue = "UPDATE tbl_quiz SET Que_Question='" + Que + "',Que_OptA='"+opA+ "',Que_OptB='"+opB+ "', Que_OptC='"+opC+ "',Que_OptD='"+opD+ "',Que_Ans='"+Ans+"' WHERE Que_ID='" + ID + "' ";
                cmd = new MySqlCommand(UptQue, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully", "Update Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ClearAll();
                Display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Lec_UpdateQue_Load(object sender, EventArgs e)
        {
            Display();        
            lbl_Department.Visible=false;
           
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Display();
            ClearAll();
            Combo_Qset.SelectedIndex = -1;
        }

        private void GridView_Que_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                Combo_Qset.Text = GridView_Que.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbl_Qnum.Text = GridView_Que.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_question.Text = GridView_Que.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_optionA.Text = GridView_Que.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_optionB.Text = GridView_Que.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_optionC.Text = GridView_Que.Rows[e.RowIndex].Cells[5].Value.ToString(); // Corrected index
                txt_optionD.Text = GridView_Que.Rows[e.RowIndex].Cells[6].Value.ToString(); // Corrected index

                string opAns = GridView_Que.Rows[e.RowIndex].Cells[7].Value.ToString(); // Corrected index

                // Assuming that opAns is a string, you can compare it directly

                if (opAns == txt_optionA.Text)
                {
                    Combo_Answer.SelectedIndex = 0;
                }
                else if (opAns == txt_optionB.Text)
                {
                    Combo_Answer.SelectedIndex = 1;
                }
                else if (opAns == txt_optionC.Text)
                {
                    Combo_Answer.SelectedIndex = 2;
                }
                else if (opAns == txt_optionD.Text)
                {
                    Combo_Answer.SelectedIndex = 3;
                }
                else
                {
                    Combo_Answer.SelectedIndex = -1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
           


        }

        private void Combo_Qset_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            String Depa = Form1.disDepart;
            string ID = Depa + Combo_Qset.Text + lbl_Qnum.Text;

            try
            {
                MySqlConnection Con = new MySqlConnection(SQLCon);
                MySqlCommand cmd;
                MySqlDataReader dr;

                Con.Open();
                string Delete_Query = "DELETE FROM tbl_quiz WHERE Que_ID='"+ID+"';";
                cmd = new MySqlCommand(Delete_Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Question Deleted Succesfully","Deleted Sucessfully",MessageBoxButtons.OK,MessageBoxIcon.Question);
                Display();
                ClearAll();
                
                
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message,"Warning", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
        }
    }
}
