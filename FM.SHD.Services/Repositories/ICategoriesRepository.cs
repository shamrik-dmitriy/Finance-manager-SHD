using System.Collections.Generic;
using FM.SHDML.Core.Models.Categories;
using FM.SHDML.Core.Models.Categories.Categories;

namespace FM.SHD.Services.Repositories
{
    public interface ICategoriesRepository
    {
        IEnumerable<CategoriesModel> GetAllByType(CategoryTypes categoryType);
        CategoriesModel GetById(long id);
        CategoriesModel GetByName(string name);
    }
}