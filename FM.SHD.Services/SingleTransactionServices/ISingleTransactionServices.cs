using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;
using System.Collections.Generic;
using SHDML.BLL.DTO.DTO;

namespace FM.SHD.Services.SingleTransactionServices
{
    public interface ISingleTransactionServices
    {
        void ValidateModel(SingleTransactionModel singleTransactionModel);
        long Add(SingleTransactionDTO singleTransactionDto);
        void Update(SingleTransactionDTO singleTransactionDto);
        void Delete(SingleTransactionDTO singleTransactionDto);
        void DeleteById(int singleTransactionId);
        IEnumerable<SingleTransactionDTO> GetAll();
        SingleTransactionDTO GetById(int id);
    }
}
