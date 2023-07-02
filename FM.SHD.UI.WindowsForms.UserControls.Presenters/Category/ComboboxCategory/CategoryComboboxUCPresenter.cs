using System;
using FM.SHD.Services.AccountServices;
using FM.SHD.Services.CategoriesServices;
using FM.SHD.Services.CommonServices;
using FM.SHD.Services.ComponentsServices.TypeTransactionService;
using FM.SHD.Services.ContragentServices;
using FM.SHD.Services.CurrencyServices;
using FM.SHD.Services.IdentityServices;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Category.ComboboxCategory
{
    public class CategoryComboboxUCPresenter<T> :
        ICategoryComboboxUCPresenter<AccountServices>,
        ICategoryComboboxUCPresenter<AccountCategoryServices>,
        ICategoryComboboxUCPresenter<TypeTransactionServices>,
        ICategoryComboboxUCPresenter<CategoriesServices>,
        ICategoryComboboxUCPresenter<IdentityServices>,
        ICategoryComboboxUCPresenter<ContragentServices>,
        ICategoryComboboxUCPresenter<CurrencyServices>
    {
        private readonly T _service;
        private readonly ICategoryComboboxUCView _categoryComboboxUCView;

        public CategoryComboboxUCPresenter(
            T service,
            ICategoryComboboxUCView categoryComboboxUCView)
        {
            _service = service;
            _categoryComboboxUCView = categoryComboboxUCView;

            _categoryComboboxUCView.OnLoadUserControlView += CategoryComboboxUCViewOnOnLoadUserControlView;
            _categoryComboboxUCView.SelectedIndexChanged += CategoryComboboxUCViewOnSelectedIndexChanged;
        }

        private void CategoryComboboxUCViewOnSelectedIndexChanged(long id)
        {
            SelectedIndexChanged?.Invoke(id);
        }

        private void CategoryComboboxUCViewOnOnLoadUserControlView()
        {
            
        }

        private event Action<long> SelectedIndexChanged;

        event Action<long> ICategoryComboboxUCPresenter<AccountServices>.CategoryChanged
        {
            add => SelectedIndexChanged += value;
            remove => SelectedIndexChanged -= value;
        }   
        
        event Action<long> ICategoryComboboxUCPresenter<CurrencyServices>.CategoryChanged
        {
            add => SelectedIndexChanged += value;
            remove => SelectedIndexChanged -= value;
        }

        event Action<long> ICategoryComboboxUCPresenter<TypeTransactionServices>.CategoryChanged
        {
            add => SelectedIndexChanged += value;
            remove => SelectedIndexChanged -= value;
        }

        public event Action<long> CategoryChanged;

        public void SetCategoryValues()
        {
            _categoryComboboxUCView.SetDataSource(((IBaseCategoryServices)_service).GetAll());
        }

        public ICategoryComboboxUCView GetUserControlView()
        {
            return _categoryComboboxUCView;
        }

        public void SetText(string text)
        {
            _categoryComboboxUCView.SetLabelText(text);
        }

        public long? GetCategoryId(bool isPossibleNull = false)
        {
            return _categoryComboboxUCView.GetCategoryId();
        }      
        
        public BaseDto GetCategoryDto()
        {
            return _categoryComboboxUCView.GetCategoryDto();
        }

        public void SetVisible(bool isVisible)
        {
            _categoryComboboxUCView.SetVisible(isVisible);
        }

        public void SetStyleDropDownList()
        {
            _categoryComboboxUCView.SetStyleDropDownList();
        }

        public void SetStyleDropDown()
        {
            _categoryComboboxUCView.SetStyleDropDown();
        }

        void ICategoryComboboxUCPresenter<TypeTransactionServices>.SetStyleDropDownList()
        {
            _categoryComboboxUCView.SetStyleDropDownList();
        }

        void ICategoryComboboxUCPresenter<TypeTransactionServices>.SetStyleDropDown()
        {
            _categoryComboboxUCView.SetStyleDropDown();
        }

        void ICategoryComboboxUCPresenter<AccountServices>.SetStyleDropDownList()
        {
            _categoryComboboxUCView.SetStyleDropDownList();
        }

        void ICategoryComboboxUCPresenter<AccountServices>.SetStyleDropDown()
        {
            _categoryComboboxUCView.SetStyleDropDown();
        }
    }
}