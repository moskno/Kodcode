using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        private DrinksManager drinksManager;
        public Form1()
        {
            InitializeComponent();
            XmlDocument drinksDocument = MainProject.Main();
            drinksManager = new DrinksManager(drinksDocument);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<List<string>> drinkslist = drinksManager.GetDrinksData();
            foreach(List<string> drink in drinkslist)
            {
                dgvList.Rows.Add(drink.ToArray());
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> drinks = new List<string>()
            {
                txtDrink.Text,
                cmbSugar.Text,
                cmbCoffee.Text,
                cmbMilk.Text,
                cmbCacao.Text,
                txtPrice.Text
            };
            drinksManager.AddDrink(drinks);
            dgvList.Rows.Add(drinks.ToArray());

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtPrice.Text = (float.Parse(txtPrice.Text)+0.5).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (float.Parse(txtPrice.Text) > 0.5)
            txtPrice.Text = (float.Parse(txtPrice.Text) - 0.5).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            drinksManager.Save();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDrink_TextChanged(object sender, EventArgs e)
        {
            List<string> drinks = drinksManager.GetDrinkByName(txtDrink.Text);
            if (drinks == null) return;
            DialogResult showDialog = MessageBox.Show("האם ברצונך לעדכן?","עדכן משקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (showDialog == DialogResult.Yes)
            {
                cmbSugar.Text = drinks[1];
                cmbCoffee.Text = drinks[2];
                cmbMilk.Text = drinks[3];
                cmbCacao.Text = drinks[4];
                txtPrice.Text = drinks[5];
                btnUpdate.Visible = true;
                btnAdd.Visible = false;
            }
            if (showDialog == DialogResult.No)
            {
                btnDelete.Visible = true;
                btnAdd.Visible = false;
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> drinks = new List<string>()
            {
                txtDrink.Text,
                cmbSugar.Text,
                cmbCoffee.Text,
                cmbMilk.Text,
                cmbCacao.Text,
                txtPrice.Text
            };
            drinksManager.UpdateDrink(drinks);
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            dgvList.Rows.Clear();
            List<List<string>> drinkslist = drinksManager.GetDrinksData();
            foreach (List<string> drink in drinkslist)
            {
                dgvList.Rows.Add(drink.ToArray());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            string drink = txtDrink.Text;
            //drinksManager.DeleteDrink();
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
