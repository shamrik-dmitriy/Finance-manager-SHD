namespace FM.SHDML.Core.Models.Categories.Categories
{
    public class CategoriesModel : ICategoriesModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long ParentId { get; set; }
        public CategoryTypes CategoryType { get; set; }
    }
}