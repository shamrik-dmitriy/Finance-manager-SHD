using FM.SHD.DAL.Entities.User;
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
                .HasIndex(e => e.Id, "IX_usr_categories_id")
                .IsUnique();

            builder
                .HasOne(d => d.SystemCategoryType)
                .WithMany(p => p.UserCategories)
                .HasForeignKey(d => d.SysCategoryTypeId);
        }
    }
}