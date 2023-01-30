using FM.SHD.Infrastructure.Events;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Events
{
    public class OnSelectedTypeOfTransactionApplicationEvent : IApplicationEvent
    {
        public int TypeOfTransaction { get; set; }
    }
}