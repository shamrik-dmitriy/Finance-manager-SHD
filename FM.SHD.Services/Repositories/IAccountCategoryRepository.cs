using System.Linq;
using FM.SHDML.Core.Models.Categories.AccountCategory;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.Repositories
{
    public interface IAccountCategoryRepository
    {
        long Add(IAccountCategoryModel accountCategoryModel);
        void Update(IAccountCategoryModel accountCategoryModel);
        void Delete(IAccountCategoryModel accountCategoryModel);
        void DeleteById(long accountCategoryId);
        IQueryable<IAccountCategoryModel> GetAll();
        IAccountCategoryModel GetById(long id);
    }
}