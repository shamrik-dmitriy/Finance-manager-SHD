using System.Collections.Generic;
using FM.SHD.Currencies;
using FM.SHD.Domain.Currencies;
using FM.SHD.Domain.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FM.SHD.DAL.Contexts.Configurations.System
{
    public class SystemCurrencyConfiguration : IEntityTypeConfiguration<SystemCurrency>
    {
        public void Configure(EntityTypeBuilder<SystemCurrency> builder)
        {
            builder
                .ToTable(nameof(SystemCurrency));
            builder
                .HasIndex(e => e.Id, "IX_sys_currency_id")
                .IsUnique();
            builder
                .HasIndex(e => e.Name, "IX_sys_currency_name")
                .IsUnique();
            builder
                .HasIndex(e => e.Symbol, "IX_sys_currency_symbol")
                .IsUnique();
            builder
                .Property(e => e.Name).IsRequired();
            builder
                .Property(e => e.Symbol).IsRequired();
            
            builder.HasData(TypeOfCurrencies.GetTypeOfCurrencies());
        }
    }
}