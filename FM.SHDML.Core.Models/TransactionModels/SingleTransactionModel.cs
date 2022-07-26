using System;
using System.ComponentModel.DataAnnotations;

namespace FM.SHDML.Core.Models.TransactionModels
{
    public class SingleTransactionModel : ISingleTransactionModel
    {
        public long Id { get; set; }

        public string Type { get; set; }

        [MaxLength(255, ErrorMessage = "Длина названия транзакции не может превышать 255 символов")]
        public string Name { get; set; }

        [MaxLength(255, ErrorMessage = "Длина описания транзакции не может превышать 255 символов")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Укажите счёт для транзакции")]
        public string Account { get; set; }

        public string Sum { get; set; }

        [Required(ErrorMessage = "Укажите дату совершения транзакции")]
        public string Date { get; set; }

        public string Category { get; set; }

        public string Contragent { get; set; }

        public string FamilyMember { get; set; }

    }
}
