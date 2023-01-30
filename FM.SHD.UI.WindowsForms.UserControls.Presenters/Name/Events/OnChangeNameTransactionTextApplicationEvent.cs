using FM.SHD.Infrastructure.Events;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Name.Events
{
    public class OnChangeNameTransactionTextApplicationEvent : IApplicationEvent
    {
        public string Text { get; set; }
    }
}