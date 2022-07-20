using FM.SHDML.Core.Models.TransactionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Services.SingleTransactionServices
{
    public interface ISingleTransactionServices
    {
        void ValidateModel(ISingleTransactionModel singleTransactionModel);
    }
}
