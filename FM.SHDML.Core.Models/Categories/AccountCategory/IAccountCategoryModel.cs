namespace FM.SHDML.Core.Models.Categories.AccountCategory
{
    public interface IAccountCategoryModel : ICategoryModel
    {
        /// <summary>
        ///     Описание счёта
        /// </summary>
        public string Description { get; set; }
    }
}