using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Infrastructure.Events.ApplicationEvents.Transactions
{
    public class OnDeleteTransactionApplicationEvent : IApplicationEvent
    {
        public OnDeleteTransactionApplicationEvent(TransactionDto transactionDto)
        {
            TransactionDto = transactionDto;
        }

        public TransactionDto TransactionDto { get; set; }
    }
}