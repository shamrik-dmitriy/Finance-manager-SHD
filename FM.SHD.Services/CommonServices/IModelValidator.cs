using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FM.SHD.Services.CommonServices
{
    public interface IModelValidator
    {
        void ValidateModel<T>(T model);
    }
}