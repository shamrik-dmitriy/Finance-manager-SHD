using System.Collections.Generic;
using FM.SHDML.Core.Models.Categories.IdentitiesCategory;

namespace FM.SHD.Services.Repositories
{
    public interface IIdentitiesRepository
    {
        IEnumerable<IdentityModel> GetAll();
        IdentityModel GetById(long id);
        IdentityModel GetByName(string name);
    }
}