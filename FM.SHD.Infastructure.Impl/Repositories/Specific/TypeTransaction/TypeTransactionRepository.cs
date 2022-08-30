using System;
using System.Collections.Generic;
using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.TransactionModels.Transactions.TypeTransaction;

namespace FM.SHD.Infastructure.Impl.Repositories.Specific.TypeTransaction
{
    public class TypeTransactionRepository : BaseSpecificRepository, ITypeTransactionRepository
    {
        private const string TABLE_NAME = "TransactionType";

        public TypeTransactionRepository(IRepositoryManager repositoryManager) : base(repositoryManager)
        {
        }

        public IEnumerable<ITypeTransactionModel> GetAll()
        {
            var sql = $"SELECT * FROM {TABLE_NAME};";

            var typeTransactions = new List<TypeTransactionModel>();

            using (var reader = SqliteDataProvider.CreateReader(sql))
            {
                while (reader.Read())
                {
                    var transactionModel = new TypeTransactionModel();
                    transactionModel.Id = long.Parse(reader["Id"].ToString());
                    transactionModel.Name = reader["Name"].ToString();
                    typeTransactions.Add(transactionModel);
                }
            }

            return typeTransactions;
        }

        public TypeTransactionModel GetById(int id)
        {
            if (CheckRecordIsExist(TABLE_NAME, id))
            {
                var sql = $"SELECT * FROM {TABLE_NAME} WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", id));

                var transactionModel = new TypeTransactionModel();

                using (var reader = SqliteDataProvider.CreateReader(sql, dataparameters.ToArray()))
                {
                    while (reader.Read())
                    {
                        transactionModel.Id = Int64.Parse(reader["Id"].ToString());
                        transactionModel.Name = reader["Name"].ToString();
                    }

                    return transactionModel;
                }
            }

            throw new ArgumentException($"В хранилище отсутствует запись с идентификатором {id}");
        }
    }
}