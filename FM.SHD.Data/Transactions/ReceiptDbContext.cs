using FM.SHD.Data.EfCore;
using FM.SHD.Domain.Transactions;
using Microsoft.EntityFrameworkCore;

namespace FM.SHD.Data.Transactions
{
    public class ReceiptDbContext:ContextBase<ReceiptDbContext>
    {
        public virtual DbSet<Receipt> Receipts { get; set; }

        public ReceiptDbContext(string connectionString) : base(connectionString)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.ToTable("Receipt");

                entity.HasIndex(e => e.Id, "IX_Receipt_Id")
                    .IsUnique();

                entity.Property(e => e.AccountsId).HasColumnName("Accounts_id");

                entity.Property(e => e.ContragentId).HasColumnName("Contragent_id");

                entity.Property(e => e.Date).IsRequired();

                entity.Property(e => e.IdentityId).HasColumnName("Identity_id");

                entity.HasOne(d => d.Accounts)
                    .WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.AccountsId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contragent)
                    .WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.ContragentId);

                entity.HasOne(d => d.Identity)
                    .WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.IdentityId);
            });
        }
    }
}