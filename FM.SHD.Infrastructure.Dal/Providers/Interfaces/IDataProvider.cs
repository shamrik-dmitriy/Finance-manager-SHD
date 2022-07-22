using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.Dal.Providers.Interfaces
{
    public interface IDataProvider
    {
        DataTable ExecuteQuery(string sql, int startIndex, int count, params DataParameter[] parameters);
        void ExecuteNonQuery(string sqlCommand, params DataParameter[] parameters);
        object ExecuteScalar(string sql, params DataParameter[] parameters);
        long ExecuteSqlInsertCommand(string sqlCommand, params DataParameter[] parameters);
        IDataReader CreateReader(string sql, params DataParameter[] parameters);
    }
}
