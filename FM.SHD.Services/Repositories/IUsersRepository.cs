using System.Collections.Generic;
using FM.SHDML.Core.Models.Users;

namespace FM.SHD.Services.Repositories
{
    public interface IUsersRepository
    {
        long Add(IUserModel singleTransactionDto);
        void Update(IUserModel singleTransactionDto);
        void Delete(IUserModel singleTransactionDto);
        void DeleteById(int singleTransactionId);
        IEnumerable<IUserModel> GetAll();
        IUserModel GetById(int id);
    }
}