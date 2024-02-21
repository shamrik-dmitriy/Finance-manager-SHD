#nullable disable

using System.Collections.Generic;
using FM.SHD.DAL.Entities.System;

namespace FM.SHD.DAL.Entities.User
{
    public partial class UserAccount
    {
        public UserAccount()
        {
            UserReceipts = new HashSet<UserReceipt>();
            UserTransactionDebitAccounts = new HashSet<UserTransaction>();
            UserTransactionDebitCredits = new HashSet<UserTransaction>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal CurrentSum { get; set; }
        public decimal InitialSum { get; set; }
        public bool? IsPrivate { get; set; }
        public bool? IsClosed { get; set; }
        public long SysCurrencyId { get; set; }
        public long? UserCategoryId { get; set; }

        public virtual SystemCurrency SystemCurrency { get; set; }
        public virtual UserCategory UserCategory { get; set; }
        public virtual ICollection<UserReceipt> UserReceipts { get; set; }
        public virtual ICollection<UserTransaction> UserTransactionDebitAccounts { get; set; }
        public virtual ICollection<UserTransaction> UserTransactionDebitCredits { get; set; }
    }
}
