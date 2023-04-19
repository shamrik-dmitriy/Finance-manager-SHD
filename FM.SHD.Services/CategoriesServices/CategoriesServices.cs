using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FM.SHD.Services.CommonServices;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.Categories.Categories;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.CategoriesServices
{
    public class CategoriesServices : ICategoriesServices, IBaseCategoryServices
    {
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IMapper _mapper;

        public CategoriesServices(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<CategoriesModel, CategoryDto>();
                config.CreateMap<CategoryDto, CategoriesModel>();
            }).CreateMapper();
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            return _categoriesRepository.GetAll().Select(x => _mapper.Map<CategoryDto>(x));
        }

        public CategoryDto GetById(int id)
        {
            return _mapper.Map<CategoryDto>(_categoriesRepository.GetById(id));
        }       
        
        public CategoryDto GetByName(string name)
        {
            return _mapper.Map<CategoryDto>(_categoriesRepository.GetByName(name));
        }

        IEnumerable<BaseDto> IBaseCategoryServices.GetAll()
        {
            return GetAll();
        }
    }
}