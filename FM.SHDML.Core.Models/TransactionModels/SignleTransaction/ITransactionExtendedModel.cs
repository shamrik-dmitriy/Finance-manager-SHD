using System;

namespace FM.SHDML.Core.Models.TransactionModels.SignleTransaction
{
    public interface ITransactionExtendedModel
    {
        long Id { get; set; }

        string TypeTransaction { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        string DebitAccount { get; set; }

        string CreditAccount { get; set; }

        decimal Sum { get; set; }

        DateTime Date { get; set; }

        string Category { get; set; }

        string Contragent { get; set; }

        string Identity { get; set; }
        
        long? ReceiptId { get; set; }
    }
}