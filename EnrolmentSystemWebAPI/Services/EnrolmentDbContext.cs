using Microsoft.EntityFrameworkCore;
using EnrolmentSystemWebAPI.Models;

namespace EnrolmentSystemWebAPI.Services
{
    public class EnrolmentDbContext : DbContext
    {
        public EnrolmentDbContext(DbContextOptions<EnrolmentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrolment> Enrolments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrolment>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.CourseId });

                entity.Property(e => e.Grade)
                    .HasDefaultValue(10);

                entity.HasOne<Student>()
                    .WithMany()
                    .HasForeignKey(e => e.StudentId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne<Course>()
                    .WithMany()
                    .HasForeignKey(e => e.CourseId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}