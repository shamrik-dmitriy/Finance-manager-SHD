#nullable disable

using FM.SHD.DAL.Contexts.Configurations.System;
using FM.SHD.DAL.Contexts.Configurations.User;
using FM.SHD.DAL.Entities;
using FM.SHD.DAL.Entities.System;
using FM.SHD.DAL.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace FM.SHD.DAL.Contexts
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
        public virtual DbSet<UserTransaction> UserTransactions { get; set; }
        public virtual DbSet<UserReceipt> UserReceipts { get; set; }
        public virtual DbSet<UserCategory> UserCategories { get; set; }

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
            modelBuilder.ApplyConfiguration(new SystemCategoryTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SystemCurrencyConfiguration());
            modelBuilder.ApplyConfiguration(new SystemTransactionStateConfiguration());
            modelBuilder.ApplyConfiguration(new SystemTransactionStatusTypeConfiguration());

            modelBuilder.ApplyConfiguration(new UserCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new UserAccountConfiguration());
            modelBuilder.ApplyConfiguration(new UserTransactionConfiguration());
            modelBuilder.ApplyConfiguration(new UserReceiptConfiguration());
        }
    }
}