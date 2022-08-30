using System.Collections.Generic;
using FM.SHDML.Core.Models.Categories.CurrencyCategory;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.CurrencyServices
{
    public interface ICurrencyServices
    {
        void ValidateModel(ICurrencyModel currencyModel);

        long Add(CurrencyDto currencyDto);
        void Update(CurrencyDto currencyDto);
        void Delete(CurrencyDto currencyDto);
        void DeleteById(long id);
        IEnumerable<CurrencyDto> GetAll();
        CurrencyDto GetById(long id);
    }
}