using System;
using System.Collections.Generic;
using System.Text;

namespace EnrolmentWinClient.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public DateOnly? DateEnrolled { get; set; }
        public override string ToString()
        {
            return $"ID: {StudentId}, Name: {StudentName}, Date Enrolled: {DateEnrolled}";
        }
    }
}
