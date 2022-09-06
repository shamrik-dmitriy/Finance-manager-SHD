namespace FM.SHDML.Core.Models.old.model.Receipt
{
    public class ItemModel
    {
        /// <summary>
        ///     Наименование товара
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        ///     Стоимость
        /// </summary>
        public decimal Price { get; set; }
        
        /// <summary>
        ///     Количество
        /// </summary>
        public int Quantity { get; set; }
        
        /// <summary>
        ///     Сумма
        /// </summary>
        public decimal Sum { get; set; }
        
        /// <summary>
        ///     Тип платежа
        /// </summary>
        public int PaymentType { get; set; }
        
        /// <summary>
        ///     НДС
        /// </summary>
        public int Nds { get; set; }
    }
}