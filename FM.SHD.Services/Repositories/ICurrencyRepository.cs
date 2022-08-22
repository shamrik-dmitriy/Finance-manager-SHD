using System.Collections.Generic;
using FM.SHDML.Core.Models.Categories.CurrencyCategory;

namespace FM.SHD.Services.Repositories
{
    public interface ICurrencyRepository
    {
        long Add(ICurrencyModel currencyModel);
        void Update(ICurrencyModel currencyModel);
        void Delete(ICurrencyModel currencyModel);
        void DeleteById(long id);
        IEnumerable<ICurrencyModel> GetAll();
        CurrencyModel GetById(long id);
    }
}