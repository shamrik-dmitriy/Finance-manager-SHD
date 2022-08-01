﻿using FM.SHD.Infastructure.Impl.Factory;
using FM.SHD.Infrastructure.Dal.Providers;
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

        public AccountRepository(string connectionString) : base(connectionString)
        {

        }

        public long Add(IAccountModel accountModel)
        {
            if (!CheckRecordIsExist(accountModel.Id))
            {
                var sql = $"INSERT INTO Account (Name, Description, CurrentSum, InitialSum, IsClosed, Currency, CategoryId, IdentityId) " +
                  $"VALUES (@Name, @Description, @CurrentSum, @InitialSum, @IsClosed, @Currency, @CategoryId, @IdentityId);";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Name", accountModel.Name));
                dataparameters.Add(new DataParameter("@Description", accountModel.Description));
                dataparameters.Add(new DataParameter("@CurrentSum", accountModel.CurrentSum));
                dataparameters.Add(new DataParameter("@InitialSum", accountModel.InitialSum));
                dataparameters.Add(new DataParameter("@IsClosed", accountModel.IsClosed));
                dataparameters.Add(new DataParameter("@Currency", accountModel.Currency));
                dataparameters.Add(new DataParameter("@CategoryId", accountModel.CategoryId));
                dataparameters.Add(new DataParameter("@IdentityId", accountModel.IdentityId));

                return _sqliteDataProvider.ExecuteSqlInsertCommand(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException($"В хранилище счетов уже есть запись с идентификатором {accountModel.Id}");
        }

        public void Delete(IAccountModel accountModel)
        {
            if (CheckRecordIsExist(accountModel.Id))
            {
                var sql = $"DELETE FROM Account WHERE Id=@Id;";
                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", accountModel.Id));

                _sqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException($"В хранилище счетов отсутствует запись с идентификатором {accountModel.Id}");
        }

        public void DeleteById(int accountModelId)
        {
            if (CheckRecordIsExist(accountModelId))
            {
                var sql = $"DELETE FROM SingleTransaction WHERE Id=@Id";
                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", accountModelId));

                _sqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException($"В хранилище счетов отсутствует запись с идентификатором {accountModelId}");

        }

        public IEnumerable<IAccountModel> GetAll()
        {
            var sql = $"SELECT * FROM SingleTransaction;";

            var account = new List<IAccountModel>();

            using (var reader = _sqliteDataProvider.CreateReader(sql))
            {
                while (reader.Read())
                {
                    var accountModel = new AccountModel();
                    accountModel.Id = Int64.Parse(reader["Id"].ToString());
                    accountModel.Name = reader["Name"].ToString();
                    accountModel.Description = reader["Description"].ToString();
                    accountModel.CurrentSum = (decimal)reader["CurrentSum"];
                    accountModel.InitialSum = (decimal)reader["InitialSum"];
                    accountModel.IsClosed = (bool)reader["IsClosed"];
                    accountModel.Currency = reader["Currency"].ToString(); ;
                    accountModel.CategoryId = (int)reader["CategoryId"];
                    accountModel.IdentityId = (int)reader["IdentityId"];
                    account.Add(accountModel);
                }
            }
            return account;
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