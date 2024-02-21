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
        }
    }
}