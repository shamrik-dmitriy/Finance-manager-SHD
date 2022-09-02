using System;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Services.AccountServices;
using FM.SHD.Services.CategoriesServices;
using FM.SHD.Services.CommonServices;
using FM.SHD.Services.ComponentsServices.TypeTransactionService;
using FM.SHD.Services.ContragentServices;
using FM.SHD.Services.CurrencyServices;
using FM.SHD.Services.IdentityServices;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.UserControlPresenters.Common
{
    public class CategoryUcPresenter<T> :
        ICategoryUCPresenter<AccountServices>,
        ICategoryUCPresenter<AccountCategoryServices>,
        ICategoryUCPresenter<TypeTransactionServices>,
        ICategoryUCPresenter<CategoriesServices>,
        ICategoryUCPresenter<IdentityServices>,
        ICategoryUCPresenter<ContragentServices>,
        ICategoryUCPresenter<CurrencyServices>
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
            
        }

        private event Action<long> SelectedIndexChanged;

        event Action<long> ICategoryUCPresenter<AccountServices>.CategoryChanged
        {
            add => SelectedIndexChanged += value;
            remove => SelectedIndexChanged -= value;
        }   
        
        event Action<long> ICategoryUCPresenter<CurrencyServices>.CategoryChanged
        {
            add => SelectedIndexChanged += value;
            remove => SelectedIndexChanged -= value;
        }

        event Action<long> ICategoryUCPresenter<TypeTransactionServices>.CategoryChanged
        {
            add => SelectedIndexChanged += value;
            remove => SelectedIndexChanged -= value;
        }

        public event Action<long> CategoryChanged;

        public void SetCategoryValues()
        {
            _categoryUcView.SetDataSource(((IBaseCategoryServices)_service).GetAll());
        }

        public ICategoryUCView GetUserControlView()
        {
            return _categoryUcView;
        }

        public void SetText(string text)
        {
            _categoryUcView.SetLabelText(text);
        }

        public long? GetCategoryId(bool isPossibleNull = false)
        {
            return _categoryUcView.GetCategoryId();
        }      
        
        public BaseDto GetCategoryDto()
        {
            return _categoryUcView.GetCategoryDto();
        }

        public void SetVisible(bool isVisible)
        {
            _categoryUcView.SetVisible(isVisible);
        }

        public void SetStyleDropDownList()
        {
            _categoryUcView.SetStyleDropDownList();
        }

        public void SetStyleDropDown()
        {
            _categoryUcView.SetStyleDropDown();
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