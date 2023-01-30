using System;

namespace FM.SHD.Infrastructure.Dal.Providers.Interfaces
{
    public interface ITransaction : IDisposable
    {
        IDataProvider Provider { get; }
        void Commit();
        void Rollback();
    }
}
