using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;
using FM.SHDML.Core.Models.Users;

namespace FM.SHD.Services.UserServices
{
    public interface IUsersServices
    {
        void ValidateModel(UserModel singleTransactionModel);
        long Add(UserDto singleTransactionDto);
        void Update(UserDto singleTransactionDto);
        void Delete(UserDto singleTransactionDto);
        void DeleteById(int singleTransactionId);
        IEnumerable<UserDto> GetAll();
        UserDto GetById(int id);
    }
}