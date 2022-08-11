using FM.SHD.Presenters.Interfaces.UserControls;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace FM.SHD.Presenters.UserControlPresenters
{
    public class DescriptionTransactionUCPresenter : IDescriptionTransactionUCPresenter
    {
        private readonly IDescriptionTransactionUCView _descriptionTransactionUcView;

        public DescriptionTransactionUCPresenter(IDescriptionTransactionUCView descriptionTransactionUcView)
        {
            _descriptionTransactionUcView = descriptionTransactionUcView;
        }

        public IDescriptionTransactionUCView GetUserControlView()
        {
            return _descriptionTransactionUcView;
        }
    }
}