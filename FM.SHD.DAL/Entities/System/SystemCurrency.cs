#nullable disable

using System.Collections.Generic;
using FM.SHD.DAL.Entities.User;

namespace FM.SHD.DAL.Entities.System
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
