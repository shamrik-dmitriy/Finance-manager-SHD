using Microsoft.EntityFrameworkCore;

namespace FM.SHD.Data.EfCore
{
    public abstract class ContextBase<T> : DbContext where T : DbContext
    {
        private readonly string _connectionString;

        public ContextBase(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(_connectionString);
            }
        }
    }
}