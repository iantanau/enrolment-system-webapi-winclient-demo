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
    public partial class ViewEnrolmentForm : Form
    {
        //const string BASE_ADDRESS = "https://localhost:7070/";
        const string BASE_ADDRESS = "https://enrolmentsystemwebapi20260521132343-g2hhh3hbancvfpfa.australiaeast-01.azurewebsites.net";
        private HttpClient client = new HttpClient { BaseAddress = new Uri(BASE_ADDRESS) };
        public ViewEnrolmentForm()
        {
            InitializeComponent();

            courseComboBox.SelectedIndexChanged += courseComboBox_SelectedIndexChanged;

            LoadCourses();
        }

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseComboBox.SelectedItem is Course selectedCourse)
            {
                courseNameLabel.Text =
                    $"Course Name: {selectedCourse.CourseName}";

                courseCostLabel.Text =
                    $"Course Cost: ${selectedCourse.CourseCost}";
            }
        }

        private async void LoadCourses()
        {
            try
            {
                var courses = await client.GetFromJsonAsync<List<Course>>("api/Enrolment/courses");

                if (courses != null)
                {
                    courseComboBox.DataSource = courses;
                    courseComboBox.DisplayMember = "CourseId";
                    courseComboBox.ValueMember = "CourseId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load courses: {ex.Message}");
            }
        }

        async Task DisplayEnrolments()
        {
            try
            {
                if (courseComboBox.SelectedItem is not Course selectedCourse)
                {
                    MessageBox.Show("Please select a course.");
                    return;
                }

                var students =
                    await client.GetFromJsonAsync<List<StudentGradeDto>>
                    ($"api/Enrolment/coursestudents/{selectedCourse.CourseId}");

                if (students != null)
                {
                    foreach (var student in students)
                    {
                        studentListBox.Items.Add(
                            $"Student ID: {student.StudentId} | " +
                            $"Name: {student.StudentName} | " +
                            $"Grade: {student.Grade}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void retrieveStudentButton_Click(object sender, EventArgs e)
        {
            studentListBox.Items.Clear();
            await DisplayEnrolments();
        }
    }
}