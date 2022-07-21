using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;
using Microsoft.Data.Sqlite;
using System;
using System.Data;

namespace FM.SHD.Infastructure.Impl.DataProvider
{
    public class SqliteDataProvider : IDataProvider
    {
        private readonly SqliteConnection _connection;
        private readonly SqliteTransaction _transaction;

        public SqliteConnection Connection => _connection;

        #region Constructors

        public SqliteDataProvider(SqliteConnection sqliteConnection)
        {
            if (sqliteConnection == null)
                throw new ArgumentNullException(nameof(sqliteConnection));
            _connection = sqliteConnection;
        }


        public SqliteDataProvider(SqliteTransaction sqliteTransaction)
        {
            if (sqliteTransaction == null)
                throw new ArgumentNullException(nameof(sqliteTransaction));
            _transaction = sqliteTransaction;
            _connection = _transaction.Connection;
        }

        #endregion

        #region Public methods

        public DataTable ExecuteQuery(string sql, int startIndex, int count, params DataParameter[] parameters)
        {
            if (count > 0)
                sql = string.Format("{0} offset {1} limit {2}", sql, startIndex, count);

            using (SqliteCommand command = CreateCommand(parameters))
            {
                var dataTable = new DataTable();

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                try
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                    return dataTable;
                }
                catch (SqliteException sqliteException)
                {
                    throw new DataProviderException("Ошибка при выполнении запроса", sqliteException);
                }
                catch (Exception exception)
                {
                    throw;
                }
            }
        }

        public void ExecuteNonQuery(string sqlCommand, params DataParameter[] parameters)
        {
            using (SqliteCommand command = CreateCommand(parameters))
            {
                command.CommandText = sqlCommand;
                command.CommandType = CommandType.Text;
                try
                {
                    using (new LongRunningQueryDetector(() => sqlCommand, () => parameters))
                        command.ExecuteNonQuery();
                }
                catch (SqliteException exception)
                {
                    throw new DataProviderException($"Ошибка при выполнении SQL-команды: {exception.Message}", exception);
                }
            }
        }

        public long ExecuteSqlInsertCommand(string sqlCommand, params DataParameter[] parameters)
        {
            using (SqliteCommand command = CreateCommand(parameters))
            {
                command.CommandText = sqlCommand + " returning id";
                command.CommandType = CommandType.Text;
                try
                {
                    using (new LongRunningQueryDetector(() => sqlCommand, () => parameters))
                        return Convert.ToInt64(command.ExecuteScalar());
                }
                catch (SqliteException ex)
                {
                    throw new DataProviderException($"Ошибка при выполнении SQL-команды: {ex.Message}", ex);
                }
            }
        }

        public object ExecuteScalar(string sql, params DataParameter[] parameters)
        {
            using (SqliteCommand command = CreateCommand(parameters))
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                try
                {
                    using (new LongRunningQueryDetector(() => sql, () => parameters))
                        return command.ExecuteScalar();
                }
                catch (SqliteException exception)
                {
                    throw new DataProviderException("Ошибка при выполнении запроса", exception);
                }
            }
        }

        #endregion

        #region Private methods

        private void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        private SqliteCommand CreateCommand(params DataParameter[] parameters)
        {
            OpenConnection();

            var command = Connection.CreateCommand();

            if (_transaction != null)
                command.Transaction = _transaction;

            foreach (var dataParameter in parameters)
            {
                var sqliteParameter = command.CreateParameter();
                sqliteParameter.ParameterName = dataParameter.Name;

                if (dataParameter.Value == DBNull.Value || dataParameter.Value == null)
                    sqliteParameter.Value = DBNull.Value;
                else
                {
                    sqliteParameter.DbType = TypeParameterConverter.ToDbType(dataParameter.DataType);
                    sqliteParameter.Value = dataParameter.Value;
                }
                command.Parameters.Add(sqliteParameter);
            }
            return command;
        }

        #endregion
    }
}
