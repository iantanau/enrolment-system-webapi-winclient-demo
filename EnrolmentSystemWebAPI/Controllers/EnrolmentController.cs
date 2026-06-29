using Microsoft.AspNetCore.Mvc;
using EnrolmentSystemWebAPI.Models;
using EnrolmentSystemWebAPI.Services;
using EnrolmentSystemWebAPI.DTOs;

namespace EnrolmentSystemWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrolmentController : ControllerBase
    {
        private readonly EnrolmentServices _service;

        public EnrolmentController(EnrolmentServices service)
        {
            _service = service;
        }

        // GET: api/enrolment/students
        [HttpGet("students")]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return _service.GetAllStudents();
        }

        // POST: api/enrolment/students
        [HttpPost("students")]
        public IActionResult CreateStudent(CreateStudentDto dto)
        {
            var student = new Student
            {
                StudentName = dto.StudentName,
                DateEnrolled = dto.DateEnrolled
            };

            _service.AddStudent(student);

            return CreatedAtAction(
                nameof(GetAllStudents),
                new { id = student.StudentId },
                student);
        }

        // GET: api/enrolment/courses
        [HttpGet("courses")]
        public ActionResult<List<Course>> GetAllCourses()
        {
            return _service.GetAllCourses();
        }

        // POST: api/enrolment/courses
        [HttpPost("courses")]
        public IActionResult CreateCourse(CreateCourseDto dto)
        {
            var course = new Course
            {
                CourseName = dto.CourseName,
                CourseCost = dto.CourseCost
            };

            _service.AddCourse(course);

            return CreatedAtAction(
                nameof(GetAllCourses),
                new { id = course.CourseId },
                course);
        }

        // GET: api/enrolment/enrolments
        [HttpGet("enrolments")]
        public ActionResult<List<Enrolment>> GetAllEnrolments()
        {
            return _service.GetAllEnrolments();
        }

        // POST: api/enrolment/enrolments
        [HttpPost("enrolments")]
        public IActionResult CreateEnrolment(CreateEnrolmentDto dto)
        {
            var enrolment = new Enrolment
            {
                StudentId = dto.StudentId,
                CourseId = dto.CourseId,
                Grade = dto.Grade
            };

            _service.AddEnrolment(enrolment);

            return CreatedAtAction(
                nameof(GetAllEnrolments),
                new
                {
                    studentId = enrolment.StudentId,
                    courseId = enrolment.CourseId
                },
                enrolment);
        }

        [HttpGet("coursestudents/{courseId}")]
        public IActionResult GetStudentsByCourse(int courseId)
        {
            var students = _service.GetStudentsByCourse(courseId);

            return Ok(students);
        }
    }
}