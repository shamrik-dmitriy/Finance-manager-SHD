﻿using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;

namespace FM.SHD.Services.TransactionServices
{
    public interface ITransactionServices
    {
        void ValidateModel(TransactionModel transactionModel);
        long Add(TransactionDto transactionDto);
        void Update(TransactionDto transactionDto);
        void Delete(TransactionDto transactionDto);
        void DeleteById(long transactionId);
        IEnumerable<TransactionDto> GetAll();
        TransactionDto GetById(long id);
        TransactionExtendedDto GetExtendedById(long id);
        List<TransactionExtendedDto> GetExtendedTransactions();
    }
}
