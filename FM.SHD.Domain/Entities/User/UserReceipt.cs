#nullable disable

using System.Collections.Generic;

namespace FM.SHD.Domain.Entities.User
{
    public partial class UserReceipt
    {
        public UserReceipt()
        {
            UserTransactions = new HashSet<UserTransaction>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public long? UserCategoryContragentId { get; set; }
        public long? UserAccountId { get; set; }

        public virtual UserAccount UserAccount { get; set; }
        public virtual UserCategory UserCategoryContragent { get; set; }
        public virtual ICollection<UserTransaction> UserTransactions { get; set; }
    }
}
