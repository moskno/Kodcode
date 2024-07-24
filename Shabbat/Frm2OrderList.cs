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
    public partial class Frm2OrderList : Form
    {
        public List<Frm2OrderList> Forms2;
        public int Possition;
        public Frm2OrderList(List<Frm2OrderList> forms2, int possition, string CategoryName)
        {
            InitializeComponent();
            Forms2 = forms2;
            Possition = possition;
            lblCtgrName.Text = CategoryName;
        }

        private void Frm2OrderList_Load(object sender, EventArgs e)
        {
            dgvOrdrLst.DataSource = Host_Manager.GetFoodByCtgr(lblCtgrName.Text);
        }

        private void btnRightCtgr_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (Possition < Forms2.Count() - 1)
            {
                Forms2[Possition + 1].Visible = true;
            }
            else
            {
                Forms2[0].Visible = true;
            }
        }

        private void btnLeftCtgr_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (Possition < Forms2.Count() && Possition > 0)
            {
                Forms2[Possition - 1].Visible = true;
            }
            else
            {
                Forms2[Forms2.Count() - 1].Visible = true;
            }
        }

        private void dgvOrdrLst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
