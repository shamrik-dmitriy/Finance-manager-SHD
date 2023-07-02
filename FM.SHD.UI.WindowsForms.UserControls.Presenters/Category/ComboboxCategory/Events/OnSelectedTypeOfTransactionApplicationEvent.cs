using FM.SHD.Infrastructure.Events.ApplicationEvents;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Category.ComboboxCategory.Events
{
    public class OnSelectedTypeOfTransactionApplicationEvent : IApplicationEvent
    {
        public int TypeOfTransaction { get; set; }
    }
}