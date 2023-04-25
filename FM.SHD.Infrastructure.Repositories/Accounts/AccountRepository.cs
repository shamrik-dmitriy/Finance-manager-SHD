using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FM.SHD.Data;
using FM.SHD.Domain.Accounts;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.AccountModel;

namespace FM.SHD.Infrastructure.Repositories.Accounts
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private IMapper _mapper;

        public AccountRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;

            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<Account, AccountModel>();
                config.CreateMap<AccountModel, Account>();
            }).CreateMapper();
        }

        public long Add(IAccountModel accountModel)
        {
            var model = _mapper.Map<Account>(accountModel);
            var reslut =  _applicationDbContext.Accounts.Add(model);
            _applicationDbContext.SaveChanges();
            return reslut.Entity.Id;
        }

        public void Update(IAccountModel accountModel)
        {
            var model = _mapper.Map<Account>(accountModel);
            _applicationDbContext.Accounts.Update(model);
        }

        public void Delete(IAccountModel accountModel)
        {
            var model = _mapper.Map<Account>(accountModel);
            _applicationDbContext.Accounts.Remove(model);
        }

        public void DeleteById(long accountModelId)
        {
            var account = new Account() { Id = accountModelId };
            _applicationDbContext.Accounts.Attach(account);
            _applicationDbContext.Accounts.Remove(account);
        }

        public IEnumerable<IAccountModel> GetAll()
        {
            return _applicationDbContext.Accounts.Select(x => _mapper.Map<AccountModel>(x));
        }

        public AccountModel GetById(long id)
        {
            var data = _applicationDbContext.Accounts.Find(id);
            return _mapper.Map<AccountModel>(data);
        }

        public bool CheckExist(AccountModel model)
        {
            var searchData = _mapper.Map<Account>(model);
            var data = _applicationDbContext.Accounts.Find(searchData);
            if (data != null)
                return true;
            return false;
        }
    }
}