using FM.SHD.Services.CommonServices;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.AccountModel;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace FM.SHD.Services.AccountServices
{
    public class AccountServices : IAccountServices
    {
        private IAccountRepository _accountRepository;
        private IModelValidator _modelValidator;
        private readonly IMapper _mapper;

        public AccountServices(IAccountRepository singleTransactionRepository, IModelValidator modelValidator)
        {
            _accountRepository = singleTransactionRepository;
            _modelValidator = modelValidator;
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<AccountDto, AccountModel>();
            }).CreateMapper();
        }

        public long Add(AccountDto accountDto)
        {
            var model = _mapper.Map<AccountModel>(accountDto);
            ValidateModel(model);
            return _accountRepository.Add(model);
        }

        public void Delete(AccountDto accountDto)
        {
            var model = _mapper.Map<AccountModel>(accountDto);
            ValidateModel(model);
            _accountRepository.Delete(model);
        }

        public void DeleteById(long accountModelId)
        {
            _accountRepository.DeleteById(accountModelId);
        }

        public IEnumerable<AccountDto> GetAll()
        {
            return _accountRepository.GetAll().Select(x => _mapper.Map<AccountDto>(x));
        }

        public AccountDto GetById(long id)
        {
            return _mapper.Map<AccountDto>(_accountRepository.GetById(id));
        }

        public void Update(AccountDto accountDto)
        {
            var model = _mapper.Map<AccountModel>(accountDto);
            ValidateModel(model);
            _accountRepository.Update(model);
        }

        public void ValidateModel(IAccountModel accountModel)
        {
            _modelValidator.ValidateModel(accountModel);
            // Тут вызываем дополнительную валидацию
        }
    }
}