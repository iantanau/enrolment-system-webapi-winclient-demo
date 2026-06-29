using System;
using System.Collections.Generic;
using System.Text;

namespace EnrolmentWinClient.Models
{
    public class Enrolment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }
        public override string ToString()
        {
            return $"Student ID: {StudentId}, Course ID: {CourseId}, Grade: {Grade}";
        }
    }
}
