using System.Collections.Generic;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;

namespace FM.SHD.Services.Repositories
{
    public interface ISingleTransactionRepository
    {
        long Add(ISingleTransactionModel singleTransactionModel);
        void Update(ISingleTransactionModel singleTransactionModel);
        void Delete(ISingleTransactionModel singleTransactionModel);
        void DeleteById(int singleTransactionId);
        IEnumerable<ISingleTransactionModel> GetAll();
        SingleTransactionModel GetById(int id);
    }
}
