using FM.SHD.Infrastructure.Events;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Category.Events
{
    public class OnSelectedTypeOfTransactionApplicationEvent : IApplicationEvent
    {
        public int TypeOfTransaction { get; set; }
    }
}