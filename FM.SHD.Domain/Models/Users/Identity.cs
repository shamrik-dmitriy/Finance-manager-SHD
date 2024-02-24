#nullable disable

using System.Collections.Generic;
using FM.SHD.Domain.Accounts;
using FM.SHD.Domain.Transactions;

namespace FM.SHD.Domain.Users
{
    public partial class Identity
    {
        public Identity()
        {
            Accounts = new HashSet<Account>();
            Receipts = new HashSet<Receipt>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
