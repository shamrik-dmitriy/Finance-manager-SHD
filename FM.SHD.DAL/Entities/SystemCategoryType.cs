using System;
using System.Collections.Generic;

#nullable disable

namespace FM.SHD.DAL.Entities2
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
