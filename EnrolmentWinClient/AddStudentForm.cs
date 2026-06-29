using EnrolmentWinClient.Models;
using System.Net.Http.Json;

namespace EnrolmentWinClient
{
    public partial class AddStudentForm : Form
    {
        //const string BASE_ADDRESS = "https://localhost:7070/";
        const string BASE_ADDRESS = "https://enrolmentsystemwebapi20260521132343-g2hhh3hbancvfpfa.australiaeast-01.azurewebsites.net";
        private HttpClient client = new HttpClient { BaseAddress = new Uri(BASE_ADDRESS) };
        public AddStudentForm()
        {
            InitializeComponent();
        }

        async Task AddStudent(Student student)
        {
            try
            {
                var response = await client.PostAsJsonAsync("api/Enrolment/Students", student);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Student added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add student.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void addStudentButton_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                //StudentId = int.Parse(studentIdTextBox.Text),
                StudentName = studentNameTextBox.Text,
                DateEnrolled = DateOnly.Parse(enrolledDatePicker.Value.ToShortDateString())
            };
            await AddStudent(student);
        }
    }
}
