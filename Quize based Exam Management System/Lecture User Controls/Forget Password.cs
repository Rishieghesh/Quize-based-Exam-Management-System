using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize_based_Exam_Management_System.Lecture
{
    public partial class Forget_Password : Form
    {
        public Forget_Password()
        {
            InitializeComponent();
        }

        private void btn_Con_Click(object sender, EventArgs e)
        {
            pnl_ResetPass.Visible = true;
        }

        private void Forget_Password_Load(object sender, EventArgs e)
        {
            pnl_ResetPass.Visible=false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
          this.Hide();
          Form1 frm =new Form1();
            frm.Show();
        }
    }
}
