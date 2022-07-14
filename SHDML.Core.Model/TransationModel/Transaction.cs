using System;
using System.Collections.Generic;
using SHDML.CORE.MODEL.Categories;

namespace SHDML.CORE.MODEL.TransationModel
{
    /// <summary>
    ///     Сущность транзакции.
    ///     Описывает позицию в чеке (доступно и без сущности чек)
    /// </summary>
    public class Transaction
    {
        /// <summary>
        ///     Наименование товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Счета с которых производится оплата за позицию в чеке
        /// </summary>
        public List<Account.AccountModel> Accounts { get; set; }

        /// <summary>
        ///     Сумма за конкретную позицию в чеке
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        ///     Дата и время обработки позиции
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        ///     Категория позиции в чеке
        /// </summary>
        public BaseCategory Category { get; set; }

        /// <summary>
        ///     Брендовое название магазина где была совершена покупка
        /// </summary>
        public string StoreBrandName { get; set; }

        /// <summary>
        ///     Член семьи, осуществивший покупку позиции
        /// </summary>
        public string FamilyMember { get; set; }

        /// <summary>
        ///     Состояние транзакции <see cref="TransactionState"/>
        /// </summary>
        public TransactionState State { get; set; }

        /// <summary>
        ///     Тип транзакции <see cref="TransactionType"/>
        /// </summary>
        public TransactionType Type { get; set; }
    }
}