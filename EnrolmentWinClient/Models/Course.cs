using System;
using System.Collections.Generic;
using System.Text;

namespace EnrolmentWinClient.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public double? CourseCost { get; set; }
        public override string ToString()
        {
            return $"CourseId: {CourseId}, CourseName: {CourseName}, CourseCost: {CourseCost}";
        }
    }
}
