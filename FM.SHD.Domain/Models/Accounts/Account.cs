#nullable disable

using System.Collections.Generic;
using FM.SHD.Domain.Transactions;
using FM.SHD.Domain.Users;

namespace FM.SHD.Domain.Accounts
{
    public partial class Account
    {
        public Account()
        {
            Receipts = new HashSet<Receipt>();
            TransactionCreditAccounts = new HashSet<Transaction>();
            TransactionDebitAccounts = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CurrentSum { get; set; }
        public string InitialSum { get; set; }
        public bool IsClosed { get; set; }
        public long CurrencyId { get; set; }
        public long? CategoryId { get; set; }
        public long IdentityId { get; set; }

        public virtual AccountCategory Category { get; set; }
        public virtual Identity Identity { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
        public virtual ICollection<Transaction> TransactionCreditAccounts { get; set; }
        public virtual ICollection<Transaction> TransactionDebitAccounts { get; set; }
    }
}
