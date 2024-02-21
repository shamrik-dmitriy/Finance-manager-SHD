#nullable disable

using System.Collections.Generic;

namespace FM.SHD.DAL.Entities.User
{
    public partial class UserReceipt
    {
        public UserReceipt()
        {
            UsrTransactions = new HashSet<UserTransaction>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public long? UsrCategoryContragentId { get; set; }
        public long? UsrAccountId { get; set; }

        public virtual UserAccount UserAccount { get; set; }
        public virtual UserCategory UserCategoryContragent { get; set; }
        public virtual ICollection<UserTransaction> UsrTransactions { get; set; }
    }
}
