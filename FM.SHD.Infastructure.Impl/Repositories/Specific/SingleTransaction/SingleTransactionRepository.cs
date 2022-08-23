using System;
using System.Collections.Generic;
using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;

namespace FM.SHD.Infastructure.Impl.Repositories.Specific.SingleTransaction
{
    public class SingleTransactionRepository : BaseSpecificRepository, ISingleTransactionRepository
    {
        private const string TABLE_NAME = "SingleTransaction";
        public SingleTransactionRepository(string connectionString) : base(connectionString)
        {
        }

        public long Add(ISingleTransactionModel singleTransactionModel)
        {
            var sql =
                $"INSERT INTO {TABLE_NAME} (Type_id, Name, Description, DebitAccount_id, CreditAccount_id, Sum, Date, Category_id, Contragent_id, Identity_id) " +
                $"VALUES (@Type_id, @Name, @Description, @DebitAccount_id, @CreditAccount_id, @Sum, @Date, @Category_id, @Contragent_id, @Identity_id);";

            var dataparameters = new List<DataParameter>();
            dataparameters.Add(new DataParameter("@Type_id", singleTransactionModel.TypeTransactionId));
            dataparameters.Add(new DataParameter("@Name", singleTransactionModel.Name));
            dataparameters.Add(new DataParameter("@Description", singleTransactionModel.Description));
            dataparameters.Add(new DataParameter("@DebitAccount_id", singleTransactionModel.DebitAccountId));
            dataparameters.Add(new DataParameter("@CreditAccount_id", singleTransactionModel.CreditAccountId));
            dataparameters.Add(new DataParameter("@Sum", singleTransactionModel.Sum));
            dataparameters.Add(new DataParameter("@Date", singleTransactionModel.Date));
            dataparameters.Add(new DataParameter("@Category_id", singleTransactionModel.CategoryId));
            dataparameters.Add(new DataParameter("@Contragent_id", singleTransactionModel.ContragentId));
            dataparameters.Add(new DataParameter("@Identity_id", singleTransactionModel.IdentityId));

            return _sqliteDataProvider.ExecuteSqlInsertCommand(sql, dataparameters.ToArray());
        }

        public void Delete(ISingleTransactionModel singleTransactionModel)
        {
            if (CheckRecordIsExist(TABLE_NAME, singleTransactionModel.Id))
            {
                var sql = $"DELETE FROM {TABLE_NAME} WHERE Id=@Id;";
                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", singleTransactionModel.Id));

                _sqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException(
                    $"В хранилище отсутствует запись с идентификатором {singleTransactionModel.Id}");
        }

        public void DeleteById(int singleTransactionId)
        {
            if (CheckRecordIsExist(TABLE_NAME, singleTransactionId))
            {
                var sql = $"DELETE FROM {TABLE_NAME} WHERE Id=@Id";
                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", singleTransactionId));

                _sqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException($"В хранилище отсутствует запись с идентификатором {singleTransactionId}");
        }

        public IEnumerable<ISingleTransactionModel> GetAll()
        {
            var sql = $"SELECT * FROM {TABLE_NAME};";

            var singleTransactions = new List<SingleTransactionModel>();

            using (var reader = _sqliteDataProvider.CreateReader(sql))
            {
                while (reader.Read())
                {
                    var transactionModel = new SingleTransactionModel();
                    transactionModel.Id = long.Parse(reader["Id"].ToString());
                    transactionModel.TypeTransactionId = int.Parse(reader["Type_id"].ToString());
                    transactionModel.Name = reader["Name"].ToString();
                    transactionModel.Description = reader["Description"].ToString();
                    transactionModel.CreditAccountId = long.Parse(reader["CreditAccount_id"].ToString());
                    transactionModel.DebitAccountId = long.Parse(reader["DebitAccount_id"].ToString());
                    transactionModel.Sum = decimal.Parse(reader["Sum"].ToString());
                    transactionModel.Date = DateTime.Parse(reader["Date"].ToString());
                    transactionModel.CategoryId = long.Parse(reader["Category_id"].ToString());
                    transactionModel.ContragentId = long.Parse(reader["Contragent_id"].ToString());
                    transactionModel.IdentityId = long.Parse(reader["Identity_id"].ToString());
                    singleTransactions.Add(transactionModel);
                }
            }

            return singleTransactions;
        }

        public void Update(ISingleTransactionModel singleTransactionModel)
        {
            if (CheckRecordIsExist(TABLE_NAME, singleTransactionModel.Id))
            {
                var sql = $"UPDATE {TABLE_NAME} SET " +
                          $"Type_id = @Type_id, " +
                          $"Name = @Name, " +
                          $"Description = @Description, " +
                          $"DebitAccount_id = @DebitAccount_id, " +
                          $"CreditAccount_id = @CreditAccount_id, " +
                          $"Sum = @Sum, " +
                          $"Date = @Date, " +
                          $"Category = @Category_id, " +
                          $"Contragent_id = @Contragent_id, " +
                          $"Identity_id = @Identity_id " +
                          $"WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", singleTransactionModel.Id));
                dataparameters.Add(new DataParameter("@Type_id", singleTransactionModel.TypeTransactionId));
                dataparameters.Add(new DataParameter("@Name", singleTransactionModel.Name));
                dataparameters.Add(new DataParameter("@Description", singleTransactionModel.Description));
                dataparameters.Add(new DataParameter("@DebitAccount_id", singleTransactionModel.DebitAccountId));
                dataparameters.Add(new DataParameter("@CreditAccount_id", singleTransactionModel.CreditAccountId));
                dataparameters.Add(new DataParameter("@Sum", singleTransactionModel.Sum));
                dataparameters.Add(new DataParameter("@Date", singleTransactionModel.Date));
                dataparameters.Add(new DataParameter("@Category_id", singleTransactionModel.CategoryId));
                dataparameters.Add(new DataParameter("@Contragent_id", singleTransactionModel.ContragentId));
                dataparameters.Add(new DataParameter("@Identity_id", singleTransactionModel.IdentityId));
                _sqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException(
                    $"В хранилище отсутствует запись с идентификатором {singleTransactionModel.Id}");
        }

        SingleTransactionModel ISingleTransactionRepository.GetById(int id)
        {
            if (CheckRecordIsExist(TABLE_NAME, id))
            {
                var sql = $"SELECT * FROM {TABLE_NAME} WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", id));

                var transactionModel = new SingleTransactionModel();

                using (var reader = _sqliteDataProvider.CreateReader(sql, dataparameters.ToArray()))
                {
                    while (reader.Read())
                    {
                        transactionModel.Id = Int64.Parse(reader["Id"].ToString());
                        transactionModel.TypeTransactionId = long.Parse(reader["Type_id"].ToString());
                        transactionModel.Name = reader["Name"].ToString();
                        transactionModel.Description = reader["Description"].ToString();
                        transactionModel.CreditAccountId = long.Parse(reader["CreditAccount_id"].ToString());
                        transactionModel.DebitAccountId = long.Parse(reader["DebitAccount_id"].ToString());
                        transactionModel.Sum = decimal.Parse(reader["Sum"].ToString());
                        transactionModel.Date = DateTime.Parse(reader["Date"].ToString());
                        transactionModel.CategoryId = long.Parse(reader["Category_id"].ToString());
                        transactionModel.ContragentId = long.Parse(reader["Contragent_id"].ToString());
                        transactionModel.IdentityId = long.Parse(reader["Identity_id"].ToString());
                    }

                    return transactionModel;
                }
            }
            else
                throw new ArgumentException($"В хранилище отсутствует запись с идентификатором {id}");
        }
    }
}