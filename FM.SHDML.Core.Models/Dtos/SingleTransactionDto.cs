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
        public long? TypeTransactionId { get; set; }

        public string Description { get; set; }

        public long? DebitAccountId { get; set; }

        public long? CreditAccountId { get; set; }

        public decimal Sum { get; set; }

        public DateTime Date { get; set; }

        public long? CategoryId { get; set; }

        public long? ContragentId { get; set; }

        public long? IdentityId { get; set; }
    }
}