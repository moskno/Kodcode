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
    public partial class FrmLearning : Form
    {
        public FrmLearning()
        {
            InitializeComponent();
        }

        private void FrmLearning_Load(object sender, EventArgs e)
        {
            string sql = "select count (*) from Attendances";
            string result = DBConnection.runSQL(sql);
            MessageBox.Show(result);

        }
    }
}
