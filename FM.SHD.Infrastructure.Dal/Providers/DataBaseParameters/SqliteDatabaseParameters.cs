using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.Dal.Providers.DataBaseParameters
{
    public class SqliteDatabaseParameters
    {
        #region Public properties

        public string Path
        {
            get; private set;
        }

        public string File
        {
            get; private set;
        }

        public string Password
        {
            get; private set;
        }

        public int Version
        {
            get; private set;
        }

        #endregion

        #region Public methods

        public SqliteDatabaseParameters(string file) : this(string.Empty, file, 0, string.Empty)
        {

        }

        public SqliteDatabaseParameters(string path, string file) : this(path, file, 0, string.Empty)
        {

        }

        public SqliteDatabaseParameters(string path, string file, string password) : this(path, file, 0, password)
        {
        }

        public SqliteDatabaseParameters(string path, string file, int version, string password)
        {
            Path = path;
            File = file;
            Password = password;
            if (version != 0)
                Version = version;
        }

        public string ToSqliteString()
        {
            return $"Data Source={Path}{File};{Version};Password={Password};";
        }

        #endregion
    }
}
