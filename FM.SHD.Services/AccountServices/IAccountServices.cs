using FM.SHDML.Core.Models.AccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Services.AccountServices
{
    public interface IAccountServices
    {
        void ValidateModel(IAccountModel accountModel);
    }
}
