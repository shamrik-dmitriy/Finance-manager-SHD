using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.CategoriesServices
{
    public interface IIdentityServices
    {
        IEnumerable<IdentityDto> GetAll();
        
        IdentityDto GetById(int id);
        
        IdentityDto GetByName(string name);
    }
}