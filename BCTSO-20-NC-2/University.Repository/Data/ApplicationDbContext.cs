using Microsoft.EntityFrameworkCore;
using University.Models.Entities;

namespace University.Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Group> Groups { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureStudents();
            modelBuilder.ConfigureAddresses();
            modelBuilder.ConfigureTeachers();
            modelBuilder.ConfigureCourses();
            modelBuilder.ConfigureGroups();

            modelBuilder.SeedStudents();
            modelBuilder.SeedAddresses();
            modelBuilder.SeedCourses();
            modelBuilder.SeedTeachers();
            modelBuilder.SeedGroups();
        }

    }
}
