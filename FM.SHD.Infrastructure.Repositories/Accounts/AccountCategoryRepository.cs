using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FM.SHD.Data;
using FM.SHD.Domain.Accounts;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.Categories.AccountCategory;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Infrastructure.Repositories.Accounts
{
    public class AccountCategoryRepository : IAccountCategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private IMapper _mapper;

        public AccountCategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;

            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<AccountCategory, IAccountCategoryModel>();
                config.CreateMap<IAccountCategoryModel, AccountCategory>();
            }).CreateMapper();
        }

        public long Add(IAccountCategoryModel accountCategoryModel)
        {
            var model = _mapper.Map<AccountCategory>(accountCategoryModel);
            return _applicationDbContext.AccountCategories.Add(model).Entity.Id;
        }

        public void Update(IAccountCategoryModel accountCategoryModel)
        {
            var model = _mapper.Map<AccountCategory>(accountCategoryModel);
            _applicationDbContext.AccountCategories.Update(model);
        }

        public void Delete(IAccountCategoryModel accountCategoryModel)
        {
            var model = _mapper.Map<AccountCategory>(accountCategoryModel);
            _applicationDbContext.AccountCategories.Remove(model);
        }

        public void DeleteById(long accountCategoryId)
        {
            var account = new AccountCategory() { Id = accountCategoryId };
            _applicationDbContext.AccountCategories.Attach(account);
            _applicationDbContext.AccountCategories.Remove(account);
        }

        public IQueryable<IAccountCategoryModel> GetAll()
        {
            return _applicationDbContext.AccountCategories.Select(x => _mapper.Map<IAccountCategoryModel>(x));
        }

        public IAccountCategoryModel GetById(long id)
        {
            var data = _applicationDbContext.AccountCategories.Find(id);
            return _mapper.Map<AccountCategoryModel>(data);
        }
    }
}