using System.Collections.Generic;
using FM.SHDML.Core.Models.Categories.ContragentsCategory;

namespace FM.SHD.Services.Repositories
{
    public interface IContragentsRepository
    {
        IEnumerable<ContragentModel> GetAll();
        ContragentModel GetById(long id);
        ContragentModel GetByName(string name);
    }
}