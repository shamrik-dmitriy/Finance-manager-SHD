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
        string Type { get; set; }
        
        string Description { get; set; }

        string Account { get; set; }

        string Sum { get; set; }

        DateTime Date { get; set; }

        string Category { get; set; }

        string Contragent { get; set; }

        string FamilyMember { get; set; }
    }
}