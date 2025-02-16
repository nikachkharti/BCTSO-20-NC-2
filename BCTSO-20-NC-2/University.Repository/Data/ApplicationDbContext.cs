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
            //Student Entity
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity
                .Property(s => s.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);

                entity
                .Property(s => s.PersonalNumber)
                .IsRequired()
                .HasColumnType("CHAR(11)")
                .HasMaxLength(11);

                entity
                .Property(s => s.Email)
                .IsRequired()
                .HasColumnType("VARCHAR(50)")
                .HasMaxLength(50);

                entity
                .HasOne(s => s.Address)
                .WithOne(a => a.Student)
                .HasForeignKey<Address>(a => a.StudentId);

                entity
                .HasMany(s => s.Groups)
                .WithOne(g => g.Student)
                .HasForeignKey(g => g.StudentId);
            });

            //Address Entity
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity
                .Property(a => a.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity
                .Property(a => a.City)
                .IsRequired()
                .HasMaxLength(50);

                entity
                .Property(a => a.Street)
                .IsRequired()
                .HasMaxLength(50);

                entity
                .HasOne(a => a.Student)
                .WithOne(s => s.Address)
                .HasForeignKey<Address>(a => a.StudentId);
            });

            //Teacher Entity
            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity
                .Property(t => t.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity
                .Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

                entity
                .HasMany(t => t.Courses)
                .WithOne(c => c.Teacher)
                .HasForeignKey(c => c.TeacherId);

            });


            //Course Entity
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity
                .Property(c => c.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity
                .Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(150);

                entity
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherId);

                entity
                .HasMany(c => c.Groups)
                .WithOne(g => g.Course)
                .HasForeignKey(g => g.CourseId);
            });

            //Group Entity
            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(g => g.Id);
                entity
                .Property(g => g.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity
                .Property(g => g.Title)
                .IsRequired()
                .HasMaxLength(50);

                entity
                .HasOne(g => g.Student)
                .WithMany(s => s.Groups)
                .HasForeignKey(g => g.StudentId);

                entity
                .HasOne(g => g.Course)
                .WithMany(c => c.Groups)
                .HasForeignKey(g => g.CourseId);
            });


            modelBuilder.SeedStudents();
            modelBuilder.SeedAddresses();
            modelBuilder.SeedCourses();
            modelBuilder.SeedTeachers();
            modelBuilder.SeedGroups();
        }

    }
}
