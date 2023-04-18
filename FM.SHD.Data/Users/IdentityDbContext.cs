using FM.SHD.Data.EfCore;
using FM.SHD.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace FM.SHD.Data.Users
{
    public class IdentityDbContext : ContextBase<IdentityDbContext>
    {
        public virtual DbSet<Identity> Identities { get; set; }

        public IdentityDbContext(string connectionString) : base(connectionString)
        {
        }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Identity>(entity =>
            {
                entity.ToTable("Identity");

                entity.HasIndex(e => e.Id, "IX_Identity_Id")
                    .IsUnique();
            });

        }
    }
}