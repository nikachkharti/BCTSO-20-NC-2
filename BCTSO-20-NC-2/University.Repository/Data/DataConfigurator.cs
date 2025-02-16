using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using University.Models.Entities;

namespace University.Repository.Data
{
    public static class DataConfigurator
    {
        public static void ConfigureStudents(this ModelBuilder modelBuilder)
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
        }
        public static void ConfigureAddresses(this ModelBuilder modelBuilder)
        {
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
        }
        public static void ConfigureTeachers(this ModelBuilder modelBuilder)
        {
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
        }
        public static void ConfigureCourses(this ModelBuilder modelBuilder)
        {
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
        }
        public static void ConfigureGroups(this ModelBuilder modelBuilder)
        {
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
        }


        public static void SeedStudents(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData
                (
                    new Student()
                    {
                        Id = 1,
                        Name = "Lana Sten",
                        BirthDate = DateTime.Parse("1995-01-01"),
                        Email = "Lana@gmail.com",
                        PersonalNumber = "01025879658",
                    },
                    new Student()
                    {
                        Id = 2,
                        Name = "Luka Biwadze",
                        BirthDate = DateTime.Parse("2002-02-01"),
                        Email = "luka@gmail.com",
                        PersonalNumber = "01025879651"
                    },
                    new Student()
                    {
                        Id = 3,
                        Name = "Saba Beridze",
                        BirthDate = DateTime.Parse("2001-12-01"),
                        Email = "saba@gmail.com",
                        PersonalNumber = "01025879621"
                    }
                );
        }
        public static void SeedAddresses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasData
                (
                    new Address()
                    {
                        Id = 1,
                        City = "Tbilisi",
                        Street = "Test str #1",
                        StudentId = 1,
                    },
                    new Address()
                    {
                        Id = 2,
                        City = "Batumi",
                        Street = "Test str #2",
                        StudentId = 2,
                    },
                    new Address()
                    {
                        Id = 3,
                        City = "Kutaisi",
                        Street = "Test str #3",
                        StudentId = 3
                    }
                );
        }
        public static void SeedTeachers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData
                (
                    new Teacher()
                    {
                        Id = 1,
                        Name = "Nika Chkhartishvili"
                    },
                    new Teacher()
                    {
                        Id = 2,
                        Name = "Giorgi Giorgadze"
                    }
                );
        }
        public static void SeedCourses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData
                (
                    new Course()
                    {
                        Id = 1,
                        Title = "C#",
                        TeacherId = 1
                    },
                    new Course()
                    {
                        Id = 2,
                        Title = "Javascript",
                        TeacherId = 2
                    },
                    new Course()
                    {
                        Id = 3,
                        Title = "Python",
                        TeacherId = 1
                    }
                );
        }
        public static void SeedGroups(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasData(
                    new Group()
                    {
                        Id = 1,
                        Title = "Group#1",
                        CourseId = 1,
                        StudentId = 1
                    },
                    new Group()
                    {
                        Id = 2,
                        Title = "Group#2",
                        CourseId = 2,
                        StudentId = 2
                    },
                    new Group()
                    {
                        Id = 3,
                        Title = "Group#2",
                        CourseId = 3,
                        StudentId = 2
                    },
                    new Group()
                    {
                        Id = 4,
                        Title = "Group#2",
                        CourseId = 3,
                        StudentId = 3
                    }
                );
        }

    }
}
