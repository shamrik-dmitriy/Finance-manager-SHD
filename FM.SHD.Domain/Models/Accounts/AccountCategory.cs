#nullable disable

using System.Collections.Generic;

namespace FM.SHD.Domain.Accounts
{
    public partial class AccountCategory
    {
        public AccountCategory()
        {
            Accounts = new HashSet<Account>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
