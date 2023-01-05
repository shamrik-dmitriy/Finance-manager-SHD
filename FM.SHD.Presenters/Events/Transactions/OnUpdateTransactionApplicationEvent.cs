using FM.SHD.Infrastructure.Events;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.Events.Transactions
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