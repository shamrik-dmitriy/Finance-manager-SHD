using FM.SHD.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FM.SHD.DAL.Contexts.Configurations.User
{
    public class UserReceiptConfiguration : IEntityTypeConfiguration<UserReceipt>
    {
        public void Configure(EntityTypeBuilder<UserReceipt> builder)
        {
            builder
                .ToTable(nameof(UserReceipt));
            
            builder
                .HasIndex(e => e.Id, "IX_user_receipts_id")
                .IsUnique();

            builder
                .Property(e => e.Date).IsRequired();

            builder
                .HasOne(d => d.UserAccount)
                .WithMany(p => p.UserReceipts)
                .HasForeignKey(d => d.UserAccountId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(d => d.UserCategoryContragent)
                .WithMany(p => p.UserReceipts)
                .HasForeignKey(d => d.UserCategoryContragentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}