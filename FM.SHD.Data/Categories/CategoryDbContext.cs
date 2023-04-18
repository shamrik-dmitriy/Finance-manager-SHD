using FM.SHD.Data.EfCore;
using FM.SHD.Domain.Categories;
using Microsoft.EntityFrameworkCore;

namespace FM.SHD.Data.Categories
{
    public class CategoryDbContext : ContextBase<CategoryDbContext>
    {
        public virtual DbSet<Category> Categories { get; set; }

        public CategoryDbContext(string connectionString) : base(connectionString)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=D:\\\\\\\\repos\\\\\\\\SHD\\db\\default-db.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_Categories_Id")
                    .IsUnique();

                entity.Property(e => e.Name).IsRequired();
            });
        }
    }
}