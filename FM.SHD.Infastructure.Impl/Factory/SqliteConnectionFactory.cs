using FM.SHD.Infastructure.Impl.Providers.Sqlite;
using FM.SHD.Infrastructure.Dal.Factory;
using FM.SHD.Infrastructure.Dal.Providers.DataBaseParameters;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infastructure.Impl.Factory
{
    public class SqliteConnectionFactory : ISqliteConnectionFactory
    {
        public IConnection CreateConnection(string connectionString)
        {
            return new SqliteConnectionProvider(connectionString);
        }

        public SqliteDatabaseParameters GetSqliteDatabaseParameters(string connectionString)
        {
            var dataSource = new SqliteConnection(connectionString);
            var builder = dataSource.DataSource.Split(';');
            return new SqliteDatabaseParameters(builder[0], builder[1], Convert.ToInt32(builder[2]), builder[3]);
        }
    }
}
