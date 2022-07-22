using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.Dal.Providers.DataBaseParameters
{
    [Obsolete("Класс некорректно реализован. Обдумать реализацию для всех БД")]
    public class DataBaseParameters
    {
        #region Public properties

        public string DbName
        {
            get; private set;
        }

        public string UserName
        {
            get; private set;
        }

        public string Password
        {
            get; private set;
        }

        public string Server
        {
            get; private set;
        }

        public ushort Port
        {
            get; private set;
        }

        #endregion

        #region Constructors

        public DataBaseParameters()
        {
        }

        public DataBaseParameters(string dbName, string user, string password)
            : this(dbName, user, password, "")
        {
        }

        public DataBaseParameters(string dbName, string user, string password, string server)
            : this(dbName, user, password, server, 0)
        {
        }

        public DataBaseParameters(string dbName, string user, string password, string server, ushort port)
        {
            DbName = dbName;
            UserName = user;
            Password = password;
            Server = server;
            Port = port;
        }

        public string ToString()
        {
            return "";
        }

        #endregion
    }
}
