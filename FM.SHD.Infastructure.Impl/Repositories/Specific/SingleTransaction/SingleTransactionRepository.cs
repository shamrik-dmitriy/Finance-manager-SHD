using FM.SHD.Infastructure.Impl.Factory;
using FM.SHD.Infrastructure.Dal.Factory;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;
using FM.SHD.Services.SingleTransactionServices;
using System;
using System.Collections.Generic;
using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;

namespace FM.SHD.Infrastructure.Impl.Repositories.Specific.SingleTransaction
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
                var sql = $"INSERT INTO SingleTransaction (Type, Name, Description, Account, Sum, Date, Category, Contragent, FamilyMember) " +
                  $"VALUES (@Type, @Name, @Description, @Account, @Sum, @Date, @Category, @Contragent, @FamilyMember);";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Type", singleTransactionModel.Type));
                dataparameters.Add(new DataParameter("@Name", singleTransactionModel.Name));
                dataparameters.Add(new DataParameter("@Description", singleTransactionModel.Description));
                dataparameters.Add(new DataParameter("@Account", singleTransactionModel.Account));
                dataparameters.Add(new DataParameter("@Sum", singleTransactionModel.Sum));
                dataparameters.Add(new DataParameter("@Date", singleTransactionModel.Date));
                dataparameters.Add(new DataParameter("@Category", singleTransactionModel.Category));
                dataparameters.Add(new DataParameter("@Contragent", singleTransactionModel.Contragent));
                dataparameters.Add(new DataParameter("@FamilyMember", singleTransactionModel.FamilyMember));

                return _sqliteDataProvider.ExecuteSqlInsertCommand(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException($"В хранилище уже есть запись с идентификатором {singleTransactionModel.Id}");
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
                throw new ArgumentException($"В хранилище отсутствует запись с идентификатором {singleTransactionModel.Id}");
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
                    transactionModel.Id = Int64.Parse(reader["Id"].ToString());
                    transactionModel.Type = reader["Type"].ToString();
                    transactionModel.Name = reader["Name"].ToString();
                    transactionModel.Description = reader["Description"].ToString();
                    transactionModel.Account = reader["Account"].ToString();
                    transactionModel.Sum = reader["Sum"].ToString();
                    transactionModel.Date = reader["Date"].ToString();
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
                    $"Type = @Type, " +
                    $"Name = @Name, " +
                    $"Description = @Description, " +
                    $"Account = @Account, " +
                    $"Sum = @Sum, " +
                    $"Date = @Date, " +
                    $"Category = @Category, " +
                    $"Contragent = @Contragent, " +
                    $"FamilyMember = @FamilyMember " +
                    $"WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", singleTransactionModel.Id));
                dataparameters.Add(new DataParameter("@Type", singleTransactionModel.Type));
                dataparameters.Add(new DataParameter("@Name", singleTransactionModel.Name));
                dataparameters.Add(new DataParameter("@Description", singleTransactionModel.Description));
                dataparameters.Add(new DataParameter("@Account", singleTransactionModel.Account));
                dataparameters.Add(new DataParameter("@Sum", singleTransactionModel.Sum));
                dataparameters.Add(new DataParameter("@Date", singleTransactionModel.Date));
                dataparameters.Add(new DataParameter("@Category", singleTransactionModel.Category));
                dataparameters.Add(new DataParameter("@Contragent", singleTransactionModel.Contragent));
                dataparameters.Add(new DataParameter("@FamilyMember", singleTransactionModel.FamilyMember));

                _sqliteDataProvider.ExecuteNonQuery(sql, dataparameters.ToArray());
            }
            else
                throw new ArgumentException($"В хранилище отсутствует запись с идентификатором {singleTransactionModel.Id}");
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
                        transactionModel.Type = reader["Type"].ToString();
                        transactionModel.Name = reader["Name"].ToString();
                        transactionModel.Description = reader["Description"].ToString();
                        transactionModel.Account = reader["Account"].ToString();
                        transactionModel.Sum = reader["Sum"].ToString();
                        transactionModel.Date = reader["Date"].ToString();
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
