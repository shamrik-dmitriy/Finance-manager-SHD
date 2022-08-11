using FM.SHD.Presenters.Interfaces.UserControls;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace FM.SHD.Presenters.UserControlPresenters
{
    public class NameTransactionUserControlPresenter : INameTransactionUserControlPresenter
    {
        private readonly INameTransactionUserControlView _nameTransactionUserControlView;

        public NameTransactionUserControlPresenter(
            INameTransactionUserControlView nameTransactionUserControlView)
        {
            _nameTransactionUserControlView = nameTransactionUserControlView;
        }

        public INameTransactionUserControlView GetUserControlView()
        {
            return _nameTransactionUserControlView;
        }
    }
}