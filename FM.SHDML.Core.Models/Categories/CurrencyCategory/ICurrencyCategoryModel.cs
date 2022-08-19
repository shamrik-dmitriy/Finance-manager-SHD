namespace FM.SHDML.Core.Models.Categories.CurrencyCategory
{
    public interface ICurrencyCategoryModel : ICategoryModel
    {
        /// <summary>
        ///     Символ валюты
        /// </summary>
        public string Symbol { get; set; }
    }
}