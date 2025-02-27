using Example.API.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Example.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Todo> Tasks { get; set; }
    }
}
