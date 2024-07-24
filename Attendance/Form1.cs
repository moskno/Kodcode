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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPass_TextChanged(object sender, EventArgs e) { }
   

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            
            {
                string result = EmployeeManager.Login(txtPass.Text, txtId.Text);
                
                MessageBox.Show(result);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
            this.Hide();
        }
    }
}
