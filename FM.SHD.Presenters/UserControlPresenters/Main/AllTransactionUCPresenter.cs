using FM.SHD.Presenters.Interfaces.UserControls.Main;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Main;

namespace FM.SHD.Presenters.UserControlPresenters.Main
{
    public class AllTransactionUCPresenter : IAllTransactionUCPresenter
    {
        private readonly IAllTransactionUCView _allTransactionUcView;

        public AllTransactionUCPresenter(IAllTransactionUCView allTransactionUcView)
        {
            _allTransactionUcView = allTransactionUcView;
        }

        public IAllTransactionUCView GetUserControlView()
        {
            return _allTransactionUcView;
        }
    }
}