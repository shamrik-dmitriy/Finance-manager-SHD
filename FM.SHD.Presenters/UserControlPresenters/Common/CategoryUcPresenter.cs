using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.UserControlPresenters.Common
{
    public class CategoryUcPresenter : ICategoryUCPresenter
    {
        private readonly ICategoryTransactionUCView _categoryTransactionUcView;

        public CategoryUcPresenter(ICategoryTransactionUCView categoryTransactionUcView)
        {
            _categoryTransactionUcView = categoryTransactionUcView;
        }

        public ICategoryTransactionUCView GetUserControlView()
        {
            return _categoryTransactionUcView;
        }
    }
}