using University.API.Middleware;

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

            builder.ConfigureJwtOptions();
            builder.AddIdentity();
            builder.AddJwtGenerator();
            builder.AddAuthentication();
            builder.AddAuthService();



            var app = builder.Build();

            app.MapOpenApi();
            app.UseMiddleware<ExceptionHandlingMiddleware>();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
