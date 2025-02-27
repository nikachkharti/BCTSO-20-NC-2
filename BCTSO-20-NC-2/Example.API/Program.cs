using Example.API.Data;
using Example.API.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Example.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            //Singleton - აპლიკაციის დასტარტვიდან მის გათიშვამდე გამოიყენება StudentService - ის ერთი, კონკრეტული ინსტანსი და არ იქმნება სხვა ყველაზე სიცოცხლის უნარიანი.
            //builder.Services.AddSingleton<IStudentService, StudentService>();

            //Scoped - ყოველ ახალ გამოძახებაზე არეგისტრირებს ახალ ინსტანსს, მაგრამ მხოლოდ კონკრეტული scope - ის გარეთ. საშუალო სიცოცხლის უნარიანი
            //builder.Services.AddScoped<IStudentService, StudentService>();

            //Transinet - ყოველ ახალ გამოძახებაზე არეგისტრირებს ახალ ინსტანსს. ყველაზე ხანმოკლე სიცოცხლის უნარიანი.
            //builder.Services.AddTransient<IStudentService, StudentService>();
            builder.Services.AddScoped<IToDoRepository, ToDoRepository>();
            builder.Services
               .AddDbContext<ApplicationDbContext>(options => options
               .UseSqlServer(builder.Configuration.GetConnectionString("SQLServerLocalConnection"))
               .ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning)));



            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
