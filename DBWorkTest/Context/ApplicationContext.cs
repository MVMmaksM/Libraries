using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace DBWorkLibraries.Context
{
    internal class ApplicationContext : DbContext
    {
        private string _connectionString;     
        public DbSet<Detail> Detail { get; set; }        
        public DbSet<Material> Material { get; set; }
        public DbSet<Sheet> Sheet { get; set; }
        public DbSet<CuttingMap> CuttingMap { get; set; }
        public DbSet<CuttingMapDetail> CuttingMapDetail { get; set; }


        public ApplicationContext(string connectionString)
        {
            _connectionString = connectionString;
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Entity<CuttingMapDetail>().HasNoKey();
        }
    }
}
