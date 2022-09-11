using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;
using FM.SHDML.Core.Models.Users;

namespace FM.SHD.Services.UserServices
{
    public interface IUsersServices
    {
        void ValidateModel(UserModel userModel);
        long Add(UserDto userDto);
        void Update(UserDto userDto);
        void Delete(UserDto userDto);
        void DeleteById(int userId);
        IEnumerable<UserDto> GetAll();
        UserDto GetById(int id);
    }
}