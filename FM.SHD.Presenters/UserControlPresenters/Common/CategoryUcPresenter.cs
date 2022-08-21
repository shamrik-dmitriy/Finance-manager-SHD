using System;
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
            _categoryUcView.SelectedIndexChanged += CategoryUcViewOnSelectedIndexChanged;
        }

        private void CategoryUcViewOnSelectedIndexChanged(long id)
        {
            SelectedIndexChanged?.Invoke(id);
        }

        private void CategoryUcViewOnOnLoadUserControlView()
        {
            _categoryUcView.SetDataSource(((ICategoryServices)_service).GetAll());
        }

        private event Action<long> SelectedIndexChanged;

        event Action<long> ICategoryUCPresenter<AccountServices>.CategoryChanged
        {
            add => SelectedIndexChanged += value;
            remove => SelectedIndexChanged -= value;
        }

        event Action<long> ICategoryUCPresenter<TypeTransactionServices>.CategoryChanged
        {
            add => SelectedIndexChanged += value;
            remove => SelectedIndexChanged -= value;
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

        void ICategoryUCPresenter<TypeTransactionServices>.SetStyleDropDownList()
        {
            _categoryUcView.SetStyleDropDownList();
        }

        void ICategoryUCPresenter<TypeTransactionServices>.SetStyleDropDown()
        {
            _categoryUcView.SetStyleDropDown();
        }

        void ICategoryUCPresenter<AccountServices>.SetStyleDropDownList()
        {
            _categoryUcView.SetStyleDropDownList();
        }

        void ICategoryUCPresenter<AccountServices>.SetStyleDropDown()
        {
            _categoryUcView.SetStyleDropDown();
        }
    }
}