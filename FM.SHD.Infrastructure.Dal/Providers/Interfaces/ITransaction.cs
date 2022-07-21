using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.Dal.Providers.Interfaces
{
    public interface ITransaction : IDisposable
    {
        IDataProvider Provider { get; }
        void Commit();
        void Rollback();
    }
}
