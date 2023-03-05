using FM.SHDML.Core.Models.AccountModel;
using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.AccountServices
{
    public interface IAccountServices
    {
        void ValidateModel(IAccountModel accountModel);

        long Add(AccountDto accountDto);
        void Update(AccountDto accountDto);
        void Delete(AccountDto accountDto);
        void DeleteById(long id);
        IEnumerable<AccountDto> GetAll();
        AccountDto GetById(long id);
        bool CheckExist(AccountDto accountDto);
    }
}