using FM.SHDML.Core.Models.AccountModel;
using System.Collections.Generic;

namespace FM.SHD.Services.Repositories
{
    public interface IAccountRepository
    {
        long Add(IAccountModel accountModel);
        void Update(IAccountModel accountModel);
        void Delete(IAccountModel accountModel);
        void DeleteById(long accountModelId);
        IEnumerable<IAccountModel> GetAll();
        AccountModel GetById(long id);
        bool CheckExist(IAccountModel accountModel);
    }
}
