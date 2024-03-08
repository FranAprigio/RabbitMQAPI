using Microsoft.EntityFrameworkCore;
using RabbitMQProductAPI.Models;

namespace RabbitMQProductAPI.Data
{
    public class DbContextProduct : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbContextProduct(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Product> Products { get; set; }
    }
}