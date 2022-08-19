namespace FM.SHDML.Core.Models.Categories
{
    public interface ICategoryModel
    {
        /// <summary>
        ///     Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        ///     Наименование счёта
        /// </summary>
        public string Name { get; set; }
    }
}