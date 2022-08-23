using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FM.SHD.Services.CommonServices;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.Categories.Categories;
using FM.SHDML.Core.Models.Categories.Contragents;
using FM.SHDML.Core.Models.Categories.IdentitiesCategory;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.CategoriesServices
{
    public class IdentityServices : IIdentityServices, IBaseCategoryServices
    {
        private readonly IIdentitiesRepository _identitiesRepository;
        private readonly IMapper _mapper;

        public IdentityServices(IIdentitiesRepository identitiesRepository)
        {
            _identitiesRepository = identitiesRepository;
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<IdentityModel, IdentityDto>();
                config.CreateMap<IdentityDto, IdentityModel>();
            }).CreateMapper();
        }

        public IEnumerable<IdentityDto> GetAll()
        {
            return _identitiesRepository.GetAll().Select(x => _mapper.Map<IdentityDto>(x));
        }

        public IdentityDto GetById(int id)
        {
            return _mapper.Map<IdentityDto>(_identitiesRepository.GetById(id));
        }

        public IdentityDto GetByName(string name)
        {
            return _mapper.Map<IdentityDto>(_identitiesRepository.GetByName(name));
        }

        IEnumerable<BaseDto> IBaseCategoryServices.GetAll()
        {
            return GetAll();
        }
    }
}