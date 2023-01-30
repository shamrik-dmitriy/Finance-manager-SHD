using FM.SHD.Infrastructure.Dal.Factory;
using FM.SHD.Infrastructure.Dal.Providers.DataBaseParameters;

namespace FM.SHD.Infastructure.Impl.Factory
{
    public class SqliteConnectionStringBuilder : IConnectionSqliteStringBuilder
    {

        public string Build(SqliteDatabaseParameters dataBaseParameters)
        {
            var stringBuilder = new Microsoft.Data.Sqlite.SqliteConnectionStringBuilder
            {
                DataSource = $"{dataBaseParameters.Path}{dataBaseParameters.File}",
                Password = dataBaseParameters.Password,
            };
            return stringBuilder.ToString();
        }

        public string Build(string path, string fileName, int version, string password)
        {
            return $"Data Source={path}{fileName};{version};Password={password};";
        }
    }
}
