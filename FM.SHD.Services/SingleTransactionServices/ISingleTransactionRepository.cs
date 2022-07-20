using FM.SHDML.Core.Models.TransactionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Services.SingleTransactionServices
{
    public interface ISingleTransactionRepository
    {
        void Add(ISingleTransactionModel singleTransactionModel);
        void Update(ISingleTransactionModel singleTransactionModel);
        void Delete(ISingleTransactionModel singleTransactionModel);
        void DeleteById(int singleTransactionId);
        SingleTransactionModel GetById(int id);
    }
}
