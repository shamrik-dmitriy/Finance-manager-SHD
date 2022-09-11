using System;

namespace FM.SHDML.Core.Models.Dtos
{
    public class TransactionExtendedDto
    {
        public long Id { get; set; }

        public string TypeTransaction { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string DebitAccount { get; set; }

        public string CreditAccount { get; set; }

        public decimal Sum { get; set; }

        public DateTime Date { get; set; }

        public string Category { get; set; }

        public string Contragent { get; set; }

        public string Identity { get; set; }
        
       // public long? ReceiptId { get; set; }
    }
}