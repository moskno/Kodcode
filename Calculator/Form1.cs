using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private TextBox selectedTextBox;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            //1. Convert 'string' to 'int'
            float num1 = float.Parse(txtNumber1.Text);
            float num2 = float.Parse(txtNumber2.Text);

            //2. Validate inputs


            //3. Perform calculation
            switch (cmbOperator.Text)
            {
                case "+":
                    lblResult.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    lblResult.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    lblResult.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    // - check that txtnumbers2 is not 0
                    if (num2 == 0)
                    {
                        MessageBox.Show("Impossible to divide by 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    lblResult.Text = (num1 / num2).ToString();
                    break;
            }
            




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumber1_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }

        private void txtNumber2_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;

        }


        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {

        }


        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_Click_Global(object sender, EventArgs e)
        {
            selectedTextBox.Text += ((Button)sender).Text;
        }

        private void btn_Operator_Global(object sender, EventArgs e)
        {
            cmbOperator.Text += ((Button)sender).Text;
        }


    }
}
