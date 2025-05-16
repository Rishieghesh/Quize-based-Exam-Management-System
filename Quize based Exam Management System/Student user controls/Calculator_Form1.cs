using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize_based_Exam_Management_System.Student_user_controls
{
    public partial class Calculator : Form
    {

        double FirstNumber;
        string Operation;
        public Calculator()
        {
            
            InitializeComponent();
        }

        private void nul1_Click(object sender, EventArgs e)
        {
            if (txt_nums.Text == "0" && txt_nums.Text != null)
            {
                txt_nums.Text = "1";
            }
            else
            {
                txt_nums.Text = txt_nums.Text + "1";
            }
        }

        private void nul2_Click(object sender, EventArgs e)
        {
            if (txt_nums.Text == "0" && txt_nums.Text != null)
            {
                txt_nums.Text = "2";
            }
            else
            {
                txt_nums.Text = txt_nums.Text + "2";
            }
        }

        private void nul3_Click(object sender, EventArgs e)
        {
            if (txt_nums.Text == "0" && txt_nums.Text != null)
            {
                txt_nums.Text = "3";
            }
            else
            {
                txt_nums.Text = txt_nums.Text + "3";
            }
        }

        private void nul4_Click(object sender, EventArgs e)
        {
            if (txt_nums.Text == "0" && txt_nums.Text != null)
            {
                txt_nums.Text = "4";
            }
            else
            {
                txt_nums.Text = txt_nums.Text + "4";
            }
        }

        private void nul5_Click(object sender, EventArgs e)
        {
            if (txt_nums.Text == "0" && txt_nums.Text != null)
            {
                txt_nums.Text = "5";
            }
            else
            {
                txt_nums.Text = txt_nums.Text + "5";
            }
        }

        private void nul6_Click(object sender, EventArgs e)
        {
            if (txt_nums.Text == "0" && txt_nums.Text != null)
            {
                txt_nums.Text = "6";
            }
            else
            {
                txt_nums.Text = txt_nums.Text + "6";
            }
        }

        private void nul7_Click(object sender, EventArgs e)
        {
            if (txt_nums.Text == "0" && txt_nums.Text != null)
            {
                txt_nums.Text = "7";
            }
            else
            {
                txt_nums.Text = txt_nums.Text + "7";
            }
        }

        private void nul8_Click(object sender, EventArgs e)
        {
            if (txt_nums.Text == "0" && txt_nums.Text != null)
            {
                txt_nums.Text = "8";
            }
            else
            {
                txt_nums.Text = txt_nums.Text + "8";
            }
        }

        private void nul9_Click(object sender, EventArgs e)
        {
            if (txt_nums.Text == "0" && txt_nums.Text != null)
            {
                txt_nums.Text = "9";
            }
            else
            {
                txt_nums.Text = txt_nums.Text + "9";
            }
        }

        private void nul0_Click(object sender, EventArgs e)
        {
           txt_nums.Text = txt_nums.Text + "0";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_nums.Text);
            txt_nums.Text = "0";
            Operation = "+";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_nums.Text);
            txt_nums.Text = "0";
            Operation = "-";
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_nums.Text);
            txt_nums.Text = "0";
            Operation = "*";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_nums.Text);
            txt_nums.Text = "0";
            Operation = "/";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            
            txt_nums.Text = txt_nums.Text + ".";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_nums.Text= String.Empty;
            
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(txt_nums.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                txt_nums.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                txt_nums.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                txt_nums.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txt_nums.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    txt_nums.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
             }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_nums_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
