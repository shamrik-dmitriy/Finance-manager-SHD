using System;
using System.Collections.Generic;

#nullable disable

namespace FM.SHD.DAL.Entities2
{
    public partial class UserTransaction
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public long SysTransactionStatesTypeId { get; set; }
        public byte[] Sum { get; set; }
        public long UsrCategoryId { get; set; }
        public long? UsrCategoryContragentId { get; set; }
        public long? UsrDebitAccountId { get; set; }
        public long? UsrDebitCreditId { get; set; }
        public long? UsrReceiptsId { get; set; }

        public virtual SystemTransactionState SystemTransactionStatesType { get; set; }
        public virtual UserCategory UserCategory { get; set; }
        public virtual UserCategory UserCategoryContragent { get; set; }
        public virtual UserAccount UserDebitAccount { get; set; }
        public virtual UserAccount UserDebitCredit { get; set; }
        public virtual UserReceipt UserReceipts { get; set; }
    }
}
