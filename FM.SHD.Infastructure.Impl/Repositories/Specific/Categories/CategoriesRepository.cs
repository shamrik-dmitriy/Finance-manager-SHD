using System;
using System.Collections.Generic;
using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.Categories.Categories;

namespace FM.SHD.Infastructure.Impl.Repositories.Specific.Categories
{
    public class CategoriesRepository : BaseSpecificRepository, ICategoriesRepository
    {
        private const string TABLE_NAME = "Categories";

        public CategoriesRepository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<CategoriesModel> GetAll()
        {
            var sql = $"SELECT * FROM {TABLE_NAME};";

            var typeTransactions = new List<CategoriesModel>();

            using (var reader = _sqliteDataProvider.CreateReader(sql))
            {
                while (reader.Read())
                {
                    var transactionModel = new CategoriesModel();
                    transactionModel.Id = long.Parse(reader["Id"].ToString());
                    transactionModel.Name = reader["Name"].ToString();
                    transactionModel.Description = reader["Description"].ToString();
                    typeTransactions.Add(transactionModel);
                }
            }

            return typeTransactions;
        }

        public CategoriesModel GetById(long id)
        {
            if (CheckRecordIsExist(TABLE_NAME, id))
            {
                var sql = $"SELECT * FROM {TABLE_NAME} WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", id));

                var categoriesModel = new CategoriesModel();

                using (var reader = _sqliteDataProvider.CreateReader(sql, dataparameters.ToArray()))
                {
                    while (reader.Read())
                    {
                        categoriesModel.Id = long.Parse(reader["Id"].ToString());
                        categoriesModel.Name = reader["Name"].ToString();
                        categoriesModel.Description = reader["Description"].ToString();
                    }

                    return categoriesModel;
                }
            }

            throw new ArgumentException($"В хранилище отсутствует запись с идентификатором {id}");
        }

        public CategoriesModel GetByName(string name)
        {
            if (CheckRecordIsExist(TABLE_NAME, name))
            {
                var sql = $"SELECT * FROM {TABLE_NAME} WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Name", name));

                var categoriesModel = new CategoriesModel();

                using (var reader = _sqliteDataProvider.CreateReader(sql, dataparameters.ToArray()))
                {
                    while (reader.Read())
                    {
                        categoriesModel.Id = long.Parse(reader["Id"].ToString());
                        categoriesModel.Name = reader["Name"].ToString();
                        categoriesModel.Description = reader["Description"].ToString();
                    }

                    return categoriesModel;
                }
            }

            throw new ArgumentException($"В хранилище отсутствует запись с названием {name}");
        }
    }
}