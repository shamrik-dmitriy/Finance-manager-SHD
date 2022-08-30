using FM.SHD.Infastructure.Impl.Providers.Sqlite;
using FM.SHD.Infrastructure.Dal.Factory;
using FM.SHD.Infrastructure.Dal.Providers.DataBaseParameters;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;

namespace FM.SHD.Infastructure.Impl.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private string _connectionString;
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

        public void ConfigureConnection(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public SqliteDatabaseParameters Parameters =>
            _sqliteConnectionFactory.GetSqliteDatabaseParameters(_connectionString);

        public IConnection CreateConnection()
        {
            return _sqliteConnectionFactory.CreateConnection(_connectionString);
        }

        public string DataBaseInfo
        {
            get
            {
             var parameters = Parameters;
             return $"{parameters.File} : {parameters.Path}";
            }
        }
        
        public string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }
    }
}