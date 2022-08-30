using System;
using System.Collections.Generic;
using FM.SHD.Infastructure.Impl.Factory;
using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;

namespace FM.SHD.Infastructure.Impl.Repositories.Specific
{
    public abstract class BaseSpecificRepository
    {
        protected readonly IDataProvider SqliteDataProvider;

        protected BaseSpecificRepository(IRepositoryManager repositoryManager)
        {
            SqliteDataProvider = repositoryManager.CreateConnection().DataProvider;
        }

        protected bool CheckRecordIsExist(string tableName, long id)
        {
            var dataparameters = new List<DataParameter>();
            dataparameters.Add(new DataParameter("@Id", id));
            var rowCount =
                Convert.ToInt32(SqliteDataProvider.ExecuteScalar($"SELECT COUNT(*) FROM {tableName} WHERE Id=@Id",
                    dataparameters.ToArray()));
            return rowCount > 0;
        }

        protected bool CheckRecordIsExist(string tableName, string name)
        {
            var dataparameters = new List<DataParameter>();
            dataparameters.Add(new DataParameter("@Name", name));
            var rowCount =
                Convert.ToInt32(SqliteDataProvider.ExecuteScalar($"SELECT COUNT(*) FROM {tableName} WHERE Id=@Id",
                    dataparameters.ToArray()));
            return rowCount > 0;
        }
    }
}