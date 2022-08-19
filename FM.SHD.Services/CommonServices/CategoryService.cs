using System.Collections.Generic;
using System.Linq;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.CommonServices
{
    public class CategoryServices<T> where T : ICategoryServices
    {
        public IList<BaseDto> GetAll(T t)
        {
            return t.GetAll().ToList();
        }
    }
}