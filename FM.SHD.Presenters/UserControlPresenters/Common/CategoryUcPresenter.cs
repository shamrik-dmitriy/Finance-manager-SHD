using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Services.AccountServices;
using FM.SHD.Services.CommonServices;
using FM.SHD.Services.ComponentsServices.TypeTransactionService;

namespace FM.SHD.Presenters.UserControlPresenters.Common
{
    public class CategoryUcPresenter<T> : 
        ICategoryUCPresenter<AccountServices>,
        ICategoryUCPresenter<TypeTransactionServices>
    {
        private readonly T _service;
        private readonly ICategoryUCView _categoryUcView;

        public CategoryUcPresenter(
            T service,
            ICategoryUCView categoryUcView)
        {
            _service = service;
            _categoryUcView = categoryUcView;

            _categoryUcView.OnLoadUserControlView += CategoryUcViewOnOnLoadUserControlView;
        }

        private void CategoryUcViewOnOnLoadUserControlView()
        {
            _categoryUcView.SetDataSource(((ICategoryServices)_service).GetAll());
        }

        public void SetCategoryValues()
        {
            _categoryUcView.SetDataSource(((ICategoryServices)_service).GetAll());
        }

        public ICategoryUCView GetUserControlView()
        {
            return _categoryUcView;
        }

        public void SetText(string text)
        {
            _categoryUcView.SetLabelText(text);
        }

        public (int, string) GetCategoryInfo()
        {
            return _categoryUcView.GetCategoryInfo();
        }

        public void SetVisible(bool isVisible)
        {
            _categoryUcView.SetVisible(isVisible);
        }
    }
}