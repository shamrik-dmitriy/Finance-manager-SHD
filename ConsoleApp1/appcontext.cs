using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<MenuItem> MenuItems { get; set; } = null!;
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }
}