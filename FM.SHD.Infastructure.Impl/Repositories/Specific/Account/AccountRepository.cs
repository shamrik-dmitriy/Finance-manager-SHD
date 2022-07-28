using FM.SHD.Infastructure.Impl.Factory;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;
using FM.SHD.Infrastructure.Impl.Repositories.Specific;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.AccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infastructure.Impl.Repositories.Specific.Account
{
    public class AccountRepository : BaseSpecificRepository, IAccountRepository
    {
        private readonly IDataProvider _sqliteDataProvider;

        public AccountRepository(string connectionString)
        {
            _sqliteDataProvider = new SqliteConnectionFactory().CreateConnection(connectionString).DataProvider;
            _connectionString = connectionString;
        }

        public long Add(IAccountModel accountModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(IAccountModel accountModel)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int accountModelId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IAccountModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public AccountModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IAccountModel accountModel)
        {
            throw new NotImplementedException();
        }
    }
}
