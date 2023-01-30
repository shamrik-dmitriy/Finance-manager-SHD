using FM.SHD.Infrastructure.Dal.Providers.DataBaseParameters;

namespace FM.SHD.Infrastructure.Dal.Factory
{
    public interface IConnectionSqliteStringBuilder
    {
        string Build(SqliteDatabaseParameters dataBaseParameters);

        string Build(string path, string file, int version, string password);
    }
}
