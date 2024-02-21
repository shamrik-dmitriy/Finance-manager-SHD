#nullable disable

using System.Collections.Generic;
using FM.SHD.DAL.Entities.User;

namespace FM.SHD.DAL.Entities.System
{
    public partial class SystemCategoryType
    {
        public SystemCategoryType()
        {
            UsrCategories = new HashSet<UserCategory>();
        }

        public long Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<UserCategory> UsrCategories { get; set; }
    }
}
