using FM.SHD.Infrastructure.Events;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Events
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