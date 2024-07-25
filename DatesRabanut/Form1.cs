using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace DatesRabanut
{
    public partial class Form1 : Form
    {
        private DatesManager datesManager;
        public Form1()
        {
            InitializeComponent();
            XmlDocument datesDocument = ProgramXml.Main();
            datesManager = new DatesManager(datesDocument);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            List<string> dates = new List<string>()
            {
                cmbWeekDay.Text,
                cmbMonthDay.Text,
                cmbMonth.Text,
                cmbYear.Text
            };

            datesManager.AddDate(dates);
            ProgramXml.Save(datesManager.GetDocument());

            txtDateView.Text = datesManager.GetFormattedDates();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDateView_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
