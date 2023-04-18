using FM.SHD.Data.EfCore;
using FM.SHD.Domain.Currencies;
using Microsoft.EntityFrameworkCore;

namespace FM.SHD.Data.Currencies
{
    public class CurrencyDbContext : ContextBase<CurrencyDbContext>
    {
        public virtual DbSet<Currency> Currencies { get; set; }

        public CurrencyDbContext(string connectionString) : base(connectionString)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.HasIndex(e => e.Id, "IX_Currency_Id")
                    .IsUnique();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Symbol).IsRequired();
            });
        }
    }
}