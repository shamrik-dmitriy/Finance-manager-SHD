using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FM.SHD.Services.CommonServices;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.Categories.CurrencyCategory;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.CurrencyServices
{
    public class CurrencyServices : ICurrencyServices, IBaseCategoryServices
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IModelValidator _modelValidator;
        private readonly IMapper _mapper;

        public CurrencyServices(ICurrencyRepository currencyRepository, IModelValidator modelValidator)
        {
            _currencyRepository = currencyRepository;
            _modelValidator = modelValidator;
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<CurrencyModel, CurrencyDto>();
                config.CreateMap<CurrencyDto, CurrencyModel>();
            }).CreateMapper();
        }

        public void ValidateModel(ICurrencyModel currencyModel)
        {
            _modelValidator.ValidateModel(currencyModel);
        }

        public long Add(CurrencyDto currencyDto)
        {
            var model = _mapper.Map<CurrencyModel>(currencyDto);
            ValidateModel(model);
            return _currencyRepository.Add(model);
        }

        public void Update(CurrencyDto currencyDto)
        {
            var model = _mapper.Map<CurrencyModel>(currencyDto);
            ValidateModel(model);
            _currencyRepository.Update(model);
        }

        public void Delete(CurrencyDto currencyDto)
        {
            var model = _mapper.Map<CurrencyModel>(currencyDto);
            ValidateModel(model);
            _currencyRepository.Delete(model);
        }

        public void DeleteById(long id)
        {
            _currencyRepository.DeleteById(id);
        }

        public IEnumerable<CurrencyDto> GetAll()
        {
            return _currencyRepository.GetAll().Select(x => _mapper.Map<CurrencyDto>(x));
        }

        public CurrencyDto GetById(long id)
        {
            return _mapper.Map<CurrencyDto>(_currencyRepository.GetById(id));
        }

        IEnumerable<BaseDto> IBaseCategoryServices.GetAll()
        {
            return GetAll();
        }
    }
}