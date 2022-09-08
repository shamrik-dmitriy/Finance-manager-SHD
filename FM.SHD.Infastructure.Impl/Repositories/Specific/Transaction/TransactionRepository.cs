using System;
using System.Collections.Generic;
using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;

namespace FM.SHD.Infastructure.Impl.Repositories.Specific.Transaction
{
    public class TransactionRepository : BaseSpecificRepository, ITransactionRepository
    {
        private const string TABLE_NAME = "Transactions";

        public TransactionRepository(IRepositoryManager repositoryManager) : base(repositoryManager)
        {
        }

        public long Add(ITransactionModel transactionModel)
        {
            var sql =
                $"INSERT INTO {TABLE_NAME} (Type_id, Name, Description, DebitAccount_id, CreditAccount_id, Sum, Date, Category_id, Contragent_id, Identity_id, Receipt_id) " +
                $"VALUES (@Type_id, @Name, @Description, @DebitAccount_id, @CreditAccount_id, @Sum, @Date, @Category_id, @Contragent_id, @Identity_id, @Receipt_id);";

            var dataparameters = new List<DataParameter>();
            dataparameters.Add(new DataParameter("@Type_id", transactionModel.TypeTransactionId));
            dataparameters.Add(new DataParameter("@Name", transactionModel.Name));
            dataparameters.Add(new DataParameter("@Description", transactionModel.Description));
            dataparameters.Add(new DataParameter("@DebitAccount_id", transactionModel.DebitAccountId));
            dataparameters.Add(new DataParameter("@CreditAccount_id", transactionModel.CreditAccountId));
            dataparameters.Add(new DataParameter("@Sum", transactionModel.Sum));
            dataparameters.Add(new DataParameter("@Date", transactionModel.Date));
            dataparameters.Add(new DataParameter("@Category_id", transactionModel.CategoryId));
            dataparameters.Add(new DataParameter("@Contragent_id", transactionModel.ContragentId));
            dataparameters.Add(new DataParameter("@Identity_id", transactionModel.IdentityId));
            dataparameters.Add(new DataParameter("@Receipt_id", transactionModel.ReceiptId));

            return SqliteDataProvider.ExecuteSqlInsertCommand(sql, dataparameters.ToArray());
        }

        public void Delete(ITransactionModel transactionModel)
        {
            if (CheckRecordIsExist(TABLE_NAME, transactionModel.Id))
            {
                var sql = $"DELETE FROM {TABLE_NAME} WHERE Id=@Id;";
                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", transactionModel.Id));

                SqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException(
                    $"В хранилище отсутствует запись с идентификатором {transactionModel.Id}");
        }

        public void DeleteById(int transactionId)
        {
            if (CheckRecordIsExist(TABLE_NAME, transactionId))
            {
                var sql = $"DELETE FROM {TABLE_NAME} WHERE Id=@Id";
                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", transactionId));

                SqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException($"В хранилище отсутствует запись с идентификатором {transactionId}");
        }

        public IEnumerable<ITransactionModel> GetAll()
        {
            var sql = $"SELECT * FROM {TABLE_NAME};";

            var transactions = new List<TransactionModel>();

            using (var reader = SqliteDataProvider.CreateReader(sql))
            {
                while (reader.Read())
                {
                    var transactionModel = new TransactionModel();
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
                    if (reader["Receipt_id"].GetType() != typeof(DBNull))
                        transactionModel.ReceiptId = long.Parse(reader["Receipt_id"].ToString());
                    transactions.Add(transactionModel);
                }
            }

            return transactions;
        }

        public void Update(ITransactionModel transactionModel)
        {
            if (CheckRecordIsExist(TABLE_NAME, transactionModel.Id))
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
                          $"Receipt_id = @Receipt_id " +
                          $"WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", transactionModel.Id));
                dataparameters.Add(new DataParameter("@Type_id", transactionModel.TypeTransactionId));
                dataparameters.Add(new DataParameter("@Name", transactionModel.Name));
                dataparameters.Add(new DataParameter("@Description", transactionModel.Description));
                dataparameters.Add(new DataParameter("@DebitAccount_id", transactionModel.DebitAccountId));
                dataparameters.Add(new DataParameter("@CreditAccount_id", transactionModel.CreditAccountId));
                dataparameters.Add(new DataParameter("@Sum", transactionModel.Sum));
                dataparameters.Add(new DataParameter("@Date", transactionModel.Date));
                dataparameters.Add(new DataParameter("@Category_id", transactionModel.CategoryId));
                dataparameters.Add(new DataParameter("@Contragent_id", transactionModel.ContragentId));
                dataparameters.Add(new DataParameter("@Identity_id", transactionModel.IdentityId));
                dataparameters.Add(new DataParameter("@Receipt_id", transactionModel.ReceiptId));
                SqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException(
                    $"В хранилище отсутствует запись с идентификатором {transactionModel.Id}");
        }

        TransactionModel ITransactionRepository.GetById(int id)
        {
            if (CheckRecordIsExist(TABLE_NAME, id))
            {
                var sql = $"SELECT * FROM {TABLE_NAME} WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", id));

                var transactionModel = new TransactionModel();

                using (var reader = SqliteDataProvider.CreateReader(sql, dataparameters.ToArray()))
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
                        transactionModel.ReceiptId = long.Parse(reader["Receipt_id"].ToString());
                    }

                    return transactionModel;
                }
            }
            else
                throw new ArgumentException($"В хранилище отсутствует запись с идентификатором {id}");
        }

        public IEnumerable<ITransactionModel> GetAllRecordsAssociatedWithAReceipt(long receiptId)
        {
            var sql = $"SELECT * FROM {TABLE_NAME} WHERE Receipt_id=@Receipt_id;";

            var transactions = new List<TransactionModel>();

            using (var reader = SqliteDataProvider.CreateReader(sql))
            {
                while (reader.Read())
                {
                    var transactionModel = new TransactionModel();
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
                    transactionModel.ReceiptId = long.Parse(reader["Receipt_id"].ToString());
                    transactions.Add(transactionModel);
                }
            }

            return transactions;
        }

        public IEnumerable<TransactionExtendedModel> GetExtendedTransactions()
        {
            var sql =
                "SELECT t.Id, t.Name, t.Description, dac.name as debit_acc_name, cac.Name as credit_acc_name, t.Sum, t.Date, " +
                "tt.Name as transaction_type, c.Name as category_name, ct.Name as contragent_name, id.Name as identity " +
                "    FROM Transactions t " +
                "INNER JOIN TransactionType tt USING(Id) " +
                "INNER JOIN Categories c USING(Id) " +
                "INNER JOIN Contragents ct USING(Id) " +
                "INNER JOIN Account dac ON dac.Id = t.DebitAccount_id " +
                "INNER JOIN Account cac ON cac.Id = t.CreditAccount_id " +
                "INNER JOIN Identity id USING(Id)";

            var transactions = new List<TransactionExtendedModel>();

            using (var reader = SqliteDataProvider.CreateReader(sql))
            {
                while (reader.Read())
                {
                    var transactionModel = new TransactionExtendedModel();
                    transactionModel.Id = long.Parse(reader["Id"].ToString());
                    transactionModel.Name = reader["Name"].ToString();
                    transactionModel.Description = reader["Description"].ToString();
                    transactionModel.DebitAccount = reader["debit_acc_name"].ToString();
                    transactionModel.CreditAccount = reader["credit_acc_name"].ToString();
                    transactionModel.Sum = decimal.Parse(reader["Sum"].ToString());
                    transactionModel.Date = DateTime.Parse(reader["Date"].ToString());
                    transactionModel.TypeTransaction = reader["transaction_type"].ToString();
                    transactionModel.Category = reader["category_name"].ToString();
                    transactionModel.Contragent = reader["contragent_name"].ToString();
                    transactionModel.Identity = reader["identity"].ToString();
                    //transactionModel.ReceiptId = long.Parse(reader["Receipt_id"].ToString());
                    transactions.Add(transactionModel);
                }
            }

            return transactions;
        }
    }
}