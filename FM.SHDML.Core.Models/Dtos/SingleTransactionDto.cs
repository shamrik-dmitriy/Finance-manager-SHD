using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHDML.Core.Models.TransactionModels.SignleTransaction
{
    public class SingleTransactionDto : BaseDto
    {
        public long TypeTransaction { get; set; }

        public string Description { get; set; }

        public long DebitAccount { get; set; }

        public long CreditAccount { get; set; }

        public decimal Sum { get; set; }

        public DateTime Date { get; set; }

        public long Category { get; set; }

        public long Contragent { get; set; }

        public long FamilyMember { get; set; }
    }
}