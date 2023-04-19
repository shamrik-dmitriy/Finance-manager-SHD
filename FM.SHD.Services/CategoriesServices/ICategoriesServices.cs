using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.CategoriesServices
{
    public interface ICategoriesServices
    {
        IEnumerable<CategoryDto> GetAll();
        
        CategoryDto GetById(int id);
        
        CategoryDto GetByName(string name);
    }
}