using FM.SHD.Infrastructure.Dal.Providers.Interfaces;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infastructure.Impl.Providers.Sqlite
{
    public class SqliteTransactionProvider : ITransaction
    {

        private readonly Lazy<SqliteTransaction> _transaction;
        private readonly Lazy<SqliteDataProvider> _provider;
        private TransactionState _state = TransactionState.Open;
        private bool _disposed;

        internal TransactionState State
        {
            get { return _state; }
        }

        public IDataProvider Provider => _provider.Value;

        public SqliteTransactionProvider(SqliteConnection sqliteConnection)
        {
            _transaction = new Lazy<SqliteTransaction>(() =>
            {
                if (sqliteConnection.State != ConnectionState.Open)
                {
                    sqliteConnection.Open();
                }
                return sqliteConnection.BeginTransaction();
            });
        }

        public void Commit()
        {
            if (State != TransactionState.Open)
                throw new DataException("Нельзя вызвать Commit() для транзакции в состоянии " + State);
            _state = TransactionState.Error;
            // TODO: Возможно, стоит добавить проверку а выполнена ли транзакция
            _transaction.Value.Commit();
            _state = TransactionState.Commited;
        }

        public void Rollback()
        {
            if (State != TransactionState.Open)
                throw new DataException("Нельзя вызввать Rollback() для транзакции в сотоянии " + State);
            _state = TransactionState.Error;
            // TODO: Возможно, стоит добавить проверку а выполнена ли транзакция
            _transaction.Value.Rollback();
            _state = TransactionState.Rollbacked;
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;
            _disposed = true;
            if (disposing)
            {
                if (State == TransactionState.Open)
                    Rollback();
            }
            OnDisposed();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public event EventHandler Disposed;

        protected virtual void OnDisposed()
        {
            var handler = Disposed;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}
