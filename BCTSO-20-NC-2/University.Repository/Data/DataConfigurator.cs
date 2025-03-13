using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Collections.Generic;
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

        public static void OverrideDefaultIdentityTableNames(this ModelBuilder modelBuilder)
        {
            // Override the default table names
            modelBuilder.Entity<ApplicationUser>(entity => { entity.ToTable(name: "Users"); });
            modelBuilder.Entity<IdentityRole>(entity => { entity.ToTable(name: "Roles"); });
            modelBuilder.Entity<IdentityUserRole<string>>(entity => { entity.ToTable("UserRoles"); });
            modelBuilder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable("UserClaims"); });
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable("UserLogins"); });
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable("RoleClaims"); });
            modelBuilder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable("UserTokens"); });
        }


        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            PasswordHasher<ApplicationUser> hasher = new();

            modelBuilder.Entity<ApplicationUser>().HasData(
                    new ApplicationUser()
                    {
                        Id = "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                        UserName = "admin@gmail.com",
                        NormalizedUserName = "ADMIN@GMAIL.COM",
                        Email = "admin@gmail.com",
                        NormalizedEmail = "ADMIN@GMAIL.COM",
                        EmailConfirmed = false,
                        PasswordHash = hasher.HashPassword(null, "Admin123!"),
                        PhoneNumber = "555337681",
                        PhoneNumberConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnd = null,
                        LockoutEnabled = true,
                        AccessFailedCount = 0,
                        FullName = "Administrator"
                    },
                    new ApplicationUser()
                    {
                        Id = "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                        UserName = "nika@gmail.com",
                        NormalizedUserName = "NIKA@GMAIL.COM",
                        Email = "nika@gmail.com",
                        NormalizedEmail = "NIKA@GMAIL.COM",
                        EmailConfirmed = false,
                        PasswordHash = hasher.HashPassword(null, "Nika123!"),
                        PhoneNumber = "558490645",
                        PhoneNumberConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnd = null,
                        LockoutEnabled = true,
                        AccessFailedCount = 0,
                        FullName = "Nikoloz Chkhartishvili"
                    },
                    new ApplicationUser()
                    {
                        Id = "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                        UserName = "gio@gmail.com",
                        NormalizedUserName = "GIO@GMAIL.COM",
                        Email = "gio@gmail.com",
                        NormalizedEmail = "GIO@GMAIL.COM",
                        EmailConfirmed = false,
                        PasswordHash = hasher.HashPassword(null, "Gio123!"),
                        PhoneNumber = "551442269",
                        PhoneNumberConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnd = null,
                        LockoutEnabled = true,
                        AccessFailedCount = 0,
                        FullName = "Giorgi Giorgadze"
                    }
                );

        }
        public static void SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "33B7ED72-9434-434A-82D4-3018B018CB87", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", Name = "Customer", NormalizedName = "CUSTOMER" }
            );
        }
        public static void SeedUserRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string> { RoleId = "33B7ED72-9434-434A-82D4-3018B018CB87", UserId = "8716071C-1D9B-48FD-B3D0-F059C4FB8031" },
                    new IdentityUserRole<string> { RoleId = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", UserId = "D514EDC9-94BB-416F-AF9D-7C13669689C9" },
                    new IdentityUserRole<string> { RoleId = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", UserId = "87746F88-DC38-4756-924A-B95CFF3A1D8A" }
                );
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
                        Name = "Nika Chkhartishvili",
                        ProfilePictureUrl = null
                    },
                    new Teacher()
                    {
                        Id = 2,
                        Name = "Giorgi Giorgadze",
                        ProfilePictureUrl = null
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
