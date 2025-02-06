using MiniBank.Models;
using MiniBank.Repository;
using MiniBank.Repository.Interfaces;
using MiniBank.Services;
using MiniBank.Services.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<ICustomerRepository, SqlClientCustomerRepository>();
        builder.Services.AddScoped<ICustomerService, CustomerService>();

        builder.Services.AddControllers();
        builder.Services.AddOpenApi();

        var app = builder.Build();

        app.MapOpenApi();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}