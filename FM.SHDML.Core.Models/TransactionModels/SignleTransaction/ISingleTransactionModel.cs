﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHDML.Core.Models.TransactionModels.SignleTransaction
{
    public interface ISingleTransactionModel
    {
        long Id { get; set; }

        string Type { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        public string DebitAccount { get; set; }

        public string CreditAccount { get; set; }

        string Sum { get; set; }

        string Date { get; set; }

        string Category { get; set; }

        string Contragent { get; set; }

        string FamilyMember { get; set; }
    }
}