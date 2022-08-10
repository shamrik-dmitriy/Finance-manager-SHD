using FM.SHD.Infrastructure.Events;

namespace FM.SHD.Presenters.Events
{
    public class SelectedTypeOfTransactionApplicationEvent : IApplicationEvent
    {
        public int TypeOfTransaction { get; set; }
    }
}