using FM.SHD.Data.EfCore;
using FM.SHD.Domain.Accounts;
using Microsoft.EntityFrameworkCore;

namespace FM.SHD.Data.Accounts
{
    public class AccountCategoryDbContext : ContextBase<AccountCategoryDbContext>
    {
        public AccountCategoryDbContext(string connectionString) : base(connectionString)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountCategory>(entity =>
            {
                entity.ToTable("AccountCategory");

                entity.HasIndex(e => e.Id, "IX_AccountCategory_Id")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("NUMERIC");

                entity.Property(e => e.Name).IsRequired();
            });
        }
    }
}