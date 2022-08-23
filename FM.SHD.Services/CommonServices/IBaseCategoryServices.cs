using System;
using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.CommonServices
{
    public interface IBaseCategoryServices
    {
        IEnumerable<BaseDto> GetAll();
    }
}