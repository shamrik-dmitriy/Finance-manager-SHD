using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Infrastructure.Events.ApplicationEvents.Transactions
{
    public class OnAddedTransactionApplicationEvent : IApplicationEvent
    {
        public OnAddedTransactionApplicationEvent(TransactionDto transactionDto)
        {
            TransactionDto = transactionDto;
        }

        public TransactionDto TransactionDto { get; set; }
    }
}