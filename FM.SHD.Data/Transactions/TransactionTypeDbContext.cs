using FM.SHD.Data.EfCore;
using FM.SHD.Domain.Transactions;
using Microsoft.EntityFrameworkCore;

namespace FM.SHD.Data.Transactions
{
    public class TransactionTypeDbContext : ContextBase<TransactionTypeDbContext>
    {
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }

        public TransactionTypeDbContext(string connectionString) : base(connectionString)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.ToTable("TransactionType");

                entity.HasIndex(e => e.Id, "IX_TransactionType_Id")
                    .IsUnique();

                entity.Property(e => e.Name).IsRequired();
            });
        }
    }
}