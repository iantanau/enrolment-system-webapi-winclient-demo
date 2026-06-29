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
    public partial class AddEnrolmentForm : Form
    {
        //const string BASE_ADDRESS = "https://localhost:7070/";
        const string BASE_ADDRESS = "https://enrolmentsystemwebapi20260521132343-g2hhh3hbancvfpfa.australiaeast-01.azurewebsites.net";
        private HttpClient client = new HttpClient { BaseAddress = new Uri(BASE_ADDRESS) };
        public AddEnrolmentForm()
        {
            InitializeComponent();

            courseComboBox.SelectedIndexChanged += courseComboBox_SelectedIndexChanged;
            studentComboBox.SelectedIndexChanged += studentComboBox_SelectedIndexChanged;

            LoadCourses();
            LoadStudents();
        }

        private List<Course> courses = new List<Course>();
        private List<Student> students = new List<Student>();

        async Task LoadCourses()
        {
            try
            {
                courses = await client.GetFromJsonAsync<List<Course>>("api/Enrolment/Courses");

                if (courses != null)
                {
                    courseComboBox.DataSource = courses;
                    courseComboBox.DisplayMember = "CourseId";
                    courseComboBox.ValueMember = "CourseId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading courses: {ex.Message}");
            }
        }

        async Task LoadStudents()
        {
            try
            {
                students = await client.GetFromJsonAsync<List<Student>>("api/Enrolment/Students");

                if (students != null)
                {
                    studentComboBox.DataSource = students;
                    studentComboBox.DisplayMember = "StudentId";
                    studentComboBox.ValueMember = "StudentId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}");
            }
        }


        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseComboBox.SelectedItem is Course selectedCourse)
            {
                courseNameLabel.Text = $"Course Name: {selectedCourse.CourseName}";
                courseCostLabel.Text = $"Course Cost: {selectedCourse.CourseCost}";
            }
        }

        private void studentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentComboBox.SelectedItem is Student selectedStudent)
            {
                studentNameLabel.Text = $"Student Name: {selectedStudent.StudentName}";
                enrolledDateLabel.Text = $"Date Enrolled: {selectedStudent.DateEnrolled}";
            }
        }

        async Task AddEnrolment(Enrolment enrolment)
        {
            try
            {
                var response = await client.PostAsJsonAsync("api/Enrolment/Enrolments", enrolment);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Enrolment added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add enrolment.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void addEnrolmentButton_Click(object sender, EventArgs e)
        {
            if (courseComboBox.SelectedItem is Course selectedCourse &&
                studentComboBox.SelectedItem is Student selectedStudent)
            {
                Enrolment enrolment = new Enrolment
                {
                    CourseId = selectedCourse.CourseId,
                    StudentId = selectedStudent.StudentId,
                    Grade = 0
                };

                await AddEnrolment(enrolment);
            }
            else
            {
                MessageBox.Show("Please select both student and course.");
            }
        }
    }
}
