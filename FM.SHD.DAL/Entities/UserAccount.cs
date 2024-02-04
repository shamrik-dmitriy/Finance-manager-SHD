using System;
using System.Collections.Generic;

#nullable disable

namespace FM.SHD.DAL.Entities2
{
    public partial class UserAccount
    {
        public UserAccount()
        {
            UsrReceipts = new HashSet<UserReceipt>();
            UsrTransactionusrDebitAccounts = new HashSet<UserTransaction>();
            UsrTransactionusrDebitCredits = new HashSet<UserTransaction>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] CurrentSum { get; set; }
        public byte[] InitialSum { get; set; }
        public long? IsPrivate { get; set; }
        public long? IsClosed { get; set; }
        public long SysCurrencyId { get; set; }
        public long? UsrCategoryId { get; set; }

        public virtual SystemCurrency SystemCurrency { get; set; }
        public virtual UserCategory UserCategory { get; set; }
        public virtual ICollection<UserReceipt> UsrReceipts { get; set; }
        public virtual ICollection<UserTransaction> UsrTransactionusrDebitAccounts { get; set; }
        public virtual ICollection<UserTransaction> UsrTransactionusrDebitCredits { get; set; }
    }
}
