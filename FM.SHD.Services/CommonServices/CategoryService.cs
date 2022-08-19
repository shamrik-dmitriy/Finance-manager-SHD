using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.CommonServices
{
    public class CategoryService
    {
        public CategoryService()
        {
        }

        public IEnumerable<BaseCategoryDto> GetAll<T>(T t) where T : ICategoryService
        {
            return t.GetAll();
        }
    }
}