using System.Collections.Generic;
using FM.SHD.Services.CommonServices;
using FM.SHDML.Core.Models.TransactionModels.Transactions.TypeTransaction;

namespace FM.SHD.Services.ComponentsServices.TypeTransactionService
{
    public interface ITypeTransactionServices : ICategoryService
    {
        IEnumerable<TypeTransactionDto> GetAll();
        TypeTransactionDto GetById(int id);
    }
}