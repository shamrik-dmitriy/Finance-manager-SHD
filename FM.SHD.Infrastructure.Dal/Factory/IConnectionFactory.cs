using FM.SHD.Infrastructure.Dal.Providers.DataBaseParameters;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;

namespace FM.SHD.Infrastructure.Dal.Factory
{
    public interface ISqliteConnectionFactory
    {
        IConnection CreateConnection(ConnectionString connectionString);
        SqliteDatabaseParameters GetSqliteDatabaseParameters(ConnectionString connectionString);
    }
}
