namespace FM.SHD.Infrastructure.Repositories.DatabaseConstants
{
    public static class DbConstants
    {
        public static class UserTables
        {
            public static class CategoriesTable
            {
                public const string Name = "u_categories";

                public static class Columns
                {
                    public const string Id = "id";
                    public const string Name = "name";
                    public const string Description = "description";
                    public const string ParentID = "parent_id";
                    public const string CategoryType = "category_type_id";
                }

            }     
        }      
        
        public static class SystemTables
        {

            public static class CategoryTypesTable
            {
                public const string Name = "system_category_types";

                public static class Columns
                {
                    public const string Id = "id";
                }

            }
        }
    }
}