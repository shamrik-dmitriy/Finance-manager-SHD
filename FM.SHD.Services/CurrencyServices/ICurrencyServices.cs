using System.Collections.Generic;
using FM.SHDML.Core.Models.Categories.CurrencyCategory;

namespace FM.SHD.Services.CurrencyServices
{
    public interface ICurrencyServices
    {
        void ValidateModel(ICurrencyCategoryModel currencyCategoryModel);

        long Add(CurrencyCategoryModel currencyCategoryDto);
        void Update(CurrencyCategoryModel currencyCategoryDto);
        void Delete(CurrencyCategoryModel currencyCategoryDto);
        void DeleteById(long id);
        IEnumerable<CurrencyCategoryModel> GetAll();
        CurrencyCategoryModel GetById(long id);
    }
}