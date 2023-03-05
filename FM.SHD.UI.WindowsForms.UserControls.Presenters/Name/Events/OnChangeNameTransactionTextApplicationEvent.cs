using FM.SHD.Infrastructure.Events;
using FM.SHD.Infrastructure.Events.ApplicationEvents;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Name.Events
{
    public class OnChangeNameTransactionTextApplicationEvent : IApplicationEvent
    {
        public string Text { get; set; }
    }
}