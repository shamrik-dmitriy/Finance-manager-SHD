using FM.SHD.Infrastructure.Events;

namespace FM.SHD.Presenters.Events
{
    public class OnSelectedTypeOfTransactionApplicationEvent : IApplicationEvent
    {
        public int TypeOfTransaction { get; set; }
    }
}