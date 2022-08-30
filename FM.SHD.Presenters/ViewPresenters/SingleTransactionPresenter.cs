using System;
using FM.SHD.Presenters.Interfaces;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.Interfaces.Views;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Services.CategoriesServices;
using FM.SHD.Services.ComponentsServices.TypeTransactionService;
using FM.SHD.Services.ContragentServices;
using FM.SHD.Services.IdentityServices;
using FM.SHD.Services.SingleTransactionServices;
using FM.SHDML.Core.Models.Dtos;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;

namespace FM.SHD.Presenters.ViewPresenters
{
    public class SingleTransactionPresenter : ISingleTransactionPresenter
    {
        private ISingleTransactionView _singleTransactionView;
        private ISingleTransactionServices _singleTransactionServices;
        private readonly ICategoryUCPresenter<TypeTransactionServices> _typeTransactionUcPresenter;
        private readonly INameUCPresenter _nameUcPresenter;
        private readonly IDescriptionUCPresenter _descriptionUcPresenter;
        private readonly IAccountsInfoTransactionUCPresenter _accountsInfoTransactionUcPresenter;
        private readonly ICategoryUCPresenter<CategoriesServices> _categoriesUcPresenter;
        private readonly ICategoryUCPresenter<ContragentServices> _contrAgentUcPresenter;
        private readonly ICategoryUCPresenter<IdentityServices> _identityUcPresenter;
        private readonly IContinueCancelButtonsUCPresenter _continueCancelButtonsUcPresenter;

        public SingleTransactionPresenter(
            ISingleTransactionView singleTransactionView,
            ISingleTransactionServices singleTransactionServices,
            ICategoryUCPresenter<TypeTransactionServices> typeTransactionUcPresenter,
            INameUCPresenter nameUcPresenter,
            IDescriptionUCPresenter descriptionUcPresenter,
            IAccountsInfoTransactionUCPresenter accountsInfoTransactionUcPresenter,
            ICategoryUCPresenter<CategoriesServices> categoriesUcPresenter,
            ICategoryUCPresenter<ContragentServices> contrAgentUcPresenter,
            ICategoryUCPresenter<IdentityServices> identityUcPresenter,
            IContinueCancelButtonsUCPresenter continueCancelButtonsUcPresenter)
        {
            _singleTransactionView = singleTransactionView;
            _singleTransactionServices = singleTransactionServices;

            _typeTransactionUcPresenter = typeTransactionUcPresenter;
            _nameUcPresenter = nameUcPresenter;
            _descriptionUcPresenter = descriptionUcPresenter;
            _accountsInfoTransactionUcPresenter = accountsInfoTransactionUcPresenter;
            _categoriesUcPresenter = categoriesUcPresenter;
            _contrAgentUcPresenter = contrAgentUcPresenter;
            _identityUcPresenter = identityUcPresenter;
            _continueCancelButtonsUcPresenter = continueCancelButtonsUcPresenter;
            
            _singleTransactionView.OnLoadView += SingleTransactionViewOnOnLoad;
            _typeTransactionUcPresenter.CategoryChanged += TypeTransactionUcPresenterOnCategoryChanged;

        }

        private void TypeTransactionUcPresenterOnCategoryChanged(long id)
        {
            _accountsInfoTransactionUcPresenter.CategoryChanged(id);
        }

        private void SingleTransactionViewOnOnLoad()
        {
            _typeTransactionUcPresenter.SetText("Тип транзакции");
            _typeTransactionUcPresenter.SetStyleDropDownList();
            _singleTransactionView.AddUserControl(_typeTransactionUcPresenter.GetUserControlView());
            _singleTransactionView.AddUserControl(_nameUcPresenter.GetUserControlView());
            _singleTransactionView.AddUserControl(_descriptionUcPresenter
                .GetUserControlView());
            _singleTransactionView.AddHorizontalLine();
            _singleTransactionView.AddUserControl(_accountsInfoTransactionUcPresenter
                .GetUserControlView());
            _singleTransactionView.AddHorizontalLine();
            _categoriesUcPresenter.SetStyleDropDown();
            _categoriesUcPresenter.SetText("Категория");
            _singleTransactionView.AddUserControl(_categoriesUcPresenter.GetUserControlView());
            _contrAgentUcPresenter.SetStyleDropDown();
            _contrAgentUcPresenter.SetText("Контрагент");
            _singleTransactionView.AddUserControl(_contrAgentUcPresenter.GetUserControlView());
            _identityUcPresenter.SetStyleDropDown();
            _identityUcPresenter.SetText("Член семьи");
            _singleTransactionView.AddUserControl(_identityUcPresenter.GetUserControlView());
            _singleTransactionView.AddUserControl(_continueCancelButtonsUcPresenter.GetUserControlView());

            _continueCancelButtonsUcPresenter.Continue += ContinueCancelButtonsUcPresenterOnContinue;
        }

        private void ContinueCancelButtonsUcPresenterOnContinue()
        {
            _singleTransactionServices.Add(new SingleTransactionDto
            {
                TypeTransactionId = _typeTransactionUcPresenter.GetCategoryId(),
                Name = _nameUcPresenter.GetName(),
                Description = _descriptionUcPresenter.GetDescription(),
                DebitAccountId = _accountsInfoTransactionUcPresenter.GetDebitAccountId(),
                Sum = _accountsInfoTransactionUcPresenter.GetSum(),
                CreditAccountId = _accountsInfoTransactionUcPresenter.GetCreditAccountId(),
                Date = _accountsInfoTransactionUcPresenter.GetDate(),
                CategoryId = _categoriesUcPresenter.GetCategoryId(),
                ContragentId = _contrAgentUcPresenter.GetCategoryId(),
                IdentityId = _identityUcPresenter.GetCategoryId()
            });
            _singleTransactionView.CloseView();
        }

        private void SingleTransactionViewOnAdd(object sender, EventArgs e)
        {
            SingleTransactionDto dto = _singleTransactionView.GetTransactionInfo();
            _singleTransactionServices.Add(dto);
        }

        public ISingleTransactionView GetView()
        {
            return _singleTransactionView;
        }
    }
}