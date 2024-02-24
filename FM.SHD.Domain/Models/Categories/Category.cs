#nullable disable

using System.Collections.Generic;
using FM.SHD.Domain.Transactions;

namespace FM.SHD.Domain.Categories
{
    public partial class Category
    {
        public Category()
        {
            Transactions = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
