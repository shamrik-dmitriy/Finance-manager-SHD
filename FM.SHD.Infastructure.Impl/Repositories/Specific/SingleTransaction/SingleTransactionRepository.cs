using System;
using System.Collections.Generic;
using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;

namespace FM.SHD.Infastructure.Impl.Repositories.Specific.SingleTransaction
{
    public class SingleTransactionRepository : BaseSpecificRepository, ISingleTransactionRepository
    {
        public SingleTransactionRepository(string connectionString) : base(connectionString)
        {
        }

        public long Add(ISingleTransactionModel singleTransactionModel)
        {
            if (!CheckRecordIsExist(singleTransactionModel.Id))
            {
                var sql =
                    $"INSERT INTO SingleTransaction (Type_id, Name, Description, DebitAccount, CreditAccount, Sum, Date, Category, Contragent, FamilyMember) " +
                    $"VALUES (@Type, @Name, @Description, @DebitAccount, @CreditAccount,, @Sum, @Date, @Category, @Contragent, @FamilyMember);";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Type", singleTransactionModel.TypeTransaction));
                dataparameters.Add(new DataParameter("@Name", singleTransactionModel.Name));
                dataparameters.Add(new DataParameter("@Description", singleTransactionModel.Description));
                dataparameters.Add(new DataParameter("@DebitAccount", singleTransactionModel.DebitAccount));
                dataparameters.Add(new DataParameter("@CreditAccount", singleTransactionModel.CreditAccount));
                dataparameters.Add(new DataParameter("@Sum", singleTransactionModel.Sum));
                dataparameters.Add(new DataParameter("@Date", singleTransactionModel.Date));
                dataparameters.Add(new DataParameter("@Category", singleTransactionModel.Category));
                dataparameters.Add(new DataParameter("@Contragent", singleTransactionModel.Contragent));
                dataparameters.Add(new DataParameter("@FamilyMember", singleTransactionModel.FamilyMember));

                return _sqliteDataProvider.ExecuteSqlInsertCommand(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException(
                    $"В хранилище уже есть запись с идентификатором {singleTransactionModel.Id}");
        }

        public void Delete(ISingleTransactionModel singleTransactionModel)
        {
            if (CheckRecordIsExist(singleTransactionModel.Id))
            {
                var sql = $"DELETE FROM SingleTransaction WHERE Id=@Id;";
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
            if (CheckRecordIsExist(singleTransactionId))
            {
                var sql = $"DELETE FROM SingleTransaction WHERE Id=@Id";
                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", singleTransactionId));

                _sqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException($"В хранилище отсутствует запись с идентификатором {singleTransactionId}");
        }

        public IEnumerable<ISingleTransactionModel> GetAll()
        {
            var sql = $"SELECT * FROM SingleTransaction;";

            var singleTransactions = new List<SingleTransactionModel>();

            using (var reader = _sqliteDataProvider.CreateReader(sql))
            {
                while (reader.Read())
                {
                    var transactionModel = new SingleTransactionModel();
                    transactionModel.Id = long.Parse(reader["Id"].ToString());
                    transactionModel.TypeTransaction = int.Parse(reader["Type"].ToString());
                    transactionModel.Name = reader["Name"].ToString();
                    transactionModel.Description = reader["Description"].ToString();
                    transactionModel.CreditAccount = reader["CreditAccount"].ToString();
                    transactionModel.DebitAccount = reader["DebitAccount"].ToString();
                    transactionModel.Sum = decimal.Parse(reader["Sum"].ToString());
                    transactionModel.Date = DateTime.Parse(reader["Date"].ToString());
                    transactionModel.Category = reader["Category"].ToString();
                    transactionModel.Contragent = reader["Contragent"].ToString();
                    transactionModel.FamilyMember = reader["FamilyMember"].ToString();
                    singleTransactions.Add(transactionModel);
                }
            }

            return singleTransactions;
        }

        public void Update(ISingleTransactionModel singleTransactionModel)
        {
            if (CheckRecordIsExist(singleTransactionModel.Id))
            {
                var sql = $"UPDATE SingleTransaction SET " +
                          $"Type_id = @TypeTransaction, " +
                          $"Name = @Name, " +
                          $"Description = @Description, " +
                          $"DebitAccount = @DebitAccount, " +
                          $"CreditAccount = @CreditAccount, " +
                          $"Sum = @Sum, " +
                          $"Date = @Date, " +
                          $"Category = @Category, " +
                          $"Contragent = @Contragent, " +
                          $"FamilyMember = @FamilyMember " +
                          $"WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", singleTransactionModel.Id));
                dataparameters.Add(new DataParameter("@TypeTransaction", singleTransactionModel.TypeTransaction));
                dataparameters.Add(new DataParameter("@Name", singleTransactionModel.Name));
                dataparameters.Add(new DataParameter("@Description", singleTransactionModel.Description));
                dataparameters.Add(new DataParameter("@DebitAccount", singleTransactionModel.DebitAccount));
                dataparameters.Add(new DataParameter("@CreditAccount", singleTransactionModel.CreditAccount));
                dataparameters.Add(new DataParameter("@Sum", singleTransactionModel.Sum));
                dataparameters.Add(new DataParameter("@Date", singleTransactionModel.Date));
                dataparameters.Add(new DataParameter("@Category", singleTransactionModel.Category));
                dataparameters.Add(new DataParameter("@Contragent", singleTransactionModel.Contragent));
                dataparameters.Add(new DataParameter("@FamilyMember", singleTransactionModel.FamilyMember));

                _sqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException(
                    $"В хранилище отсутствует запись с идентификатором {singleTransactionModel.Id}");
        }

        SingleTransactionModel ISingleTransactionRepository.GetById(int id)
        {
            if (CheckRecordIsExist(id))
            {
                var sql = $"SELECT * FROM SingleTransaction WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", id));

                var transactionModel = new SingleTransactionModel();

                using (var reader = _sqliteDataProvider.CreateReader(sql, dataparameters.ToArray()))
                {
                    while (reader.Read())
                    {
                        transactionModel.Id = Int64.Parse(reader["Id"].ToString());
                        transactionModel.TypeTransaction = int.Parse(reader["Type_id"].ToString());
                        transactionModel.Name = reader["Name"].ToString();
                        transactionModel.Description = reader["Description"].ToString();
                        transactionModel.CreditAccount = reader["CreditAccount"].ToString();
                        transactionModel.DebitAccount = reader["DebitAccount"].ToString();
                        transactionModel.Sum = decimal.Parse(reader["Sum"].ToString());
                        transactionModel.Date = DateTime.Parse(reader["Date"].ToString());
                        transactionModel.Category = reader["Category"].ToString();
                        transactionModel.Contragent = reader["Contragent"].ToString();
                        transactionModel.FamilyMember = reader["FamilyMember"].ToString();
                    }

                    return transactionModel;
                }
            }
            else
                throw new ArgumentException($"В хранилище отсутствует запись с идентификатором {id}");
        }
    }
}