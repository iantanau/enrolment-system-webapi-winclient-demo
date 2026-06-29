namespace EnrolmentSystemWebAPI.DTOs
{
    public class CreateStudentDto
    {
        public string? StudentName { get; set; }
        public DateOnly? DateEnrolled { get; set; }
    }
}
