using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FM.SHD.Services.CommonServices;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.Categories.ContragentsCategory;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.ContragentServices
{
    public class ContragentServices : IContragentServices, IBaseCategoryServices
    {
        private readonly IContragentsRepository _contragentsRepository;
        private readonly IMapper _mapper;

        public ContragentServices(IContragentsRepository contragentsRepository)
        {
            _contragentsRepository = contragentsRepository;
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<ContragentModel, ContragentDto>();
                config.CreateMap<ContragentDto, ContragentModel>();
            }).CreateMapper();
        }

        public IEnumerable<ContragentDto> GetAll()
        {
            return _contragentsRepository.GetAll().Select(x => _mapper.Map<ContragentDto>(x));
        }

        public ContragentDto GetById(int id)
        {
            return _mapper.Map<ContragentDto>(_contragentsRepository.GetById(id));
        }

        public ContragentDto GetByName(string name)
        {
            return _mapper.Map<ContragentDto>(_contragentsRepository.GetByName(name));
        }

        IEnumerable<BaseDto> IBaseCategoryServices.GetAll()
        {
            return GetAll();
        }
    }
}