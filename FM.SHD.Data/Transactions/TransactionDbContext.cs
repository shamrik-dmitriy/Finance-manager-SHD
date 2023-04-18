using FM.SHD.Data.EfCore;
using FM.SHD.Domain.Transactions;
using Microsoft.EntityFrameworkCore;

namespace FM.SHD.Data.Transactions
{
    public class TransactionDbContext : ContextBase<TransactionDbContext>
    {
        public virtual DbSet<Transaction> Transactions { get; set; }

        public TransactionDbContext(string connectionString) : base(connectionString)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_Transactions_Id")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Id_index");

                entity.Property(e => e.CategoryId).HasColumnName("Category_id");

                entity.Property(e => e.ContragentId).HasColumnName("Contragent_id");

                entity.Property(e => e.CreditAccountId).HasColumnName("CreditAccount_id");

                entity.Property(e => e.Date).IsRequired();

                entity.Property(e => e.DebitAccountId).HasColumnName("DebitAccount_id");

                entity.Property(e => e.IdentityId).HasColumnName("Identity_id");

                entity.Property(e => e.ReceiptId).HasColumnName("Receipt_id");

                entity.Property(e => e.Sum).HasDefaultValueSql("0");

                entity.Property(e => e.TypeId).HasColumnName("Type_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.CreditAccount)
                    .WithMany(p => p.TransactionCreditAccounts)
                    .HasForeignKey(d => d.CreditAccountId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.DebitAccount)
                    .WithMany(p => p.TransactionDebitAccounts)
                    .HasForeignKey(d => d.DebitAccountId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Receipt)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.ReceiptId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}