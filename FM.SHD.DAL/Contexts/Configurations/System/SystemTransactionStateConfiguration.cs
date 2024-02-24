using System.Collections.Generic;
using FM.SHD.Domain.Entities.System;
using FM.SHD.Domain.Models.Transactions;
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
                new() { Id = (int)TypeOfTransactionStates.Расход, DisplayNameState = nameof(TypeOfTransactionStates.Расход) },
                new() { Id = (int)TypeOfTransactionStates.Доход, DisplayNameState = nameof(TypeOfTransactionStates.Доход) },
                new() { Id = (int)TypeOfTransactionStates.Перевод, DisplayNameState = nameof(TypeOfTransactionStates.Перевод) },
            });
        }
    }
}