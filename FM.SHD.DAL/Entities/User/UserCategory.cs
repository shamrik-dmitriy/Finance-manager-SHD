#nullable disable

using System.Collections.Generic;
using FM.SHD.DAL.Entities.System;

namespace FM.SHD.DAL.Entities.User
{
    public partial class UserCategory
    {
        public UserCategory()
        {
            UserAccounts = new HashSet<UserAccount>();
            UserReceipts = new HashSet<UserReceipt>();
            UserTransactionCategories = new HashSet<UserTransaction>();
            UserTransactionCategoryContragents = new HashSet<UserTransaction>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long SysCategoryTypeId { get; set; }
        public long? ParentId { get; set; }

        public virtual SystemCategoryType SystemCategoryType { get; set; }
        public virtual ICollection<UserAccount> UserAccounts { get; set; }
        public virtual ICollection<UserReceipt> UserReceipts { get; set; }
        public virtual ICollection<UserTransaction> UserTransactionCategories { get; set; }
        public virtual ICollection<UserTransaction> UserTransactionCategoryContragents { get; set; }
    }
}
