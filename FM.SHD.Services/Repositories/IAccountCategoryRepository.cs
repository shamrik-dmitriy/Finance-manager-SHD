using System.Collections.Generic;
using FM.SHDML.Core.Models.AccountModel;
using FM.SHDML.Core.Models.Categories.AccountCategory;

namespace FM.SHD.Services.Repositories
{
    public interface IAccountCategoryRepository
    {
        long Add(IAccountCategoryModel accountCategoryModel);
        void Update(IAccountCategoryModel accountCategoryModel);
        void Delete(IAccountCategoryModel accountCategoryModel);
        void DeleteById(long accountCategoryModel);
        IEnumerable<IAccountCategoryModel> GetAll();
        IAccountCategoryModel GetById(long id);
    }
}