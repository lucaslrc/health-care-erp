using HealthCareERP.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthCareERP.Data
{
    public class HealthCareERPContext : DbContext
    {
        public DbSet<Storage> Storages { get; set; }

        public DbSet<Medicine> Medicines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DefaultConnection");
        }
    }
}