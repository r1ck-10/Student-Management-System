using Microsoft.EntityFrameworkCore;
namespace StudentMS.Models
{
    public class APIDbcontext:DbContext
    {
        public APIDbcontext(DbContextOptions option) : base(option)
        {

        }
        public DbSet<Classroom> Classes { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
