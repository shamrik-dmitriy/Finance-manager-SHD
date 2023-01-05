using FM.SHD.Infrastructure.Dal;
using FM.SHD.Infrastructure.Dal.Providers.DataBaseParameters;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;

namespace FM.SHD.Infastructure.Impl.Repositories
{
    public interface IRepositoryManager
    {
        SqliteDatabaseParameters Parameters { get; }

        IConnection CreateConnection();

        string DataBaseInfo { get; }
        
        ConnectionString ConnectionString { get; }
        void ConfigureConnection(ConnectionString connectionString);
    }
}