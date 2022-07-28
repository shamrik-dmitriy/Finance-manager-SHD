using FM.SHD.Services.CommonServices;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.AccountModel;
using System;
using System.Collections.Generic;

namespace FM.SHD.Services.AccountServices
{
    public class AccountServices : IAccountServices, IAccountRepository
    {
        private IAccountRepository _accountModel;
        private IModelValidator _modelValidator;

        public AccountServices(IAccountRepository singleTransactionRepository, IModelValidator modelValidator)
        {
            _accountModel = singleTransactionRepository;
            _modelValidator = modelValidator;
        }

        public long Add(IAccountModel accountModel)
        {
            ValidateModel(accountModel);
            return _accountModel.Add(accountModel);
        }

        public void Delete(IAccountModel accountModel)
        {
            ValidateModel(accountModel);
            _accountModel.Delete(accountModel);
        }

        public void DeleteById(int accountModelId)
        {
            _accountModel.DeleteById(accountModelId);
        }

        public IEnumerable<IAccountModel> GetAll()
        {
            return _accountModel.GetAll();
        }

        public AccountModel GetById(int id)
        {
            return _accountModel.GetById(id);
        }

        public void Update(IAccountModel accountModel)
        {
            ValidateModel(accountModel);
            _accountModel.Update(accountModel);
        }

        public void ValidateModel(IAccountModel accountModel)
        {
            _modelValidator.ValidateModel(accountModel);
            // Тут вызываем дополнительную валидацию
        }
    }
}
