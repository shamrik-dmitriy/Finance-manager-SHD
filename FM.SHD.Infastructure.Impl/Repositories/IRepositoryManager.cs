using FM.SHD.Infrastructure.Dal.Providers.DataBaseParameters;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;

namespace FM.SHD.Infastructure.Impl.Repositories
{
    public interface IRepositoryManager
    {
        SqliteDatabaseParameters Parameters { get; }

        IConnection CreateConnection();

        string DataBaseInfo { get; }
        
        string ConnectionString { get; }
        void ConfigureConnection(string connectionString);
    }
}