using System.Collections.Generic;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;

namespace FM.SHD.Services.Repositories
{
    public interface ITransactionRepository
    {
        long Add(ITransactionModel transactionModel);
        void Update(ITransactionModel transactionModel);
        void Delete(ITransactionModel transactionModel);
        void DeleteById(long transactionId);
        IEnumerable<ITransactionModel> GetAll();
        TransactionModel GetById(long id);
        TransactionExtendedModel GetExtendedById(long id);
        
        IEnumerable<ITransactionModel> GetAllRecordsAssociatedWithAReceipt(long receiptId);
        IEnumerable<TransactionExtendedModel> GetExtendedTransactions();
    }
}