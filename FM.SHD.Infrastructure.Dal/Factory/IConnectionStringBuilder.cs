using FM.SHD.Infrastructure.Dal.Providers.DataBaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.Dal.Factory
{
    public interface IConnectionSqliteStringBuilder
    {
        string Build(SqliteDatabaseParameters dataBaseParameters);

        string Build(string path, string file, int version, string password);
    }
}
