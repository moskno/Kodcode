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
    public partial class Frm3Guest : Form
    {
        public Frm3Guest()
        {
            InitializeComponent();
        }

        private void Frm3Guest_Load(object sender, EventArgs e)
        {
            List<string> guest = Guest_Manager.GetGuests();
            for (int i = 0; i < guest.Count; i++)
            {
                lbxGst.Items.Add(guest[i]);
            }

            lbxGst.DoubleClick += (Sender, E) =>
            {
                string selectedItem = lbxGst.SelectedItem.ToString();
                if (selectedItem == "") return;
                txtGstName.Text = selectedItem;
            };
        }

        private void btnAddGst_Click(object sender, EventArgs e)
        {
            Guest_Manager.AddGst(txtGstName.Text);
            List<string> guest = Guest_Manager.GetGuests();
            int i = 0;
            lbxGst.Items.Clear();
            while (i < guest.Count())
            {
                lbxGst.Items.Add(guest[i]);
                i++;
            }
            txtGstName.Text = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtGstName_TextChanged(object sender, EventArgs e)
        {
            List<string> guests = Guest_Manager.GetGstByString(txtGstName.Text);
            lbxGst.Items.Clear();
            for (int i = 0; i < guests.Count(); i++)
            {
                lbxGst.Items.Add(guests[i]);
            }
        }
    }
}
