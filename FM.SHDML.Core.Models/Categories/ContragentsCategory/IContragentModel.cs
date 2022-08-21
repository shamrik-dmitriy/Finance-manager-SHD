namespace FM.SHDML.Core.Models.Categories.Contragents
{
    public interface IContragentModel
    {
        /// <summary>
        ///     Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        ///     Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Описание
        /// </summary>
        public string Description { get; set; }
    }
}