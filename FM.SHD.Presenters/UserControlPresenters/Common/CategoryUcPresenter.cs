using System.Collections.Generic;
using System.Linq;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Services.AccountServices;

namespace FM.SHD.Presenters.UserControlPresenters.Common
{
    public class CategoryUcPresenter : ICategoryUCPresenter
    {
        private readonly IAccountCategoryServices _accountCategoryServices;
        private readonly ICategoryTransactionUCView _categoryTransactionUcView;

        public CategoryUcPresenter(
            IAccountCategoryServices accountCategoryServices,
            ICategoryTransactionUCView categoryTransactionUcView)
        {
            _accountCategoryServices = accountCategoryServices;
            _categoryTransactionUcView = categoryTransactionUcView;
        }

        public void SetCategoryValues()
        {
            _categoryTransactionUcView.SetCategoryValues( _accountCategoryServices.GetAll().Select(x=>x.Name));
        }

        public ICategoryTransactionUCView GetUserControlView()
        {
            return _categoryTransactionUcView;
        }

        public void SetText(string text)
        {
            _categoryTransactionUcView.SetLabelText(text);
        }

        public (int, string) GetCategoryInfo()
        {
            return _categoryTransactionUcView.GetCategoryInfo();
        }
    }
}