using System.Collections.Generic;
using FM.SHDML.Core.Models.TransactionModels.Transactions.TypeTransaction;
using SHDML.BLL.DTO.DTO;

namespace FM.SHD.Services.TypeTransactionService
{
    public interface ITypeTransactionServices
    {
        IEnumerable<TypeTransactionDto> GetAll();
        TypeTransactionDto GetById(int id);
    }
}