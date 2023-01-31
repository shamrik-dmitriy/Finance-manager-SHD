using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Infrastructure.Events.ApplicationEvents.Transactions
{
    public class OnUpdateTransactionApplicationEvent : IApplicationEvent
    {
        public OnUpdateTransactionApplicationEvent(TransactionDto transactionDto)
        {
            TransactionDto = transactionDto;
        }

        public TransactionDto TransactionDto { get; set; }
    }
}