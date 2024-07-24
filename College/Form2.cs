using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string student;

        public Form2(string student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> courses = Student_Manager.GetCourses();
            for (int i = 0; i < courses.Count(); i++)
            {
                lbxCourseList.Items.Add(courses[i]);
            }

            lblName.Text = student;

            lbxCourseList.DoubleClick += (Sender, E) =>
            {
                string selectedItem = lbxCourseList.SelectedItem.ToString();
                if (selectedItem == "") return;
                txtCourse.Text = selectedItem;

                DataTable courseDetails = Student_Manager.GetCourseDetails(selectedItem);
                if (courseDetails.Rows.Count > 0)
                {
                    DataRow row = courseDetails.Rows[0];
                    lblPrice.Text = "Price: " + row["Price"].ToString();
                    lblStartDate.Text = "Start Date: " + row["StartDate"].ToString();
                    lblDays.Text = "Days: " + row["Day"].ToString();
                    lblHours.Text = "Hours: " + row["Hour"].ToString();

                }


                List<string> subjects = Student_Manager.GetSubjectsByCourse(selectedItem);
                lblSubjects.Text = "Subjects: " + string.Join(", ", subjects);
            };



            DataTable selectedCourses = Student_Manager.GetSelectedCourses(student);
            dgvListStndCourses.DataSource = selectedCourses;
        }



    private void txtCourse_TextChanged(object sender, EventArgs e)
        {
            List<string> courses = Student_Manager.GetCourseByString(txtCourse.Text);
            lbxCourseList.Items.Clear();
            for (int i = 0; i < courses.Count(); i++)
            {
                lbxCourseList.Items.Add(courses[i]);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvListStndCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCourse.Text))
            {
                MessageBox.Show("Please select a course from the list.");
                return;
            }

            Student_Manager.AddCourseToStudent(student, txtCourse.Text);

            DataTable selectedCourses = Student_Manager.GetSelectedCourses(student);
            dgvListStndCourses.DataSource = selectedCourses;

            MessageBox.Show("Course added successfully.");
        }

        
    }
}
