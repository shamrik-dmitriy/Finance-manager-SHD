#nullable disable

using System.Collections.Generic;
using FM.SHD.Domain.Transactions;

namespace FM.SHD.Domain.Contragents
{
    public partial class Contragent
    {
        public Contragent()
        {
            Receipts = new HashSet<Receipt>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
