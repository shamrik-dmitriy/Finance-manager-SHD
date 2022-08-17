using System.Collections.Generic;
using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.AccountModel;

namespace FM.SHD.Infastructure.Impl.Repositories.Specific.Account
{
    public class AccountCategoryRepository : BaseSpecificRepository, IAccountCategoryRepository
    {
        public AccountCategoryRepository(string connectionString) : base(connectionString)
        {
        }

        public long Add(IAccountCategoryModel accountCategoryModel)
        {
            var sql =
                $"INSERT INTO AccountCategory (Name, Description) " +
                $"VALUES (@Name, @Description);";

            var dataparameters = new List<DataParameter>();
            dataparameters.Add(new DataParameter("@Name", accountCategoryModel.Name));
            dataparameters.Add(new DataParameter("@Description", accountCategoryModel.Description));

            return _sqliteDataProvider.ExecuteSqlInsertCommand(sql, dataparameters.ToArray());
        }

        public void Update(IAccountCategoryModel accountCategoryModel)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(IAccountCategoryModel accountCategoryModel)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteById(long accountCategoryModel)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IAccountCategoryModel> GetAll()
        {
            var sql = $"SELECT * FROM AccountCategory;";

            var account = new List<AccountCategoryModel>();

            using (var reader = _sqliteDataProvider.CreateReader(sql))
            {
                while (reader.Read())
                {
                    var accountModel = new AccountCategoryModel();
                    accountModel.Id = long.Parse(reader["Id"].ToString());
                    accountModel.Name = reader["Name"].ToString();
                    accountModel.Description = reader["Description"].ToString();
                    account.Add(accountModel);
                }
            }

            return account;
        }

        public IAccountCategoryModel GetById(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}