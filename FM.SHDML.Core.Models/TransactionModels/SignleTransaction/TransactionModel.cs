using System;
using System.ComponentModel.DataAnnotations;

namespace FM.SHDML.Core.Models.TransactionModels.SignleTransaction
{
    public class TransactionModel : ITransactionModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Укажите тип транзакции")]
        public long? TypeTransactionId { get; set; }

        [MaxLength(255, ErrorMessage = "Длина названия транзакции не может превышать 255 символов")]
        public string Name { get; set; }

        [MaxLength(255, ErrorMessage = "Длина описания транзакции не может превышать 255 символов")]
        public string Description { get; set; }

        /// <summary>
        ///     Счёт списания
        /// </summary>
        public long? DebitAccountId { get; set; }

        /// <summary>
        ///     Счет пополнения
        /// </summary>
        public long? CreditAccountId { get; set; }

        public decimal Sum { get; set; }

        [Required(ErrorMessage = "Укажите дату совершения транзакции")]
        public DateTime Date { get; set; }

        public long? CategoryId { get; set; }

        public long? ContragentId { get; set; }

        public long? IdentityId { get; set; }
        public long? ReceiptId { get; set; }
    }
}