#nullable disable

namespace FM.SHD.Domain.Models.Transactions
{
    public partial class TransactionState
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public enum TypeOfTransactionStates
    {
        Расход = 1,
        Доход = 2,
        Перевод = 3
    }
}