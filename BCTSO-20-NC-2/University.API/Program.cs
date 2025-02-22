using Microsoft.EntityFrameworkCore;
using University.Repository.Data;
using University.Repository.Implementations;
using University.Repository.Interfaces;
using University.Service.Implementations;
using University.Service.Interfaces;
using University.Service.Mapping;

namespace University.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();
            builder.Services
                .AddDbContext<ApplicationDbContext>(options => options
                .UseSqlServer("Server=DESKTOP-SCSHELD\\SQLEXPRESS;Database=UniversityBCTSO20N;Trusted_Connection=true;TrustServerCertificate=true"));

            builder.Services.AddAutoMapper(typeof(MappingProfile));

            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<IAddressRepository, AddressRepository>();
            builder.Services.AddScoped<ICourseRepository, CourseRepository>();
            builder.Services.AddScoped<IGroupRepository, GroupRepository>();
            builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();

            builder.Services.AddScoped<ITeacherService, TeacherService>();

            var app = builder.Build();

            app.MapOpenApi();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
