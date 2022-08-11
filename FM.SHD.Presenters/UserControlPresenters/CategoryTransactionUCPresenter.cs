using FM.SHD.Presenters.Interfaces.UserControls;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace FM.SHD.Presenters.UserControlPresenters
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