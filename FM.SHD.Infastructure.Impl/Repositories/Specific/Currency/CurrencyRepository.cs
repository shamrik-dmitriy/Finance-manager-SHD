using System;
using System.Collections.Generic;
using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.Categories.CurrencyCategory;

namespace FM.SHD.Infastructure.Impl.Repositories.Specific.Currency
{
    public class CurrencyRepository : BaseSpecificRepository, ICurrencyRepository
    {
        private const string TABLE_NAME = "Currency";

        public CurrencyRepository(string connectionString) : base(connectionString)
        {
        }
        
        public long Add(ICurrencyModel currencyModel)
        {
            if (!CheckRecordIsExist(TABLE_NAME, currencyModel.Id))
            {
                var sql =
                    $"INSERT INTO {TABLE_NAME} (Name, Symbol) " +
                    $"VALUES (@Name, @Symbol);";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Name", currencyModel.Name));
                dataparameters.Add(new DataParameter("@Symbol", currencyModel.Symbol));

                return _sqliteDataProvider.ExecuteSqlInsertCommand(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException($"В хранилище счетов уже есть запись с идентификатором {currencyModel.Id}");
        }

        public void Update(ICurrencyModel currencyModel)
        {
            if (CheckRecordIsExist(TABLE_NAME, currencyModel.Id))
            {
                var sql = $"UPDATE {TABLE_NAME} SET " +
                          $"Name = @Name, " +
                          $"Description = @Description, " +
                          $"Symbol = @Symbol " +
                          $"WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", currencyModel.Id));
                dataparameters.Add(new DataParameter("@Name", currencyModel.Name));
                dataparameters.Add(new DataParameter("@Description", currencyModel.Symbol));

                _sqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException(
                    $"В хранилище отсутствует запись с идентификатором {currencyModel.Id}");
        }

        public void Delete(ICurrencyModel currencyModel)
        {
            if (CheckRecordIsExist(TABLE_NAME, currencyModel.Id))
            {
                var sql = $"DELETE FROM {TABLE_NAME} WHERE Id=@Id;";
                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", currencyModel.Id));

                _sqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException(
                    $"В хранилище счетов отсутствует запись с идентификатором {currencyModel.Id}");
        }

        public void DeleteById(long id)
        {
            if (CheckRecordIsExist(TABLE_NAME, id))
            {
                var sql = $"DELETE FROM {TABLE_NAME} WHERE Id=@Id";
                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", id));

                _sqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException(
                    $"В хранилище счетов отсутствует запись с идентификатором {id}");
        }

        public IEnumerable<ICurrencyModel> GetAll()
        {
            var sql = $"SELECT * FROM {TABLE_NAME};";

            var account = new List<CurrencyModel>();

            using (var reader = _sqliteDataProvider.CreateReader(sql))
            {
                while (reader.Read())
                {
                    var accountModel = new CurrencyModel();
                    accountModel.Id = long.Parse(reader["Id"].ToString());
                    accountModel.Name = reader["Name"].ToString();
                    accountModel.Symbol = reader["Symbol"].ToString();
                    account.Add(accountModel);
                }
            }

            return account;
        }

        public CurrencyModel GetById(long id)
        {
            if (CheckRecordIsExist("Account", id))
            {
                var sql = $"SELECT * FROM {TABLE_NAME} WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", id));

                var currencyModel = new CurrencyModel();

                using (var reader = _sqliteDataProvider.CreateReader(sql, dataparameters.ToArray()))
                {
                    while (reader.Read())
                    {
                        currencyModel.Id = long.Parse(reader["Id"].ToString());
                        currencyModel.Name = reader["Name"].ToString();
                        currencyModel.Symbol = reader["Symbol"].ToString();
                    }

                    return currencyModel;
                }
            }

            throw new ArgumentException($"В хранилище отсутствует запись с идентификатором {id}");
        }
    }
}