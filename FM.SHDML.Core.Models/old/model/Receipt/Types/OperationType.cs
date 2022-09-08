namespace FM.SHDML.Core.Models.old.model.Receipt.Types
{
    public enum OperationType
    {
        /// <summary>
        ///     Приход
        /// </summary>
        Income = 0,
        
        /// <summary>
        ///     Расход
        /// </summary>
        Expense = 1,
        
        /// <summary>
        ///     Возврат прихода
        /// </summary>
        RefundIncome = 2,
        
        /// <summary>
        ///     Возврат расхода
        /// </summary>
        RefundExpense = 3
        
    }
}