using System;
using HealthCareERP.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthCareERP.Data
{
    public class HealthCareERPContext : DbContext
    {
        public DbSet<Medicine> Medicines { get; set; }
        
        public DbSet<Storage> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
    }
}