﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using University.Models.Entities;
using University.Repository.Data;
using University.Repository.Implementations;
using University.Repository.Interfaces;
using University.Service.Implementations;
using University.Service.Interfaces;
using University.Service.Mapping;

namespace University.API
{
    public static class ContainerExtension
    {
        public static void AddControllers(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
        }
        public static void AddOpenApi(this WebApplicationBuilder builder)
        {
            builder.Services.AddOpenApi();
        }
        public static void AddDatabase(this WebApplicationBuilder builder)
        {
            builder.Services
                .AddDbContext<ApplicationDbContext>(options => options
                .UseSqlServer(builder.Configuration.GetConnectionString("SQLServerLocalConnection")));
        }
        public static void AddAutoMapper(this WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(MappingProfile));
        }
        public static void AddRepositories(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<IAddressRepository, AddressRepository>();
            builder.Services.AddScoped<ICourseRepository, CourseRepository>();
            builder.Services.AddScoped<IGroupRepository, GroupRepository>();
            builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
        }
        public static void AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<ITeacherService, TeacherService>();
        }

        public static void AddIdentity(this WebApplicationBuilder builder)
        {
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredLength = 3;

                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();
        }
    }
}
