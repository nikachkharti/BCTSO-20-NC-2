using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using University.Models.Entities;

namespace University.Repository.Data
{
    public static class DataSeeder
    {
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
