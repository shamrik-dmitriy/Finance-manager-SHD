using FM.SHDML.Core.Models.TransactionModels;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace FM.SHD.Infrastructure.DataAccess.Repositories.Specific.SingleTransaction
{
    public class SingleTransactionRepository : BaseSpecificRepository
    {
        public SingleTransactionRepository()
        {

        }

        public SingleTransactionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ISingleTransactionModel GetById(int id)
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
            return singleTransactionModel;
        }
    }
}
