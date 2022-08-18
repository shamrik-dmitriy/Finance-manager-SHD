using System.ComponentModel.DataAnnotations;

namespace FM.SHDML.Core.Models.Categories.CurrencyCategory
{
    public class CurrencyCategoryModel : ICurrencyCategoryModel
    {
        /// <summary>
        ///     Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        ///     Наименование валюты
        /// </summary>
        [MaxLength(50, ErrorMessage = "Длина названия валюты не может превышать 50 символов")]
        public string Name { get; set; }

        /// <summary>
        ///     Символ валюты
        /// </summary>
        [MaxLength(1, ErrorMessage = "Символ валюты не может превышать 1 символов")]
        public string Symbol { get; set; }
    }
}