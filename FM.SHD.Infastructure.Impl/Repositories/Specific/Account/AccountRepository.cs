using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.AccountModel;
using System;
using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Infastructure.Impl.Repositories.Specific.Account
{
    public class AccountRepository : BaseSpecificRepository, IAccountRepository
    {
        private const string TABLE_NAME = "Account";

        public AccountRepository(IRepositoryManager repositoryManager) : base(repositoryManager)
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

                return SqliteDataProvider.ExecuteSqlInsertCommand(sql, dataparameters.ToArray());
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

                SqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
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

                SqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException(
                    $"В хранилище счетов отсутствует запись с идентификатором {accountModelId}");
        }

        public IEnumerable<IAccountModel> GetAll()
        {
            var sql = $"SELECT * FROM {TABLE_NAME};";

            var account = new List<AccountModel>();

            using var reader = SqliteDataProvider.CreateReader(sql);
            while (reader.Read())
            {
                var accountModel = new AccountModel();
                //{
                accountModel.Id = reader.GetInt64(0);
                accountModel.Name = reader.GetString(1);
                accountModel.Description = reader.GetString(2);
                accountModel.CurrentSum = decimal.Parse(reader.GetString(3).Replace('.', ','));
                accountModel.InitialSum = decimal.Parse(reader.GetString(4).Replace('.', ','));
                accountModel.IsClosed = Convert.ToBoolean(reader.GetInt64(5));
                accountModel.CurrencyId = reader.GetInt64(6);
                accountModel.CategoryId = reader.GetInt64(7);
                accountModel.IdentityId = reader.GetInt64(8);
                //};
                account.Add(accountModel);
            }

            return account;
        }

        public AccountModel GetById(long id)
        {
            if (!CheckRecordIsExist(TABLE_NAME, id))
                throw new ArgumentException($"В хранилище отсутствует запись с идентификатором {id}");
            var sql = $"SELECT * FROM {TABLE_NAME} WHERE Id = @Id;";

            var dataparameters = new List<DataParameter>();
            dataparameters.Add(new DataParameter("@Id", id));

            var accountModel = new AccountModel();

            using (var reader = SqliteDataProvider.CreateReader(sql, dataparameters.ToArray()))
            {
                while (reader.Read())
                {
                    accountModel.Id = reader.GetInt64(0);
                    accountModel.Name = reader.GetString(1);
                    accountModel.Description = reader.GetString(2);
                    accountModel.CurrentSum = decimal.Parse(reader.GetString(3).Replace('.', ','));
                    accountModel.InitialSum = decimal.Parse(reader.GetString(4).Replace('.', ','));
                    accountModel.IsClosed = Convert.ToBoolean(reader.GetInt64(5));
                    accountModel.CurrencyId = reader.GetInt64(6);
                    accountModel.CategoryId = reader.GetInt64(7);
                    accountModel.IdentityId = reader.GetInt64(8);
                }

                return accountModel;
            }
        }

        public bool CheckExist(IAccountModel accountModel)
        {
            return CheckRecordIsExist(TABLE_NAME, accountModel.Id);
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

                SqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException(
                    $"В хранилище отсутствует запись с идентификатором {accountModel.Id}");
        }
    }
}