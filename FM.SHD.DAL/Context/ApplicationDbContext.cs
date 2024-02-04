using Microsoft.EntityFrameworkCore;
using FM.SHD.DAL.Entities2;

#nullable disable

namespace FM.SHD.DAL.Context
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SystemCategoryType> SystemCategoryTypes { get; set; }
        public virtual DbSet<SystemCurrency> SystemCurrencies { get; set; }
        public virtual DbSet<SystemTransactionState> SystemTransactionStates { get; set; }
        public virtual DbSet<SystemTransactionStatusType> SystemTransactionStatusTypes { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<UserCategory> UserCategories { get; set; }
        public virtual DbSet<UserReceipt> UserReceipts { get; set; }
        public virtual DbSet<UserTransaction> UserTransactions { get; set; }

        private string _connectionString;

        public void SetConnectionString(string pathToDb)
        {
            _connectionString = pathToDb;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=" + _connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SystemCategoryType>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_sys_category_types_id")
                    .IsUnique();

                entity.HasIndex(e => e.Type, "IX_sys_category_types_type")
                    .IsUnique();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<SystemCurrency>(entity =>
            {
                entity.ToTable("sys_currency");

                entity.HasIndex(e => e.Id, "IX_sys_currency_id")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "IX_sys_currency_name")
                    .IsUnique();

                entity.HasIndex(e => e.Symbol, "IX_sys_currency_symbol")
                    .IsUnique();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Symbol).IsRequired();
            });

            modelBuilder.Entity<SystemTransactionState>(entity =>
            {
                entity.HasIndex(e => e.DisplayNameState, "IX_sys_transaction_states_display_name_state")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "IX_sys_transaction_states_id")
                    .IsUnique();
            });

            modelBuilder.Entity<SystemTransactionStatusType>(entity =>
            {
                entity.HasIndex(e => e.DisplayNameStatus, "IX_sys_transaction_status_types_display_name_status")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "IX_sys_transaction_status_types_id")
                    .IsUnique();

                entity.Property(e => e.DisplayNameStatus).IsRequired();
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_usr_accounts_id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CurrentSum)
                    .HasColumnType("NUMERIC")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InitialSum)
                    .HasColumnType("NUMERIC")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsClosed).HasDefaultValueSql("0");

                entity.Property(e => e.IsPrivate).HasDefaultValueSql("0");

                entity.HasOne(d => d.SystemCurrency)
                    .WithMany(p => p.UsrAccounts)
                    .HasForeignKey(d => d.SysCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.UserCategory)
                    .WithMany(p => p.UsrAccounts)
                    .HasForeignKey(d => d.UsrCategoryId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<UserCategory>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_usr_categories_id")
                    .IsUnique();

                entity.HasOne(d => d.SystemCategoryType)
                    .WithMany(p => p.UsrCategories)
                    .HasForeignKey(d => d.SysCategoryTypeId);
            });

            modelBuilder.Entity<UserReceipt>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_usr_receipts_id")
                    .IsUnique();

                entity.Property(e => e.Date).IsRequired();

                entity.HasOne(d => d.UserAccount)
                    .WithMany(p => p.UsrReceipts)
                    .HasForeignKey(d => d.UsrAccountId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.UserCategoryContragent)
                    .WithMany(p => p.UsrReceipts)
                    .HasForeignKey(d => d.UsrCategoryContragentId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<UserTransaction>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_usr_transactions_id")
                    .IsUnique();

                entity.Property(e => e.Date).IsRequired();

                entity.Property(e => e.Sum).HasColumnType("NUMERIC");

                entity.HasOne(d => d.SystemTransactionStatesType)
                    .WithMany(p => p.UsrTransactions)
                    .HasForeignKey(d => d.SysTransactionStatesTypeId);

                entity.HasOne(d => d.UserCategoryContragent)
                    .WithMany(p => p.UsrTransactionusrCategoryContragents)
                    .HasForeignKey(d => d.UsrCategoryContragentId)
                    .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(d => d.UserCategory)
                    .WithMany(p => p.UsrTransactionusrCategories)
                    .HasForeignKey(d => d.UsrCategoryId);

                entity.HasOne(d => d.UserDebitAccount)
                    .WithMany(p => p.UsrTransactionusrDebitAccounts)
                    .HasForeignKey(d => d.UsrDebitAccountId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.UserDebitCredit)
                    .WithMany(p => p.UsrTransactionusrDebitCredits)
                    .HasForeignKey(d => d.UsrDebitCreditId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.UserReceipts)
                    .WithMany(p => p.UsrTransactions)
                    .HasForeignKey(d => d.UsrReceiptsId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}