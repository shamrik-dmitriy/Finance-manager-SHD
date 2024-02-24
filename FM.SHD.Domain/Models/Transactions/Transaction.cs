#nullable disable

using FM.SHD.Domain.Accounts;
using FM.SHD.Domain.Categories;

namespace FM.SHD.Domain.Transactions
{
    public partial class Transaction
    {
        public long Id { get; set; }
        public long TypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sum { get; set; }
        public string Date { get; set; }
        public long? CategoryId { get; set; }
        public long? ContragentId { get; set; }
        public long? IdentityId { get; set; }
        public long? DebitAccountId { get; set; }
        public long? CreditAccountId { get; set; }
        public long? ReceiptId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Account CreditAccount { get; set; }
        public virtual Account DebitAccount { get; set; }
        public virtual Receipt Receipt { get; set; }
        public virtual TransactionType Type { get; set; }
    }
}
