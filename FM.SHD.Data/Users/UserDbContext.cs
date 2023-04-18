using FM.SHD.Data.EfCore;
using FM.SHD.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace FM.SHD.Data.Users
{
    public class UserDbContext : ContextBase<UserDbContext>
    {
        public virtual DbSet<User> Users { get; set; }

        public UserDbContext(string connectionString) : base(connectionString)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_Users_Id")
                    .IsUnique();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Password).IsRequired();
            });
        }
    }
}