using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.CommonServices
{
    public interface ICategoryService
    {
        IEnumerable<BaseCategoryDto> GetAll();
    }
}