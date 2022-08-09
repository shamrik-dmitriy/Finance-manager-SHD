using System.Collections.Generic;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.TransactionModels.Transactions.TypeTransaction;

namespace FM.SHD.Infastructure.Impl.Repositories.Specific.TypeTransaction
{
    public class TypeTransactionRepository : BaseSpecificRepository, ITypeTransactionRepository
    {
        public TypeTransactionRepository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<ITypeTransactionModel> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public TypeTransactionModel GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}