using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace DBWorkLibraries.Context
{
    internal class ApplicationContext : DbContext
    {
        private string _connectionString;
        public DbSet<Detail> Detail { get; set; } = null!;        
        public DbSet<Material> Material { get; set; }
        public DbSet<Sheet> Sheet { get; set; }
        public DbSet<CuttingMap> CuttingMap { get; set; }
        public DbSet<CuttingMapDetail> CuttingMapDetail { get; set; }
               
        public ApplicationContext(string connectionString)
        {
            _connectionString = connectionString;          
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            optionsBuilder.LogTo(Console.WriteLine);
        }
        protected override void OnModelCreating(ModelBuilder entityBuilder)
        {
            entityBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());           
        }
    }
}
