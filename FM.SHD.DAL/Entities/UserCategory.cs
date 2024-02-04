using System;
using System.Collections.Generic;

#nullable disable

namespace FM.SHD.DAL.Entities2
{
    public partial class UserCategory
    {
        public UserCategory()
        {
            UsrAccounts = new HashSet<UserAccount>();
            UsrReceipts = new HashSet<UserReceipt>();
            UsrTransactionusrCategories = new HashSet<UserTransaction>();
            UsrTransactionusrCategoryContragents = new HashSet<UserTransaction>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long SysCategoryTypeId { get; set; }
        public long? ParentId { get; set; }

        public virtual SystemCategoryType SystemCategoryType { get; set; }
        public virtual ICollection<UserAccount> UsrAccounts { get; set; }
        public virtual ICollection<UserReceipt> UsrReceipts { get; set; }
        public virtual ICollection<UserTransaction> UsrTransactionusrCategories { get; set; }
        public virtual ICollection<UserTransaction> UsrTransactionusrCategoryContragents { get; set; }
    }
}
