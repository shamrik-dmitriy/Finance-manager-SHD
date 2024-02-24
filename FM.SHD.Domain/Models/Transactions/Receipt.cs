#nullable disable

using System.Collections.Generic;
using FM.SHD.Domain.Accounts;
using FM.SHD.Domain.Contragents;
using FM.SHD.Domain.Users;

namespace FM.SHD.Domain.Transactions
{
    public partial class Receipt
    {
        public Receipt()
        {
            Transactions = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        public long? ContragentId { get; set; }
        public long? IdentityId { get; set; }
        public long AccountsId { get; set; }
        public string Date { get; set; }

        public virtual Account Accounts { get; set; }
        public virtual Contragent Contragent { get; set; }
        public virtual Identity Identity { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
