using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHDML.Core.Models.TransactionModels.SignleTransaction
{
    public class SingleTransactionDto
    {
        long Id { get; set; }

        int TypeTransaction { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        long DebitAccount { get; set; }

        long CreditAccount { get; set; }

        decimal Sum { get; set; }

        DateTime Date { get; set; }

        long Category { get; set; }

        long Contragent { get; set; }

        long FamilyMember { get; set; }
    }
}
