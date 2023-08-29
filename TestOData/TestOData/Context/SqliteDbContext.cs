using Microsoft.EntityFrameworkCore;
using TestOData.Models;

namespace TestOData.Context
{
    public class SqliteDbContext : DbContext
    {
        public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableDetailedErrors();
        }

        public DbSet<DataFile> DataFiles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
