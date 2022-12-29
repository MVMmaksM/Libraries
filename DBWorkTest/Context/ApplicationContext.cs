using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;

namespace DBWorkLibraries.Context
{
    internal class ApplicationContext : DbContext
    {
        private string _connectionString;        
        public DbSet<Detail> Details { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Sheet> Sheets { get; set; }
        public DbSet<CuttingMap> CuttingMaps { get; set; }
        public DbSet<CuttingMapDetail> CuttingMapDetails { get; set; }


        public ApplicationContext(string connectionString)
        {
            _connectionString = connectionString;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CuttingMapDetail>().HasNoKey();
        }
    }
}
