#nullable disable

using FM.SHD.Domain.Entities.System;

namespace FM.SHD.Domain.Entities.User
{
    public partial class UserTransaction
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public long SysTransactionStatesTypeId { get; set; }
        public decimal Sum { get; set; }
        public long UserCategoryId { get; set; }
        public long? UserCategoryContragentId { get; set; }
        public long? UserDebitAccountId { get; set; }
        public long? UserDebitCreditId { get; set; }
        public long? UserReceiptsId { get; set; }

        public virtual SystemTransactionState SystemTransactionStatesType { get; set; }
        public virtual UserCategory UserCategory { get; set; }
        public virtual UserCategory UserCategoryContragent { get; set; }
        public virtual UserAccount UserDebitAccount { get; set; }
        public virtual UserAccount UserDebitCredit { get; set; }
        public virtual UserReceipt UserReceipts { get; set; }
    }
}
