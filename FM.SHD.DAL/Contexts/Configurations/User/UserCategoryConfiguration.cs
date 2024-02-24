using FM.SHD.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FM.SHD.DAL.Contexts.Configurations.User
{
    public class UserCategoryConfiguration : IEntityTypeConfiguration<UserCategory>
    {
        public void Configure(EntityTypeBuilder<UserCategory> builder)
        {
            builder
                .ToTable(nameof(UserCategory));
            
            builder
                .HasIndex(e => e.Id, "IX_user_categories_id")
                .IsUnique();

            builder
                .HasOne(d => d.SystemCategoryType)
                .WithMany(p => p.UserCategories)
                .HasForeignKey(d => d.SysCategoryTypeId);
        }
    }
}