using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.CategoriesServices
{
    public interface ICategoriesServices
    {
        IEnumerable<CategoriesDto> GetAll();
        
        CategoriesDto GetById(int id);
        
        CategoriesDto GetByName(string name);
    }
}