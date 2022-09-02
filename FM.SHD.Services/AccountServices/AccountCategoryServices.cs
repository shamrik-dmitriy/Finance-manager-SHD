using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FM.SHD.Services.CommonServices;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.Categories.AccountCategory;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.AccountServices
{
    public class AccountCategoryServices : IAccountCategoryServices, IBaseCategoryServices
    {
        private readonly IAccountCategoryRepository _accountCategoryRepository;
        private readonly IModelValidator _modelValidator;
        private readonly IMapper _mapper;

        public AccountCategoryServices(IAccountCategoryRepository accountCategoryRepository,
            IModelValidator modelValidator)
        {
            _accountCategoryRepository = accountCategoryRepository;
            _modelValidator = modelValidator;
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<AccountCategoryDto, AccountCategoryModel>();
                config.CreateMap<AccountCategoryModel, AccountCategoryDto>();
            }).CreateMapper();
        }

        public long Add(AccountCategoryDto accountCategoryDto)
        {
            var model = _mapper.Map<AccountCategoryModel>(accountCategoryDto);
            ValidateModel(model);
            return _accountCategoryRepository.Add(model);
        }

        public void Update(AccountCategoryDto accountCategoryDto)
        {
            var model = _mapper.Map<AccountCategoryModel>(accountCategoryDto);
            ValidateModel(model);
            _accountCategoryRepository.Update(model);
        }

        public void Delete(AccountCategoryDto accountCategoryDto)
        {
            var model = _mapper.Map<AccountCategoryModel>(accountCategoryDto);
            ValidateModel(model);
            _accountCategoryRepository.Delete(model);
        }

        public void DeleteById(long id)
        {
            _accountCategoryRepository.DeleteById(id);
        }

        public IEnumerable<AccountCategoryDto> GetAll()
        {
            return _accountCategoryRepository.GetAll().Select(x => _mapper.Map<AccountCategoryDto>(x));
        }

        public AccountCategoryDto GetById(long id)
        {
            return _mapper.Map<AccountCategoryDto>(_accountCategoryRepository.GetById(id));
        }

        public void ValidateModel(IAccountCategoryModel accountCategoryModel)
        {
            _modelValidator.ValidateModel(accountCategoryModel);
            // Тут вызываем дополнительную валидацию
        }

        IEnumerable<BaseDto> IBaseCategoryServices.GetAll()
        {
            return GetAll();
        }
    }
}