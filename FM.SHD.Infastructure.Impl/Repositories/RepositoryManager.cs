using FM.SHD.Infastructure.Impl.Providers.Sqlite;
using FM.SHD.Infrastructure.Dal;
using FM.SHD.Infrastructure.Dal.Factory;
using FM.SHD.Infrastructure.Dal.Providers.DataBaseParameters;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;

namespace FM.SHD.Infastructure.Impl.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ISqliteConnectionFactory _sqliteConnectionFactory;
        
       /* public RepositoryManager(string connectionString, ISqliteConnectionFactory sqliteConnectionFactory)
        {
            _connectionString = connectionString;
            _sqliteConnectionFactory = sqliteConnectionFactory;
        }*/

        public RepositoryManager(ISqliteConnectionFactory sqliteConnectionFactory)
        {
            _sqliteConnectionFactory = sqliteConnectionFactory;
        }

        public void ConfigureConnection(ConnectionString connectionString)
        {
            ConnectionString = connectionString;
        }
        
        public SqliteDatabaseParameters Parameters =>
            _sqliteConnectionFactory.GetSqliteDatabaseParameters(ConnectionString);

        public IConnection CreateConnection()
        {
            return _sqliteConnectionFactory.CreateConnection(ConnectionString);
        }

        public string DataBaseInfo
        {
            get
            {
             var parameters = Parameters;
             return $"{parameters.File} : {parameters.Path}";
            }
        }
        
        public ConnectionString ConnectionString { get; private set; }
        public void ConfigureConnection(string connectionString)
        {
            throw new System.NotImplementedException();
        }
    }
}