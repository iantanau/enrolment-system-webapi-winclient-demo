namespace EnrolmentSystemWebAPI.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public DateOnly? DateEnrolled { get; set; }
    }
}
