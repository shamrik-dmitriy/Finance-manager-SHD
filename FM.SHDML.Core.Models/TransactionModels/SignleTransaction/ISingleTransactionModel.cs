using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHDML.Core.Models.TransactionModels.SignleTransaction
{
    public interface ISingleTransactionModel
    {
        long Id { get; set; }

        int TypeTransaction { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        string DebitAccount { get; set; }

        string CreditAccount { get; set; }

        decimal Sum { get; set; }

        DateTime Date { get; set; }

        string Category { get; set; }

        string Contragent { get; set; }

        string FamilyMember { get; set; }
    }
}