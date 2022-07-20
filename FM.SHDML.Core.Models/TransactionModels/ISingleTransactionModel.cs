using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHDML.Core.Models.TransactionModels
{
    public interface ISingleTransactionModel
    {
        string Id { get; set; }

        string Type { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        string Account { get; set; }

        string Sum { get; set; }

        DateTime Date { get; set; }

        string Category { get; set; }

        string Contragent { get; set; }

        string FamilyMember { get; set; }

    }
}
