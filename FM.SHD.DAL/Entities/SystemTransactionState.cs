using System;
using System.Collections.Generic;

#nullable disable

namespace FM.SHD.DAL.Entities2
{
    public partial class SystemTransactionState
    {
        public SystemTransactionState()
        {
            UsrTransactions = new HashSet<UserTransaction>();
        }

        public long Id { get; set; }
        public long DisplayNameState { get; set; }

        public virtual ICollection<UserTransaction> UsrTransactions { get; set; }
    }
}
