using EnrolmentWinClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;

namespace EnrolmentWinClient
{
    public partial class ViewCoursesForm : Form
    {
        //const string BASE_ADDRESS = "https://localhost:7070/";
        const string BASE_ADDRESS = "https://enrolmentsystemwebapi20260521132343-g2hhh3hbancvfpfa.australiaeast-01.azurewebsites.net";
        private HttpClient client = new HttpClient { BaseAddress = new Uri(BASE_ADDRESS) };

        public ViewCoursesForm()
        {
            InitializeComponent();
        }

        async Task DisplayCourses()
        {
            var courses = await client.GetFromJsonAsync<List<Course>>("api/Enrolment/Courses");
            if (courses != null)
            {
                foreach (var course in courses)
                {
                    courseListBox.Items.Add(course.ToString());
                }
            }
        }

        private async void showCoursesButton_Click(object sender, EventArgs e)
        {
            courseListBox.Items.Clear();
            await DisplayCourses();
        }
    }
}
