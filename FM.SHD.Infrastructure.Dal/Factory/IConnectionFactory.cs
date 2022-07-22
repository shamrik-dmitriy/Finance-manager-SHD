using FM.SHD.Infrastructure.Dal.Providers.DataBaseParameters;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.Dal.Factory
{
    public interface ISqliteConnectionFactory
    {
        IConnection CreateConnection(string connectionString);
        SqliteDatabaseParameters GetSqliteDatabaseParameters(string connectionString);
    }
}
