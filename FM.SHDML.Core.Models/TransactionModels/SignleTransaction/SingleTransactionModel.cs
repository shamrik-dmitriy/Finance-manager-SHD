using System;
using System.ComponentModel.DataAnnotations;

namespace FM.SHDML.Core.Models.TransactionModels.SignleTransaction
{
    public class SingleTransactionModel : ISingleTransactionModel
    {
        public long Id { get; set; }

        public int TypeTransaction { get; set; }

        [MaxLength(255, ErrorMessage = "Длина названия транзакции не может превышать 255 символов")]
        public string Name { get; set; }

        [MaxLength(255, ErrorMessage = "Длина описания транзакции не может превышать 255 символов")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Укажите счёт для транзакции")]
        public long DebitAccount { get; set; }

        [Required(ErrorMessage = "Укажите счёт для транзакции")]
        public long CreditAccount { get; set; }

        public decimal Sum { get; set; }

        [Required(ErrorMessage = "Укажите дату совершения транзакции")]
        public DateTime Date { get; set; }

        public long Category { get; set; }

        public long Contragent { get; set; }

        public long FamilyMember { get; set; }
    }
}