using System.Collections.Generic;
using System.Linq;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Services.AccountServices;
using FM.SHD.Services.CommonServices;

namespace FM.SHD.Presenters.UserControlPresenters.Common
{
    public class CategoryUcPresenter : ICategoryUCPresenter
    {
        private readonly ICategoryService _categoryService;
        private readonly ICategoryTransactionUCView _categoryTransactionUcView;

        public CategoryUcPresenter(
            ICategoryService categoryService,
            ICategoryTransactionUCView categoryTransactionUcView)
        {
            _categoryService = categoryService;
            _categoryTransactionUcView = categoryTransactionUcView;
        }

        public void SetCategoryValues()
        {
            _categoryTransactionUcView.SetCategoryValues(_categoryService.GetAll());
        }

        public ICategoryTransactionUCView GetUserControlView()
        {
            return _categoryTransactionUcView;
        }

        public void SetText(string text)
        {
            _categoryTransactionUcView.SetLabelText(text);
        }

        public (long, string) GetCategoryInfo()
        {
            return _categoryTransactionUcView.GetCategoryInfo();
        }

        public void SetVisible(bool isVisible)
        {
            _categoryTransactionUcView.SetVisible(isVisible);
        }
    }
}