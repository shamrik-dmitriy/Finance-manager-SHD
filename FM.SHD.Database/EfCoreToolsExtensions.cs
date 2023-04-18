using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace FM.SHD.Database
{
    public static class EfCoreToolsExtensions
    {
        public static void ChangeDatabase(this DbContext source, string connectionString)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(connectionString) || string.IsNullOrEmpty(connectionString))
                    throw new ArgumentException("Не указан путь до файла данных");

                source.Database.GetDbConnection().ConnectionString = new DatabaseFacade(new DbContext(null))
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (Exception exception)
            {
                throw;
            }
        }
    }
}