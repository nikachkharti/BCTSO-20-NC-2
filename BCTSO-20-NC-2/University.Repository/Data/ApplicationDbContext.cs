using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using University.Models.Entities;

namespace University.Repository.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.OverrideDefaultIdentityTableNames();

            modelBuilder.ConfigureStudents();
            modelBuilder.ConfigureAddresses();
            modelBuilder.ConfigureTeachers();
            modelBuilder.ConfigureCourses();
            modelBuilder.ConfigureGroups();

            modelBuilder.SeedUsers();
            modelBuilder.SeedRoles();
            modelBuilder.SeedUserRoles();
            modelBuilder.SeedStudents();
            modelBuilder.SeedAddresses();
            modelBuilder.SeedCourses();
            modelBuilder.SeedTeachers();
            modelBuilder.SeedGroups();
        }

    }
}
