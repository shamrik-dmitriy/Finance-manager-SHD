using System.Collections.Generic;
using FM.SHD.Domain.Categories;
using FM.SHD.Domain.Entities.System;
using FM.SHD.Domain.Models.Categories;
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
                new() { Id = (int)TypeOfCategory.ProductCategory, Type = nameof(TypeOfCategory.ProductCategory) },
                new() { Id = (int)TypeOfCategory.AccountCategory, Type = nameof(TypeOfCategory.AccountCategory) },
                new() { Id = (int)TypeOfCategory.ContragentCategory, Type = nameof(TypeOfCategory.ContragentCategory) },
            });
        }
    }
}