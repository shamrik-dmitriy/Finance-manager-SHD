using System.Collections.Generic;
using FM.SHD.DAL.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FM.SHD.DAL.Contexts.Configurations.System
{
    public class SystemTransactionStateConfiguration : IEntityTypeConfiguration<SystemTransactionState>
    {
        public void Configure(EntityTypeBuilder<SystemTransactionState> builder)
        {
            builder
                .ToTable(nameof(SystemTransactionState));
            builder
                .HasIndex(e => e.DisplayNameState, "IX_sys_transaction_states_display_name_state")
                .IsUnique();
            builder
                .HasIndex(e => e.Id, "IX_sys_transaction_states_id")
                .IsUnique();
            builder.HasData(new List<SystemTransactionState>()
            {
                new SystemTransactionState(){Id = 1, DisplayNameState = "Расход"},
                new SystemTransactionState(){Id = 2, DisplayNameState = "Доход"},
                new SystemTransactionState(){Id = 3, DisplayNameState = "Перевод"},
            });
        }
    }
}