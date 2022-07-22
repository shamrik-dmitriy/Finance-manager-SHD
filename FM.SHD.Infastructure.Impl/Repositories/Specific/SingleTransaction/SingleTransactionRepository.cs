using FM.SHD.Infastructure.Impl.Factory;
using FM.SHD.Infrastructure.Dal.Factory;
using FM.SHD.Infrastructure.Dal.Providers.Interfaces;
using FM.SHD.Services.SingleTransactionServices;
using FM.SHDML.Core.Models.TransactionModels;
using System;
using System.Collections.Generic;
using FM.SHD.Infrastructure.Dal.Providers;

namespace FM.SHD.Infrastructure.Impl.Repositories.Specific.SingleTransaction
{
    public class SingleTransactionRepository : BaseSpecificRepository, ISingleTransactionRepository
    {
        private readonly IDataProvider _sqliteDataProvider;

        public SingleTransactionRepository()
        {

        }

        public SingleTransactionRepository(string connectionString)
        {
            _sqliteDataProvider = new SqliteConnectionFactory().CreateConnection(connectionString).DataProvider;
            _connectionString = connectionString;
        }

        public void Add(ISingleTransactionModel singleTransactionModel)
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

            _sqliteDataProvider.ExecuteSqlInsertCommand(sql, dataparameters.ToArray());
        }

        public void Delete(ISingleTransactionModel singleTransactionModel)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int singleTransactionId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ISingleTransactionModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ISingleTransactionModel singleTransactionModel)
        {
            throw new NotImplementedException();
        }

        SingleTransactionModel ISingleTransactionRepository.GetById(int id)
        {
            /* var sql = "";
             var singleTransactionModel = new SingleTransactionModel();
             using (SqliteConnection sqliteConnection = new SqliteConnection(_connectionString))
             {
                 try
                 {
                     sqliteConnection.Open();

                     using (SqliteCommand command = new SqliteCommand(sql, sqliteConnection))
                     {
                         command.CommandText = sql;
                         command.Prepare();
                         command.Parameters.Add(new SqliteParameter("@TransactionId", id));

                         bool isFind = false;

                         using (SqliteDataReader reader = command.ExecuteReader())
                         {
                             isFind = reader.HasRows;
                             while (reader.Read())
                             {
                                 // TODO: Добавить вычитку в модель
                             }

                         }
                     }
                 }
                 catch (SqliteException sqliteException)
                 {
                     // Refactoring to custom exception
                     throw new Exception(sqliteException.Message);
                 }
                 catch (Exception exception)
                 {
                     // Refactoring to custom exception
                     throw new Exception(exception.Message);
                 }
                 finally
                 {
                     sqliteConnection.Close();
                 }
             }
             return singleTransactionModel; ;*/
            throw new NotImplementedException();
        }
    }
}
