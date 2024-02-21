using System.Collections.Generic;
using FM.SHD.DAL.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FM.SHD.DAL.Contexts.Configurations.System
{
    public class SystemCategoryTypeConfiguration : IEntityTypeConfiguration<SystemCategoryType>
    {
        public void Configure(EntityTypeBuilder<SystemCategoryType> builder)
        {
            builder
                .ToTable(nameof(SystemCategoryType));
            builder
                .HasIndex(e => e.Id, "IX_sys_category_types_id")
                .IsUnique();
            builder
                .HasIndex(e => e.Type, "IX_sys_category_types_type")
                .IsUnique();
            builder
                .Property(e => e.Type).IsRequired();

            builder.HasData(new List<SystemCategoryType>()
            {
                new SystemCategoryType() { Id = 1, Type = "product_category" },
                new SystemCategoryType() { Id = 2, Type = "account_category" },
                new SystemCategoryType() { Id = 3, Type = "contragent_category" },
            });
        }
    }
}