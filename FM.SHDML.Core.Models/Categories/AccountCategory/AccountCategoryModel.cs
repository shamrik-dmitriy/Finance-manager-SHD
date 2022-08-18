using System.ComponentModel.DataAnnotations;

namespace FM.SHDML.Core.Models.Categories.AccountCategory
{
    public class AccountCategoryModel : IAccountCategoryModel
    {
        /// <summary>
        ///     Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        ///     Наименование счёта
        /// </summary>
        [MaxLength(255, ErrorMessage = "Длина названия категории счёта не может превышать 255 символов")]
        public string Name { get; set; }

        /// <summary>
        ///     Описание счёта
        /// </summary>
        [MaxLength(255, ErrorMessage = "Длина описания категории счёта не может превышать 255 символов")]
        public string Description { get; set; }
    }
}