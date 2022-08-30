using System;
using System.Collections.Generic;
using FM.SHD.Infrastructure.Dal.Providers;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.Categories.IdentitiesCategory;

namespace FM.SHD.Infastructure.Impl.Repositories.Specific.Identities
{
    public class IdentitiesRepository : BaseSpecificRepository, IIdentitiesRepository
    {
        private const string TABLE_NAME = "Identity";

        public IdentitiesRepository(IRepositoryManager repositoryManager) : base(repositoryManager)
        {
        }
        
        public IEnumerable<IdentityModel> GetAll()
        {
            var sql = $"SELECT * FROM {TABLE_NAME};";

            var typeTransactions = new List<IdentityModel>();

            using (var reader = SqliteDataProvider.CreateReader(sql))
            {
                while (reader.Read())
                {
                    var transactionModel = new IdentityModel();
                    transactionModel.Id = long.Parse(reader["Id"].ToString());
                    transactionModel.Name = reader["Name"].ToString();
                    transactionModel.Description = reader["Description"].ToString();
                    typeTransactions.Add(transactionModel);
                }
            }

            return typeTransactions;
        }

        public IdentityModel GetById(long id)
        {
            if (CheckRecordIsExist(TABLE_NAME, id))
            {
                var sql = $"SELECT * FROM {TABLE_NAME} WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Id", id));

                var identityModel = new IdentityModel();

                using (var reader = SqliteDataProvider.CreateReader(sql, dataparameters.ToArray()))
                {
                    while (reader.Read())
                    {
                        identityModel.Id = long.Parse(reader["Id"].ToString());
                        identityModel.Name = reader["Name"].ToString();
                        identityModel.Description = reader["Description"].ToString();
                    }

                    return identityModel;
                }
            }

            throw new ArgumentException($"В хранилище отсутствует запись с идентификатором {id}");
        }

        public IdentityModel GetByName(string name)
        {
            if (CheckRecordIsExist(TABLE_NAME, name))
            {
                var sql = $"SELECT * FROM {TABLE_NAME} WHERE Id = @Id;";

                var dataparameters = new List<DataParameter>();
                dataparameters.Add(new DataParameter("@Name", name));

                var identityModel = new IdentityModel();

                using (var reader = SqliteDataProvider.CreateReader(sql, dataparameters.ToArray()))
                {
                    while (reader.Read())
                    {
                        identityModel.Id = long.Parse(reader["Id"].ToString());
                        identityModel.Name = reader["Name"].ToString();
                        identityModel.Description = reader["Description"].ToString();
                    }

                    return identityModel;
                }
            }

            throw new ArgumentException($"В хранилище отсутствует запись с названием {name}");
        }
    }
}