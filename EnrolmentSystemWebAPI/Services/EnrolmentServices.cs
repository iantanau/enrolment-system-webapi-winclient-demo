using EnrolmentSystemWebAPI.DTOs;
using EnrolmentSystemWebAPI.Models;

namespace EnrolmentSystemWebAPI.Services
{
    public class EnrolmentServices
    {
        private readonly EnrolmentDbContext _context;

        public EnrolmentServices(EnrolmentDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public void AddStudent(Student student)
        {
            try
            {
                _context.Students.Add(student);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public List<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public void AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public List<Enrolment> GetAllEnrolments()
        {
            return _context.Enrolments.ToList();
        }

        public void AddEnrolment(Enrolment enrolment)
        {
            _context.Enrolments.Add(enrolment);
            _context.SaveChanges();
        }

        public List<StudentGradeDto> GetStudentsByCourse(int courseId)
        {
            var result =
                from e in _context.Enrolments
                join s in _context.Students
                    on e.StudentId equals s.StudentId
                where e.CourseId == courseId
                select new StudentGradeDto
                {
                    StudentId = s.StudentId,
                    StudentName = s.StudentName,
                    Grade = e.Grade
                };

            return result.ToList();
        }

    }
}
