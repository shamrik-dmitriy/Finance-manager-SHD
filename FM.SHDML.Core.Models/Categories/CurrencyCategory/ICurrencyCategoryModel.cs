namespace FM.SHDML.Core.Models.Categories.CurrencyCategory
{
    public interface ICurrencyCategoryModel
    {
        /// <summary>
        ///     Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        ///     Наименование валюты
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Символ валюты
        /// </summary>
        public string Symbol { get; set; }
    }
}