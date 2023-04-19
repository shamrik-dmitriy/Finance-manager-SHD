

#nullable disable

using System;
using FM.SHD.Domain.Accounts;
using FM.SHD.Domain.Categories;
using FM.SHD.Domain.Contragents;
using FM.SHD.Domain.Currencies;
using FM.SHD.Domain.Transactions;
using FM.SHD.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace FM.SHD.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string _connectionString;

        public ApplicationDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountCategory> AccountCategories { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Domain.Contragents.Contragent> Contragents { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Identity> Identities { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransactionState> TransactionStates { get; set; }
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source="+_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.CurrencyId)
                    .IsRequired()
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.IsClosed).HasColumnType("NUMERIC");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Identity)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.IdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AccountCategory>(entity =>
            {
                entity.ToTable("AccountCategory");

                entity.HasIndex(e => e.Id, "IX_AccountCategory_Id")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("NUMERIC");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_Categories_Id")
                    .IsUnique();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Domain.Contragents.Contragent>(entity =>
            {
                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.HasIndex(e => e.Id, "IX_Currency_Id")
                    .IsUnique();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Symbol).IsRequired();
            });

            modelBuilder.Entity<Identity>(entity =>
            {
                entity.ToTable("Identity");

                entity.HasIndex(e => e.Id, "IX_Identity_Id")
                    .IsUnique();
            });

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

            modelBuilder.Entity<TransactionState>(entity =>
            {
                entity.ToTable("TransactionState");

                entity.HasIndex(e => e.Id, "IX_TransactionState_Id")
                    .IsUnique();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.ToTable("TransactionType");

                entity.HasIndex(e => e.Id, "IX_TransactionType_Id")
                    .IsUnique();

                entity.Property(e => e.Name).IsRequired();
            });

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
