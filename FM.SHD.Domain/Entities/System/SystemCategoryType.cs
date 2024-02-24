#nullable disable

using System.Collections.Generic;
using FM.SHD.Domain.Entities.User;

namespace FM.SHD.Domain.Entities.System
{
    public partial class SystemCategoryType
    {
        public SystemCategoryType()
        {
            UserCategories = new HashSet<UserCategory>();
        }

        public long Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<UserCategory> UserCategories { get; set; }
    }
}
