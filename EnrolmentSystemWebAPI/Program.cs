using EnrolmentSystemWebAPI.Models;
using EnrolmentSystemWebAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<EnrolmentDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<EnrolmentServices>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<EnrolmentDbContext>();

    context.Database.EnsureCreated();

    if (!context.Students.Any()) 
    { 
        var student1 = new Student 
        { 
            StudentName = "John Doe", 
            DateEnrolled = DateOnly.Parse("2026-05-01") 
        }; 
        var student2 = new Student 
        { 
            StudentName = "Jane Smith", 
            DateEnrolled = DateOnly.Parse("2026-05-03") 
        }; 
        var student3 = new Student 
        { 
            StudentName = "Alice Johnson", 
            DateEnrolled = DateOnly.Parse("2026-05-14") 
        }; 
        context.Students.AddRange(student1, student2, student3); 
        context.SaveChanges(); 
    }

    if (!context.Courses.Any()) 
    { 
        var course1 = new Course { CourseName = "Mathematics", CourseCost = 100 }; 
        var course2 = new Course { CourseName = "Science", CourseCost = 150 }; 
        var course3 = new Course { CourseName = "History", CourseCost = 120 }; 
        context.Courses.AddRange(course1, course2, course3); 
        context.SaveChanges(); 
    }
    if (!context.Enrolments.Any()) 
    { 
        var enrolment1 = new Enrolment { StudentId = 1, CourseId = 1, Grade = 10 }; 
        var enrolment2 = new Enrolment { StudentId = 1, CourseId = 2, Grade = 9 }; 
        var enrolment3 = new Enrolment { StudentId = 2, CourseId = 1, Grade = 8 }; 
        context.Enrolments.AddRange(enrolment1, enrolment2, enrolment3); 
        context.SaveChanges(); 
    }
}

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
