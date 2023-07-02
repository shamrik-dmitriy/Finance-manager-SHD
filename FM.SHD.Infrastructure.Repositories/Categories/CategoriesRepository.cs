using System;
using System.Collections.Generic;
using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHD.Infrastructure.Repositories.DatabaseConstants;
using FM.SHD.Services;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.Categories;
using FM.SHDML.Core.Models.Categories.Categories;

namespace FM.SHD.Infrastructure.Repositories.Categories
{
    public class CategoriesRepository : BaseSpecificRepository, ICategoriesRepository
    {
        public CategoriesRepository(IRepositoryManager repositoryManager) : base(repositoryManager)
        {
        }

        public IEnumerable<CategoriesModel> GetAllByType(CategoryTypes categoryType)
        {
            var sql =
                @$"SELECT * 
                    FROM {DbConstants.UserTables.CategoriesTable.Name}
                    WHERE {DbConstants.SystemTables.CategoryTypesTable.Columns.Id} == {(int)categoryType};";

            var typeTransactions = new List<CategoriesModel>();

            using (var reader = SqliteDataProvider.CreateReader(sql))
            {
                while (reader.Read())
                {
                    var categoriesModel = new CategoriesModel();
                    categoriesModel.Id =
                        long.Parse(reader[$"{DbConstants.UserTables.CategoriesTable.Columns.Id}"].ToString());
                    categoriesModel.Name = reader[$"{DbConstants.UserTables.CategoriesTable.Columns.Name}"].ToString();
                    categoriesModel.Description =
                        reader[$"{DbConstants.UserTables.CategoriesTable.Columns.Description}"].ToString();
                    categoriesModel.ParentId =
                        long.Parse(reader[$"{DbConstants.UserTables.CategoriesTable.Columns.ParentID}"].ToString());
                    categoriesModel.CategoryType =
                        (CategoryTypes)(reader[$"{DbConstants.UserTables.CategoriesTable.Columns.CategoryType}"]
                            .ToString());
                    typeTransactions.Add(categoriesModel);
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

                using (var reader = SqliteDataProvider.CreateReader(sql, dataparameters.ToArray()))
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

                using (var reader = SqliteDataProvider.CreateReader(sql, dataparameters.ToArray()))
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