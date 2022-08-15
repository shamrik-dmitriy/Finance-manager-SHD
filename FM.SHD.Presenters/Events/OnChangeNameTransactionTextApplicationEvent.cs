using FM.SHD.Infrastructure.Events;

namespace FM.SHD.Presenters.Events
{
    public class OnChangeNameTransactionTextApplicationEvent : IApplicationEvent
    {
        public string Text { get; set; }
    }
}