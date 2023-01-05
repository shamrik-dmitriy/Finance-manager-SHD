namespace FM.SHD.Domain
{
    /// <summary>
    ///     Тип операции
    /// </summary>
    public enum TransactionType
    {
        /// <summary>
        ///     Расход
        /// </summary>
        Expense = 1,

        /// <summary>
        ///     Доход
        /// </summary>
        Income = 2,

        /// <summary>
        ///     Перевод
        /// </summary>
        Transfer = 3
    }
}