using FM.SHD.Infrastructure.DataAccess.Repositories.Specific;
using FM.SHD.Services.SingleTransactionServices;
using FM.SHDML.Core.Models.TransactionModels;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace FM.SHD.Infrastructure.DataProvider.Repositories.Specific.SingleTransaction
{
    public class SingleTransactionRepository : BaseSpecificRepository, ISingleTransactionRepository
    {
        public SingleTransactionRepository()
        {

        }

        public SingleTransactionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(ISingleTransactionModel singleTransactionModel)
        {
            var sql = $"INSERT INTO SingleTransaction (Type, Name, Description, Account, Sum, Date, Category, Contragent, FamilyMember) " +
                      $"VALUES (@Type, @Name, @Description, @Account, @Sum, @Date, @Category, @Contragent, @FamilyMember);";


            using (SqliteConnection sqliteConnection = new SqliteConnection(_connectionString))
            {
                try
                {
                    sqliteConnection.Open();
                    using (SqliteCommand command = new SqliteCommand())
                    {
                        command.Connection = sqliteConnection;
                        command.CommandText = sql;
                        command.Prepare();
                        command.Parameters.AddWithValue("@Type", singleTransactionModel.Type);
                        command.Parameters.AddWithValue("@Name", singleTransactionModel.Name);
                        command.Parameters.AddWithValue("@Description", singleTransactionModel.Description);
                        command.Parameters.AddWithValue("@Account", singleTransactionModel.Account);
                        command.Parameters.AddWithValue("@Sum", singleTransactionModel.Sum);
                        command.Parameters.AddWithValue("@Date", singleTransactionModel.Date);
                        command.Parameters.AddWithValue("@Category", singleTransactionModel.Category);
                        command.Parameters.AddWithValue("@Contragent", singleTransactionModel.Contragent);
                        command.Parameters.AddWithValue("@FamilyMember", singleTransactionModel.FamilyMember);

                        command.ExecuteNonQuery();
                    }
                    sqliteConnection.Close();
                }
                catch (SqliteException sqliteException)
                {
                    throw new Exception();
                }
            }
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
            var singleTransactionModels = new List<SingleTransactionModel>();

            using (SqliteConnection sqliteConnection = new SqliteConnection)
        }

        public void Update(ISingleTransactionModel singleTransactionModel)
        {
            throw new NotImplementedException();
        }

        SingleTransactionModel ISingleTransactionRepository.GetById(int id)
        {
            var sql = "";
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
            return singleTransactionModel; ;
        }
    }
}
