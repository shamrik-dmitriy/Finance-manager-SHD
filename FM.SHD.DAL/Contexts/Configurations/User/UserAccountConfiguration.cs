using FM.SHD.DAL.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FM.SHD.DAL.Contexts.Configurations.User
{
    public class UserAccountConfiguration : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder
                .ToTable(nameof(UserAccount));

            builder
                .HasIndex(e => e.Id, "IX_usr_accounts_id")
                .IsUnique();

            builder
                .Property(e => e.Id).ValueGeneratedNever();

            builder
                .Property(e => e.CurrentSum)
                .HasColumnType("NUMERIC")
                .HasDefaultValueSql("0");

            builder
                .Property(e => e.InitialSum)
                .HasColumnType("NUMERIC")
                .HasDefaultValueSql("0");

            builder
                .Property(e => e.IsClosed).HasDefaultValueSql("0");

            builder
                .Property(e => e.IsPrivate).HasDefaultValueSql("0");

            builder
                .HasOne(d => d.SystemCurrency)
                .WithMany(p => p.UserAccounts)
                .HasForeignKey(d => d.SysCurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder
                .HasOne(d => d.UserCategory)
                .WithMany(p => p.UserAccounts)
                .HasForeignKey(d => d.UserCategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}