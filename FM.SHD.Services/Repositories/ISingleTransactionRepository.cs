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
        long Add(ISingleTransactionModel singleTransactionModel);
        void Update(ISingleTransactionModel singleTransactionModel);
        void Delete(ISingleTransactionModel singleTransactionModel);
        void DeleteById(int singleTransactionId);
        IEnumerable<ISingleTransactionModel> GetAll();
        SingleTransactionModel GetById(int id);
    }
}
