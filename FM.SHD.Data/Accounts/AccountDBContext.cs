using FM.SHD.Data.EfCore;
using FM.SHD.Domain.Accounts;
using Microsoft.EntityFrameworkCore;

namespace FM.SHD.Data.Accounts
{
    public class AccountDBContext : ContextBase<AccountDBContext>
    {
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountCategory> AccountCategories { get; set; }


        public AccountDBContext(string connectionString) : base(connectionString)
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
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.CurrencyId)
                    .IsRequired()
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.IsClosed).HasColumnType("NUMERIC");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Identity)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.IdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}