using FM.SHDML.Core.Models.AccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Services.Repositories
{
    public interface IAccountRepository
    {
        long Add(IAccountModel accountModel);
        void Update(IAccountModel accountModel);
        void Delete(IAccountModel accountModel);
        void DeleteById(int accountModelId);
        IEnumerable<IAccountModel> GetAll();
        AccountModel GetById(int id);
    }
}
