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

            builder.AddControllers();
            builder.AddOpenApi();
            builder.AddDatabase();
            builder.AddAutoMapper();
            builder.AddRepositories();
            builder.AddServices();
            builder.AddIdentity();







            var app = builder.Build();

            app.MapOpenApi();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
