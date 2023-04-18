using FM.SHD.Data.EfCore;
using FM.SHD.Domain.Transactions;
using Microsoft.EntityFrameworkCore;

namespace FM.SHD.Data.Transactions
{
    public class TransactionStateDbContext:ContextBase<TransactionStateDbContext>
    {
        public virtual DbSet<TransactionState> TransactionStates { get; set; }

        public TransactionStateDbContext(string connectionString) : base(connectionString)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionState>(entity =>
            {
                entity.ToTable("TransactionState");

                entity.HasIndex(e => e.Id, "IX_TransactionState_Id")
                    .IsUnique();

                entity.Property(e => e.Name).IsRequired();
            });
        }
    }
}