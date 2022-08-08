using System.Collections.Generic;
using FM.SHDML.Core.Models.TransactionModels.Transactions.TypeTransaction;

namespace FM.SHD.Services.Repositories
{
    public interface ITypeTransactionRepository
    {
        IEnumerable<ITypeTransactionModel> GetAll();
        TypeTransactionModel GetById(int id);
    }
}