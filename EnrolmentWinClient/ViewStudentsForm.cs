using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;
using EnrolmentWinClient.Models;

namespace EnrolmentWinClient
{
    public partial class ViewStudentsForm : Form
    {

        //const string BASE_ADDRESS = "https://localhost:7070/";
        const string BASE_ADDRESS = "https://enrolmentsystemwebapi20260521132343-g2hhh3hbancvfpfa.australiaeast-01.azurewebsites.net";
        private HttpClient client = new HttpClient { BaseAddress = new Uri(BASE_ADDRESS) };

        public ViewStudentsForm()
        {
            InitializeComponent();
        }

        async Task DisplayStudents()

        {
            var students = await client.GetFromJsonAsync<List<Student>>("api/Enrolment/Students");
            if (students != null)
            {
                foreach (var student in students)
                {
                    studentListBox.Items.Add(student.ToString());
                }
            }
        }

        private async void showStudentsButton_Click(object sender, EventArgs e)
        {
            studentListBox.Items.Clear();
            await DisplayStudents();
        }
    }
}
