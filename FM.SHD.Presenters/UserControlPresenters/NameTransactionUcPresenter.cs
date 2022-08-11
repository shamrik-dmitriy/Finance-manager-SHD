using FM.SHD.Presenters.Interfaces.UserControls;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace FM.SHD.Presenters.UserControlPresenters
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