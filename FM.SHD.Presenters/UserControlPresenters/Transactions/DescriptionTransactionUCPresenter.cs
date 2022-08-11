using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
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