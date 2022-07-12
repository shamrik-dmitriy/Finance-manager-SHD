namespace SHDML.CORE.MODEL.Account
{
    /// <summary>
    ///     Модель для счёта
    /// </summary>
    public class AccountModel
    {
        /// <summary>
        ///     Наименование счёта
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        ///     Описание счёта
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        ///     Текущая сумма счёта
        /// </summary>
        public double CurrentSum { get; set; }
        
        /// <summary>
        ///     Изначальная сумма счёта
        /// </summary>
        public double InitialSum { get; set; }
        
        /// <summary>
        ///     Определяет закрытый или открытый счёт
        /// </summary>
        public bool IsClosed { get; set; }
        
        /// <summary>
        ///     Валюта
        /// </summary>
        public string Currency { get; set; }
    }
}