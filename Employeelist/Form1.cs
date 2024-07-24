using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employeelist
{
    public partial class Form1 : Form
    {
        private Employee[] Employees = new Employee[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageShow_TextChanged(object sender, EventArgs e)
        {
        }

        private void codeNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlMale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncMariad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncSingel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncEx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncAlman_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdittion_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(int.Parse(txtCode.Text), txtId.Text, txtName.Text, txtFname.Text, dateTimePicker1.Value, rbtMale.Checked, GetStatus(), txtPhone.Text, txtMobilePhone.Text, txtCity.Text, txtStreet.Text, int.Parse(txtHouseNum.Text));
            if (Employees[Employees.Length - 1] == null) {
                Employees[Employees.Length - 1] = employee;

            Employee[] tmp = new Employee[Employees.Length + 1];
                for (int i = 0; i < Employees.Length; i++)
                {
                    tmp[i] = Employees[i];
                }

                    txtMobilePhone[i] = Employees;

            }

        //private string GetMale()
        //{
        //    if (rbtMale.Checked == true)
        //    {
        //        return rbtMale.Text;
        //    }
        //    else if (rbtFemale.Checked == true)
        //    {
        //        return rbtFemale.Text;
        //    }  
        //    else { return string.Empty; }   
        //}
            private string GetStatus()
            {
                if (rbtSingel.Checked == true) { return rbtSingel.Text; }
                if (rbtMariad.Checked == true) { return rbtMariad.Text; }
                if (rbtEx.Checked == true) { return rbtEx.Text; }
                if (rbtAlman.Checked == true) { return rbtAlman.Text; }
                else { return string.Empty; }
            }




        }
    } }
