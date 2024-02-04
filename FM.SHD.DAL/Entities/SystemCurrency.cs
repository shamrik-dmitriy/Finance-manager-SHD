using System;
using System.Collections.Generic;

#nullable disable

namespace FM.SHD.DAL.Entities2
{
    public partial class SystemCurrency
    {
        public SystemCurrency()
        {
            UsrAccounts = new HashSet<UserAccount>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public virtual ICollection<UserAccount> UsrAccounts { get; set; }
    }
}
