using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
{
    public class CategoryTransactionUCPresenter : ICategoryTransactionUCPresenter
    {
        private readonly ICategoryTransactionUCView _categoryTransactionUcView;

        public CategoryTransactionUCPresenter(ICategoryTransactionUCView categoryTransactionUcView)
        {
            _categoryTransactionUcView = categoryTransactionUcView;
        }

        public ICategoryTransactionUCView GetUserControlView()
        {
            return _categoryTransactionUcView;
        }
    }
}