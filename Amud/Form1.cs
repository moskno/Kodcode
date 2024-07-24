using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int height = int.Parse(txtHeight.Text);
            int width = int.Parse(txtWidth.Text); 
            
            Pillar pillar = new Pillar (height, width, txtcomboPlach.Text);

            txtResult.Text = pillar.GetStatus();
        }
    }
}
