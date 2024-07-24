using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = EmployeeManager.ChangePassword(txtID.Text, txtOldPass.Text, txtNewPass.Text, txtNewPassAgain.Text);

            MessageBox.Show(result); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == (Char)Keys.Enter)

                {
                    string result = EmployeeManager.ChangePassword(txtID.Text, txtOldPass.Text, txtNewPass.Text, txtNewPassAgain.Text);

                    MessageBox.Show(result);
                }
            }
        }
    }
}
