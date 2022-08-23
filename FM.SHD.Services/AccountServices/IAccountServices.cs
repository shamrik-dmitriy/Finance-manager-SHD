using FM.SHDML.Core.Models.AccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FM.SHD.Services.CommonServices;

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
    }
}