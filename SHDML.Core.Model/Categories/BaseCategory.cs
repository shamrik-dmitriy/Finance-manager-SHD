namespace SHDML.CORE.MODEL.Categories
{
    /// <summary>
    ///     Базовый класс для категории
    /// </summary>
    public class BaseCategory
    {
        /// <summary>
        ///     Наименование категории
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        ///     Описание категории
        /// </summary>
        public string Description { get; set; }
    }
}