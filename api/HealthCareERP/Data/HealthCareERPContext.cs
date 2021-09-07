using HealthCareERP.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HealthCareERP.Data
{
    public class HealthCareERPContext : DbContext
    {
        public DbSet<Storage> Storages { get; set; }

        public DbSet<Medicine> Medicines { get; set; }

        private readonly IConfiguration _configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}