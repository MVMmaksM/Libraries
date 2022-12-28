using DBWorkLibraries.Model;
using Microsoft.EntityFrameworkCore;

namespace DBWorkLibraries.Context
{
    internal class ApplicationContext : DbContext
    {
        private string _connectionString;
        
        public DbSet<Detail> Details { get; set; }

        public ApplicationContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
