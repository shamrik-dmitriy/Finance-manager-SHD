using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;
using System.Collections.Generic;

namespace FM.SHD.Services.SingleTransactionServices
{
    public interface ISingleTransactionServices
    {
        void ValidateModel(SingleTransactionModel singleTransactionModel);
        long Add(SingleTransactionDto singleTransactionDto);
        void Update(SingleTransactionDto singleTransactionDto);
        void Delete(SingleTransactionDto singleTransactionDto);
        void DeleteById(int singleTransactionId);
        IEnumerable<SingleTransactionDto> GetAll();
        SingleTransactionDto GetById(int id);
    }
}
