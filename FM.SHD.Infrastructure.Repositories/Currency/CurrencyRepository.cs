using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FM.SHD.Data;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.Categories.CurrencyCategory;

namespace FM.SHD.Infrastructure.Repositories.Currency
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private IMapper _mapper;

        public CurrencyRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;

            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<Domain.Currencies.Currency, CurrencyModel>();
                config.CreateMap<CurrencyModel, Domain.Currencies.Currency>();
            }).CreateMapper();
        }

        public long Add(ICurrencyModel currencyModel)
        {
            var model = _mapper.Map<Domain.Currencies.Currency>(currencyModel);
            return _applicationDbContext.Currencies.Add(model).Entity.Id;
        }

        public void Update(ICurrencyModel currencyModel)
        {
            var model = _mapper.Map<Domain.Currencies.Currency>(currencyModel);
            _applicationDbContext.Currencies.Update(model);
        }

        public void Delete(ICurrencyModel currencyModel)
        {
            var model = _mapper.Map<Domain.Currencies.Currency>(currencyModel);
            _applicationDbContext.Currencies.Remove(model);
        }

        public void DeleteById(long id)
        {
            var account = new Domain.Currencies.Currency() { Id = id };
            _applicationDbContext.Currencies.Attach(account);
            _applicationDbContext.Currencies.Remove(account);
        }

        public IEnumerable<ICurrencyModel> GetAll()
        {
            return _applicationDbContext.Currencies.Select(x => _mapper.Map<CurrencyModel>(x));
        }

        public CurrencyModel GetById(long id)
        {
            var data = _applicationDbContext.Currencies.Find(id);
            return _mapper.Map<CurrencyModel>(data);        }
    }
}