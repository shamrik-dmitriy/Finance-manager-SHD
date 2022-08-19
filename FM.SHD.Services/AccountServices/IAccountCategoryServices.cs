using System.Collections.Generic;
using FM.SHDML.Core.Models.AccountModel;
using FM.SHDML.Core.Models.Categories.AccountCategory;

namespace FM.SHD.Services.AccountServices
{
    public interface IAccountCategoryServices
    {
        void ValidateModel(IAccountCategoryModel accountCategoryModel);
        long Add(AccountCategoryDto accountCategoryDto);
        void Update(AccountCategoryDto accountCategoryDto);
        void Delete(AccountCategoryDto accountCategoryDto);
        void DeleteById(long id);
        IEnumerable<AccountCategoryDto> GetAll();
        AccountCategoryDto GetById(long id);
    }
}