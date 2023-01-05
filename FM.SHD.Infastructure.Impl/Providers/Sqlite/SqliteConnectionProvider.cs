using FM.SHD.Infrastructure.Dal.Providers.DataBaseParameters;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FM.SHD.Infrastructure.Dal;

namespace FM.SHD.Infastructure.Impl.Providers.Sqlite
{
    internal class SqliteConnectionProvider : IConnection
    {
        #region Private member variables

        private readonly Lazy<SqliteConnection> _connection;
        private readonly Lazy<SqliteDataProvider> _dataProvider;
        private readonly List<SqliteTransactionProvider> _transactions = new List<SqliteTransactionProvider>();
        private bool _isDisposingOpenTransaction = false;
        private bool _disposed;

        #endregion

        #region Public properties

        public SqliteConnection Connection => _connection.Value;

        public IDataProvider DataProvider
        {
            get
            {
                if (_disposed)
                    throw new DataException("Попытка получить IDataProvider при разрушенном соединении");
                return _dataProvider.Value;
            }
        }

        #endregion

        #region Constructors / Destructors

        public SqliteConnectionProvider(SqliteDatabaseParameters dataBaseParameters)
        {
            _connection = new Lazy<SqliteConnection>(() => new SqliteConnection(dataBaseParameters.ToSqliteString()));

            _dataProvider = new Lazy<SqliteDataProvider>(() => new SqliteDataProvider(Connection));
        }

        public SqliteConnectionProvider(ConnectionString connectionString)
        {
            if (File.Exists(connectionString.GetPath()))
            {
                if (string.IsNullOrWhiteSpace(connectionString.GetPath()))
                    throw new ArgumentNullException(nameof(connectionString));

                _connection = new Lazy<SqliteConnection>(() => new SqliteConnection(connectionString.GetConnectionString()));

                _dataProvider = new Lazy<SqliteDataProvider>(() => new SqliteDataProvider(Connection));
            }
            else
            {
                throw new FileNotFoundException($"Файл {connectionString.GetPath()} не найден. Возможно, он был удалён или перемещён");
            }
        }

        ~SqliteConnectionProvider()
        {
            Dispose(false);
        }

        #endregion

        #region Public methods

        public ITransaction BeginTransaction()
        {
            if (_disposed)
                throw new ObjectDisposedException("Sqlite",
                    "Невозможно создать транзакцию для уничтоженного соединения");
            var sqliteTransaction = new SqliteTransactionProvider(Connection);
            _transactions.Add(sqliteTransaction);

            sqliteTransaction.Disposed += (s, e) =>
            {
                if (!this._isDisposingOpenTransaction)
                    _transactions.Remove(sqliteTransaction);
            };
            return sqliteTransaction;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Private methods

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;
            if (!disposing)
            {
                string message = string.Format("{0}{1}{2}{3}",
                    "----------------------------- not disposed connection ------------------------",
                    Environment.NewLine, "Call Stack: ", Environment.StackTrace);
            }

            _disposed = true;
            if (disposing)
            {
                if (_transactions.Count > 0)
                {
                    _isDisposingOpenTransaction = true;
                    _transactions.ForEach(o => o.Dispose());
                }

                if (_connection.IsValueCreated)
                {
                    if (_connection.Value.State == ConnectionState.Open)
                        _connection.Value.Close();
                    _connection.Value.Dispose();
                }
            }
        }

        #endregion
    }
}