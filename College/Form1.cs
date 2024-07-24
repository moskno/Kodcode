using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace College
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntr_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPass.Text;

            bool userExists = Student_Manager.CheckUserExistence(name, password);

            if (userExists)
            {
                Form2 form2 = new Form2(txtName.Text);
                form2.ShowDialog();
                this.Hide();
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
