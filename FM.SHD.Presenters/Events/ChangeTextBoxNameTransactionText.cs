using FM.SHD.Infrastructure.Events;

namespace FM.SHD.Presenters.Events
{
    public class ChangeTextBoxNameTransactionText : IApplicationEvent
    {
        public string Text { get; set; }
    }
}