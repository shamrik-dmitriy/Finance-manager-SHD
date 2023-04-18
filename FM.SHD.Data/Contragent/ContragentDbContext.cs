using FM.SHD.Data.EfCore;
using Microsoft.EntityFrameworkCore;

namespace FM.SHD.Data.Contragent
{
    public class ContragentDbContext:ContextBase<ContragentDbContext>
    {
        public virtual DbSet<Domain.Contragents.Contragent> Contragents { get; set; }

        public ContragentDbContext(string connectionString) : base(connectionString)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=D:\\\\\\\\repos\\\\\\\\SHD\\db\\default-db.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Contragents.Contragent>(entity =>
            {
                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });
        }
    }
}