using System.Collections.Generic;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;

namespace FM.SHD.Services.Repositories
{
    public interface ITransactionRepository
    {
        long Add(ITransactionModel transactionModel);
        void Update(ITransactionModel transactionModel);
        void Delete(ITransactionModel transactionModel);
        void DeleteById(int transactionId);
        IEnumerable<ITransactionModel> GetAll();
        TransactionModel GetById(int id);
        IEnumerable<ITransactionModel> GetAllRecordsAssociatedWithAReceipt(long receiptId);
    }
}