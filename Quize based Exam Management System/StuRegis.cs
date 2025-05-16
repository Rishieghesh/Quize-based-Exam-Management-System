using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Windows.Input;

using Quize_based_Exam_Management_System;
using MySql.Data.MySqlClient;

namespace New_User_Form
{
    public partial class StuRegis : Form
    {
        public StuRegis()
        {
            InitializeComponent();
        }

        string SQLCon = "server=localhost;database=quizems;uid=root;pwd=''";

        private void Hideall()
        {
            txt_Fname.Visible= false; 
            txt_Gmail.Visible = false;
            txt_Lname.Visible = false;
            txt_Nic.Visible = false; 
            txt_PassC.Visible = false;
            txt_Phone.Visible = false;
            txt_ReNumber.Visible = false;
            Combo_Department.Visible = false;
            Combo_Gender.Visible = false;
        }

        private void Showall()
        {
            txt_Fname.Visible = true;
            txt_Gmail.Visible = true;
            txt_Lname.Visible = true;
            txt_Nic.Visible = true;
            txt_PassC.Visible = true;
            txt_Phone.Visible = true;
            txt_ReNumber.Visible = true;
            Combo_Department.Visible = true;
            Combo_Gender.Visible = true;
        }

        private void btn_StuRegister_Click(object sender, EventArgs e)
        {
           

                String RegNo = txt_ReNumber.Text;
                String FullName = txt_Fname.Text+txt_Lname.Text;
                String Department = Combo_Department.Text;
                String Phone = txt_Phone.Text;
                String Gmail = txt_Gmail.Text;
                String Nic = txt_Nic.Text;
                String Password = txt_PassC.Text;        

                       
           try
            {
               if( txt_Fname.Text == String.Empty || txt_Gmail.Text == String.Empty
                    || txt_Lname.Text == String.Empty
                    || txt_Nic.Text == String.Empty
                    || txt_PassC.Text == String.Empty
                    || txt_Phone.Text == String.Empty
                    || txt_ReNumber.Text == String.Empty
                    || Combo_Department.SelectedIndex == -1
                    || Combo_Gender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill the full form", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

               else if(txt_ReNumber.Text.Substring(0, 3) == "BAT/")
                {
                    MessageBox.Show("Invalid Student Register ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txt_Phone.Text.Substring(0, 3) == "+947" || txt_Phone.Text.Length!=12)
                {
                    MessageBox.Show("Invalid Student Register ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
                                
               else if (txt_PassC.Text == txt_PassP.Text) 
                {
                    Hideall();
                    



                }
                else
                {
                    MessageBox.Show("System will not Accept your form", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SystemException exp)
            {
                MessageBox.Show("Some Error Occured at User Registration : " + exp.ToString(),"Error Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            
        }
         private void FormClear()
        {
            this.txt_Fname.Text = String.Empty;
            this.txt_Gmail.Text = String.Empty;
            this.txt_Lname.Text = String.Empty;
            this.txt_Nic.Text = String.Empty;
            this.txt_PassC.Text = String.Empty;
            this.txt_Phone.Text = String.Empty;
            this.txt_ReNumber.Text = String.Empty;
            this.Combo_Department.SelectedIndex = -1;
            this.Combo_Gender.SelectedIndex = -1;
            

        }
 

       

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StuRegis_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
