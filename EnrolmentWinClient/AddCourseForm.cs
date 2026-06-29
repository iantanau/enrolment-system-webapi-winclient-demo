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
    public partial class AddCourseForm : Form
    {
        //const string BASE_ADDRESS = "https://localhost:7070/";
        const string BASE_ADDRESS = "https://enrolmentsystemwebapi20260521132343-g2hhh3hbancvfpfa.australiaeast-01.azurewebsites.net";
        private HttpClient client = new HttpClient { BaseAddress = new Uri(BASE_ADDRESS) };

        public AddCourseForm()
        {
            InitializeComponent();
        }

        async Task AddCourse(Course course)
        {
            try
            {
                var response = await client.PostAsJsonAsync("api/Enrolment/Courses", course);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Course added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add course.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void addCourseButton_Click(object sender, EventArgs e)
        {
            var course = new Course
            {
                //CourseId = int.Parse(courseIdTextBox.Text),
                CourseName = courseNameTextBox.Text,
                CourseCost = double.Parse(courseCostTextBox.Text)
            };
            await AddCourse(course);
        }
    }
}
