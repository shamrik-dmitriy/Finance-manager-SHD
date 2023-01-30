using System;

namespace FM.SHDML.Core.Models.TransactionModels.SignleTransaction
{
    public interface ITransactionModel
    {
        long Id { get; set; }

        long? TypeTransactionId { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        long? DebitAccountId { get; set; }

        long? CreditAccountId { get; set; }

        decimal Sum { get; set; }

        DateTime Date { get; set; }

        long? CategoryId { get; set; }

        long? ContragentId { get; set; }

        long? IdentityId { get; set; }
        long? ReceiptId { get; set; }
    }
}