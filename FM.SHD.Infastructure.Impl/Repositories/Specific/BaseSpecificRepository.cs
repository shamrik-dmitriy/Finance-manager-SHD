﻿using System;
using System.Collections.Generic;
using FM.SHD.Infastructure.Impl.Factory;
using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;

namespace FM.SHD.Infastructure.Impl.Repositories.Specific
{
    public abstract class BaseSpecificRepository
    {
        protected string _connectionString;

        protected readonly IDataProvider _sqliteDataProvider;

        public BaseSpecificRepository(string connectionString)
        {
            _sqliteDataProvider = new SqliteConnectionFactory().CreateConnection(connectionString).DataProvider;
            _connectionString = connectionString;
        }

        protected bool CheckRecordIsExist(long singleTransactionId)
        {
            var dataparameters = new List<DataParameter>();
            dataparameters.Add(new DataParameter("@Id", singleTransactionId));
            var rowCount = Convert.ToInt32(_sqliteDataProvider.ExecuteScalar("SELECT COUNT(*) FROM SingleTransaction WHERE Id=@Id", dataparameters.ToArray()));
            return rowCount > 0;
        }
    }
}
