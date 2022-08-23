using FM.SHD.Infastructure.Impl.Factory;
using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;
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
        private const string TABLE_NAME = "Account";
        public AccountRepository(string connectionString) : base(connectionString)
        {
        }

        public long Add(IAccountModel accountModel)
        {
            if (!CheckRecordIsExist(TABLE_NAME, accountModel.Id))
            {
                var sql =
                    $"INSERT INTO {TABLE_NAME} (Name, Description, CurrentSum, InitialSum, IsClosed, CurrencyId, CategoryId, IdentityId) " +
                    $"VALUES (@Name, @Description, @CurrentSum, @InitialSum, @IsClosed, @CurrencyId, @CategoryId, @IdentityId);";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Name", accountModel.Name));
                dataparameters.Add(new DataParameter("@Description", accountModel.Description));
                dataparameters.Add(new DataParameter("@CurrentSum", accountModel.CurrentSum));
                dataparameters.Add(new DataParameter("@InitialSum", accountModel.InitialSum));
                dataparameters.Add(new DataParameter("@IsClosed", accountModel.IsClosed));
                dataparameters.Add(new DataParameter("@CurrencyId", accountModel.CurrencyId));
                dataparameters.Add(new DataParameter("@CategoryId", accountModel.CategoryId));
                dataparameters.Add(new DataParameter("@IdentityId", accountModel.IdentityId));

                return _sqliteDataProvider.ExecuteSqlInsertCommand(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException($"В хранилище счетов уже есть запись с идентификатором {accountModel.Id}");
        }

        public void Delete(IAccountModel accountModel)
        {
            if (CheckRecordIsExist(TABLE_NAME, accountModel.Id))
            {
                var sql = $"DELETE FROM {TABLE_NAME} WHERE Id=@Id;";
                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", accountModel.Id));

                _sqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException(
                    $"В хранилище счетов отсутствует запись с идентификатором {accountModel.Id}");
        }

        public void DeleteById(long accountModelId)
        {
            if (CheckRecordIsExist(TABLE_NAME, accountModelId))
            {
                var sql = $"DELETE FROM {TABLE_NAME} WHERE Id=@Id";
                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", accountModelId));

                _sqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException(
                    $"В хранилище счетов отсутствует запись с идентификатором {accountModelId}");
        }

        public IEnumerable<IAccountModel> GetAll()
        {
            var sql = $"SELECT * FROM {TABLE_NAME};";

            var account = new List<AccountModel>();

            using (var reader = _sqliteDataProvider.CreateReader(sql))
            {
                while (reader.Read())
                {
                    var accountModel = new AccountModel();
                    accountModel.Id = long.Parse(reader["Id"].ToString());
                    accountModel.Name = reader["Name"].ToString();
                    accountModel.Description = reader["Description"].ToString();
                    accountModel.CurrentSum = decimal.Parse(reader["CurrentSum"].ToString());
                    accountModel.InitialSum = decimal.Parse(reader["InitialSum"].ToString());
                    accountModel.IsClosed = Convert.ToBoolean(reader["IsClosed"]);
                    accountModel.CurrencyId = long.Parse(reader["CurrencyId"].ToString());
                    accountModel.CategoryId = int.Parse(reader["CategoryId"].ToString());
                    accountModel.IdentityId = int.Parse(reader["IdentityId"].ToString());
                    account.Add(accountModel);
                }
            }

            return account;
        }

        public AccountModel GetById(long id)
        {
            if (CheckRecordIsExist(TABLE_NAME, id))
            {
                var sql = $"SELECT * FROM {TABLE_NAME} WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", id));

                var accountModel = new AccountModel();

                using (var reader = _sqliteDataProvider.CreateReader(sql, dataparameters.ToArray()))
                {
                    while (reader.Read())
                    {
                        accountModel.Id = long.Parse(reader["Id"].ToString());
                        accountModel.Name = reader["Name"].ToString();
                        accountModel.Description = reader["Description"].ToString();
                        accountModel.CurrentSum = (decimal)reader["CurrentSum"];
                        accountModel.InitialSum = (decimal)reader["InitialSum"];
                        accountModel.IsClosed = (bool)reader["IsClosed"];
                        accountModel.CurrencyId = long.Parse(reader["CurrencyId"].ToString());
                        accountModel.CategoryId = (int)reader["CategoryId"];
                        accountModel.IdentityId = (int)reader["IdentityId"];
                    }

                    return accountModel;
                }
            }

            throw new ArgumentException($"В хранилище отсутствует запись с идентификатором {id}");
        }

        public void Update(IAccountModel accountModel)
        {
            if (CheckRecordIsExist(TABLE_NAME, accountModel.Id))
            {
                var sql = $"UPDATE {TABLE_NAME} SET " +
                          $"Name = @Name, " +
                          $"Description = @Description, " +
                          $"CurrentSum = @CurrentSum, " +
                          $"InitialSum = @InitialSum, " +
                          $"IsClosed = @IsClosed, " +
                          $"CurrencyId = @CurrencyId, " +
                          $"CategoryId = @CategoryId, " +
                          $"IdentityId = @IdentityId " +
                          $"WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", accountModel.Id));
                dataparameters.Add(new DataParameter("@Name", accountModel.Name));
                dataparameters.Add(new DataParameter("@Description", accountModel.Description));
                dataparameters.Add(new DataParameter("@CurrentSum", accountModel.CurrentSum));
                dataparameters.Add(new DataParameter("@InitialSum", accountModel.InitialSum));
                dataparameters.Add(new DataParameter("@IsClosed", accountModel.IsClosed));
                dataparameters.Add(new DataParameter("@CurrencyId", accountModel.CurrencyId));
                dataparameters.Add(new DataParameter("@CategoryId", accountModel.CategoryId));
                dataparameters.Add(new DataParameter("@IdentityId", accountModel.IdentityId));

                _sqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException(
                    $"В хранилище отсутствует запись с идентификатором {accountModel.Id}");
        }
    }
}