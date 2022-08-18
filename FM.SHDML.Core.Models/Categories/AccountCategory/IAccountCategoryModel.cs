namespace FM.SHDML.Core.Models.Categories.AccountCategory
{
    public class IAccountCategoryModel
    {
        /// <summary>
        ///     Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        ///     Наименование счёта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Описание счёта
        /// </summary>
        public string Description { get; set; }
    }
}