using System.Collections.Generic;
using FM.SHDML.Core.Models.Users;

namespace FM.SHD.Services.Repositories
{
    public interface IUsersRepository
    {
        long Add(IUserModel userModel);
        void Update(IUserModel userModel);
        void Delete(IUserModel userModel);
        void DeleteById(int userId);
        IEnumerable<IUserModel> GetAll();
        IUserModel GetById(int id);
    }
}