using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FM.SHD.Services.CommonServices;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.Dtos;
using FM.SHDML.Core.Models.Users;

namespace FM.SHD.Services.UserServices
{
    public class UsersServices : IUsersServices
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IModelValidator _modelValidator;
        private readonly IMapper _mapper;

        public UsersServices(IUsersRepository usersRepository, IModelValidator modelValidator)
        {
            _usersRepository = usersRepository;
            _modelValidator = modelValidator;
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<UserDto, UserModel>();
                config.CreateMap<UserModel, UserDto>();
            }).CreateMapper();
        }
        public void ValidateModel(UserModel userModel)
        {
            _modelValidator.ValidateModel(userModel);
        }

        public long Add(UserDto userDto)
        {
            var model = _mapper.Map<UserModel>(userDto);
            ValidateModel(model);
            return _usersRepository.Add(model);
        }

        public void Update(UserDto userDto)
        {
            var model = _mapper.Map<UserModel>(userDto);
            ValidateModel(model);
            _usersRepository.Update(model);
        }

        public void Delete(UserDto userDto)
        {
            _usersRepository.Delete(_mapper.Map<UserModel>(userDto));
        }

        public void DeleteById(int userId)
        {
            _usersRepository.DeleteById(userId);
        }

        public IEnumerable<UserDto> GetAll()
        {
            return _usersRepository.GetAll().Select(x => _mapper.Map<UserDto>(x));
        }

        public UserDto GetById(int id)
        {
            return _mapper.Map<UserDto>(_usersRepository.GetById(id));
        }
    }
}