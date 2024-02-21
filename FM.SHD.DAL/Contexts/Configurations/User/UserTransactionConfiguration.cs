using FM.SHD.DAL.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FM.SHD.DAL.Contexts.Configurations.User
{
    public class UserTransactionConfiguration : IEntityTypeConfiguration<UserTransaction>
    {

        public void Configure(EntityTypeBuilder<UserTransaction> builder)
        {
            builder
                .ToTable(nameof(UserTransaction));
            
            builder
                .HasIndex(e => e.Id, "IX_usr_transactions_id")
                .IsUnique();

            builder
                .Property(e => e.Date).IsRequired();

            builder
                .Property(e => e.Sum).HasColumnType("NUMERIC");

            builder
                .HasOne(d => d.SystemTransactionStatesType)
                .WithMany(p => p.UserTransactions)
                .HasForeignKey(d => d.SysTransactionStatesTypeId);

            builder
                .HasOne(d => d.UserCategoryContragent)
                .WithMany(p => p.UserTransactionCategoryContragents)
                .HasForeignKey(d => d.UsrCategoryContragentId)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasOne(d => d.UserCategory)
                .WithMany(p => p.UserTransactionCategories)
                .HasForeignKey(d => d.UsrCategoryId);

            builder
                .HasOne(d => d.UserDebitAccount)
                .WithMany(p => p.UserTransactionDebitAccounts)
                .HasForeignKey(d => d.UsrDebitAccountId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(d => d.UserDebitCredit)
                .WithMany(p => p.UserTransactionDebitCredits)
                .HasForeignKey(d => d.UsrDebitCreditId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(d => d.UserReceipts)
                .WithMany(p => p.UserTransactions)
                .HasForeignKey(d => d.UsrReceiptsId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}