using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infastructure.Impl.Providers
{
    internal enum TransactionState
    {
        Open,
        Rollbacked,
        Error,
        Commited
    }
}
