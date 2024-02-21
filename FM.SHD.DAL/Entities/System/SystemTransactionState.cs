#nullable disable

using System.Collections.Generic;
using FM.SHD.DAL.Entities.User;

namespace FM.SHD.DAL.Entities.System
{
    public partial class SystemTransactionState
    {
        public SystemTransactionState()
        {
            UserTransactions = new HashSet<UserTransaction>();
        }

        public long Id { get; set; }
        public string DisplayNameState { get; set; }

        public virtual ICollection<UserTransaction> UserTransactions { get; set; }
    }
}
