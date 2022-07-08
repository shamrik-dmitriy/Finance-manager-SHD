namespace SHDML.Core.Model.Types
{
    /// <summary>
    ///     Тип налогообложения
    /// </summary>
    public enum TaxationType
    {
        /// <summary>
        ///     Общас система налогообложения
        /// </summary>
        Common = 1,
        
        /// <summary>
        ///     Упрощенная система налогообложения (доход) 
        /// </summary>
        SimpleIn = 2,
        
        /// <summary>
        ///     Упрощенная система налогообложения (доход минус расход)
        /// </summary>
        SimpleInOut = 4,
        
        /// <summary>
        ///     Удиный налог на вмененый доход
        /// </summary>
        Unified = 8,
        
        /// <summary>
        ///     Единый сельскохозяйственный налог
        /// </summary>
        UnifiedAgricultural = 16,
        
        /// <summary>
        ///     Патентная система налогообложения
        /// </summary>
        Patent = 32
    }
}