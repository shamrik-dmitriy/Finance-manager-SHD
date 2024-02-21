using FM.SHD.DAL.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FM.SHD.DAL.Contexts.Configurations.System
{
    public class SystemTransactionStatusTypeConfiguration : IEntityTypeConfiguration<SystemTransactionStatusType>
    {
        public void Configure(EntityTypeBuilder<SystemTransactionStatusType> builder)
        {
            builder
                .ToTable(nameof(SystemTransactionStatusType));
            builder
                .HasIndex(e => e.DisplayNameStatus, "IX_sys_transaction_status_types_display_name_status")
                .IsUnique();
            builder
                .HasIndex(e => e.Id, "IX_sys_transaction_status_types_id")
                .IsUnique();
            builder.
                Property(e => e.DisplayNameStatus).IsRequired();
        }
    }
}