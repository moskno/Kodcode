using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shabbat
{
    public partial class Frm1Hoster : Form
    {
        public Frm1Hoster()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm1Hoster_Load(object sender, EventArgs e)
        {
            List<string> categories = Host_Manager.GetCategories();
            for (int i = 0; i < categories.Count();i++)
            {
                lbxCtgr.Items.Add(categories[i]);
            }
            
            lbxCtgr.DoubleClick += (Sender, E) =>
            {
                string selectedItem = lbxCtgr.SelectedItem.ToString();
                if (selectedItem == "") return;
                txtCtgr.Text = selectedItem;
            };


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            List<Frm2OrderList> forms = new List<Frm2OrderList>();
            List<string> categories = Host_Manager.GetCategories();
            for (int i = 0; i < categories.Count(); i++)
            {
                forms.Add(new Frm2OrderList(forms, i, categories[i]));
            }
            forms.First().Show();
        }

        private void btnAddCtgr_Click(object sender, EventArgs e)
        {
            Host_Manager.AddCtgr(txtCtgr.Text); 
            List<string> categorie = Host_Manager.GetCategories();
            int i =0;
            lbxCtgr.Items.Clear();
            while (i < categorie.Count())
            {
                lbxCtgr.Items.Add(categorie[i]);
                i++;
            }
            txtCtgr.Text = null;

        }

        private void txtCtgr_TextChanged(object sender, EventArgs e)
        {
            List<string> categories = Host_Manager.GetCtgrByString(txtCtgr.Text);
            lbxCtgr.Items.Clear();
            for (int i = 0;i < categories.Count(); i++)
            {
                lbxCtgr.Items.Add(categories[i]);
            }

        }

        private void btnDeleteCtgr_Click(object sender, EventArgs e)
        {

        }

        private void lbxCtgr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
