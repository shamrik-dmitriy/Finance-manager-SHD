using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.ComponentsServices.TypeTransactionService
{
    public interface ITypeTransactionServices
    {
        IEnumerable<TypeTransactionDto> GetAll();
        TypeTransactionDto GetById(int id);
    }
}