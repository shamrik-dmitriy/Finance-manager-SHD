using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
{
    public class NameTransactionUcPresenter : INameTransactionUCPresenter
    {
        private readonly INameTransactionUCView _nameTransactionUcView;

        public NameTransactionUcPresenter(
            INameTransactionUCView nameTransactionUcView)
        {
            _nameTransactionUcView = nameTransactionUcView;
        }

        public INameTransactionUCView GetUserControlView()
        {
            return _nameTransactionUcView;
        }
    }
}