using System.Collections.Generic;
using FM.SHDML.Core.Models.Categories.Categories;

namespace FM.SHD.Services.Repositories
{
    public interface ICategoriesRepository
    {
        IEnumerable<CategoriesModel> GetAll();
        CategoriesModel GetById(long id);
        CategoriesModel GetByName(string name);
    }
}