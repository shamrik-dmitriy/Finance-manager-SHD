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
            _event?.Invoke(id);
            //  throw new System.NotImplementedException();
        }

        private void CategoryUcViewOnOnLoadUserControlView()
        {
            _categoryUcView.SetDataSource(((ICategoryServices)_service).GetAll());
        }

        public event Action<long> _event;

        event Action<long> ICategoryUCPresenter<AccountServices>.CategoryChanged
        {
            add => _event += value;
            remove => _event -= value;
        }

        event Action<long> ICategoryUCPresenter<TypeTransactionServices>.CategoryChanged
        {
            add => _event += value;
            remove => _event -= value;
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

        protected virtual void OnEvent(long obj)
        {
            _event?.Invoke(obj);
        }
    }
}