using System;

namespace FM.SHDML.Core.Models.Dtos
{
    public class TransactionDto : BaseDto
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

        public override bool Equals(object obj)
        {
            var dto = obj as TransactionDto;
            if (dto == null)
                return false;
            if (dto.TypeTransactionId != TypeTransactionId)
                return false;
            if (dto.Description != Description)
                return false;
            if (dto.DebitAccountId != DebitAccountId)
                return false;
            if (dto.CreditAccountId != CreditAccountId)
                return false;
            if (dto.Sum != Sum)
                return false;
            if (dto.Date != Date)
                return false;
            if (dto.CategoryId != CategoryId)
                return false;
            if (dto.CategoryId != CategoryId)
                return false;
            if (dto.IdentityId != IdentityId)
                return false;
            return true;
        }
    }
}