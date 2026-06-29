using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnrolmentWinClient
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm();
            form.Show();
        }

        private void viewStudentsButton_Click(object sender, EventArgs e)
        {
            ViewStudentsForm form = new ViewStudentsForm();
            form.Show();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            AddCourseForm form = new AddCourseForm();
            form.Show();
        }

        private void viewCoursesButton_Click(object sender, EventArgs e)
        {
            ViewCoursesForm form = new ViewCoursesForm();
            form.Show();
        }

        private void addEnrolmentButton_Click(object sender, EventArgs e)
        {
            AddEnrolmentForm form = new AddEnrolmentForm();
            form.Show();
        }

        private void viewEnrolmentButton_Click(object sender, EventArgs e)
        {
            ViewEnrolmentForm form = new ViewEnrolmentForm();
            form.Show();
        }
    }
}
