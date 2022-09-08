using System;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHD.Services.CategoriesServices;
using FM.SHD.Services.ComponentsServices.TypeTransactionService;
using FM.SHD.Services.ContragentServices;
using FM.SHD.Services.IdentityServices;
using FM.SHD.Services.TransactionServices;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.ViewPresenters
{
    public class TransactionPresenter : BaseTransactionPresenter
    {
        private readonly ITransactionView _view;

        #region Private member variables

        private ITransactionServices _transactionServices;
        private readonly ICategoryUCPresenter<TypeTransactionServices> _typeTransactionUcPresenter;
        private readonly INameUCPresenter _nameUcPresenter;
        private readonly IDescriptionUCPresenter _descriptionUcPresenter;
        private readonly IAccountsInfoTransactionUCPresenter _accountsInfoTransactionUcPresenter;
        private readonly ICategoryUCPresenter<CategoriesServices> _categoriesUcPresenter;
        private readonly ICategoryUCPresenter<ContragentServices> _contrAgentUcPresenter;
        private readonly ICategoryUCPresenter<IdentityServices> _identityUcPresenter;
        private readonly IContinueCancelButtonsUCPresenter _continueCancelButtonsUcPresenter;

        #endregion

        #region Constructor / Destructor

        public TransactionPresenter(
            ITransactionView view,
            ITransactionServices transactionServices,
            ICategoryUCPresenter<TypeTransactionServices> typeTransactionUcPresenter,
            INameUCPresenter nameUcPresenter,
            IDescriptionUCPresenter descriptionUcPresenter,
            IAccountsInfoTransactionUCPresenter accountsInfoTransactionUcPresenter,
            ICategoryUCPresenter<CategoriesServices> categoriesUcPresenter,
            ICategoryUCPresenter<ContragentServices> contrAgentUcPresenter,
            ICategoryUCPresenter<IdentityServices> identityUcPresenter,
            IContinueCancelButtonsUCPresenter continueCancelButtonsUcPresenter)
            : base(view)
        {
            _view = view;
            _transactionServices = transactionServices;

            _typeTransactionUcPresenter = typeTransactionUcPresenter;
            _nameUcPresenter = nameUcPresenter;
            _descriptionUcPresenter = descriptionUcPresenter;
            _accountsInfoTransactionUcPresenter = accountsInfoTransactionUcPresenter;
            _categoriesUcPresenter = categoriesUcPresenter;
            _contrAgentUcPresenter = contrAgentUcPresenter;
            _identityUcPresenter = identityUcPresenter;
            _continueCancelButtonsUcPresenter = continueCancelButtonsUcPresenter;

            _view.OnLoadView += OnLoadView;
            _typeTransactionUcPresenter.CategoryChanged += TypeTransactionUcPresenterOnCategoryChanged;
        }

        #endregion

        #region Public Properties

        public TransactionDto TransactionDto { get; set; }

        #endregion

        #region Public methods

        public override void SetTitle(string title)
        {
            _view.SetTitle(title);
        }

        public override void Run(TransactionDto accountDto)
        {
            TransactionDto = accountDto;
            _view.Show();
        }

        #endregion

        #region Private methods

        private void TypeTransactionUcPresenterOnCategoryChanged(long id)
        {
            _accountsInfoTransactionUcPresenter.CategoryChanged(id);
        }

        private void OnLoadView()
        {
            _typeTransactionUcPresenter.SetText("Тип транзакции");
            _categoriesUcPresenter.SetText("Категория");
            _contrAgentUcPresenter.SetText("Контрагент");
            _identityUcPresenter.SetText("Член семьи");

            if (TransactionDto != null)
            {
                _typeTransactionUcPresenter.SetCategoryValues();
                _typeTransactionUcPresenter.SetStyleDropDownList();
                _view.AddUserControl(_typeTransactionUcPresenter.GetUserControlView());
                _typeTransactionUcPresenter.GetUserControlView().SetCategoryId(TransactionDto.TypeTransactionId);

                _view.AddUserControl(_nameUcPresenter.GetUserControlView());
                _nameUcPresenter.GetUserControlView().SetName(TransactionDto.Name);

                _view.AddUserControl(_descriptionUcPresenter.GetUserControlView());
                _descriptionUcPresenter.GetUserControlView().SetDescription(TransactionDto.Description);

                _view.AddHorizontalLine();
                _view.AddUserControl(_accountsInfoTransactionUcPresenter
                    .GetUserControlView());
                _accountsInfoTransactionUcPresenter.SetDate(TransactionDto.Date);
                _accountsInfoTransactionUcPresenter.SetSum(TransactionDto.Sum);
                _accountsInfoTransactionUcPresenter.SetCreditAccountId(TransactionDto.CreditAccountId);
                _accountsInfoTransactionUcPresenter.SetDebitAccountId(TransactionDto.DebitAccountId);
                _view.AddHorizontalLine();

                _categoriesUcPresenter.SetStyleDropDown();
                _categoriesUcPresenter.SetCategoryValues();
                _view.AddUserControl(_categoriesUcPresenter.GetUserControlView());
                _categoriesUcPresenter.GetUserControlView().SetCategoryId(TransactionDto.CategoryId);

                _contrAgentUcPresenter.SetStyleDropDown();
                _contrAgentUcPresenter.SetCategoryValues();
                _view.AddUserControl(_contrAgentUcPresenter.GetUserControlView());
                _contrAgentUcPresenter.GetUserControlView().SetCategoryId(TransactionDto.ContragentId);

                _identityUcPresenter.SetStyleDropDown();
                _identityUcPresenter.SetCategoryValues();
                _view.AddUserControl(_identityUcPresenter.GetUserControlView());
                _identityUcPresenter.GetUserControlView().SetCategoryId(TransactionDto.IdentityId);
            }
            else
            {
                _typeTransactionUcPresenter.SetCategoryValues();
                _typeTransactionUcPresenter.SetStyleDropDownList();
                _view.AddUserControl(_typeTransactionUcPresenter.GetUserControlView());

                _view.AddUserControl(_nameUcPresenter.GetUserControlView());
                _view.AddUserControl(_descriptionUcPresenter
                    .GetUserControlView());

                _view.AddHorizontalLine();
                _view.AddUserControl(_accountsInfoTransactionUcPresenter
                    .GetUserControlView());
                _view.AddHorizontalLine();

                _categoriesUcPresenter.SetStyleDropDown();
                _categoriesUcPresenter.SetCategoryValues();
                _view.AddUserControl(_categoriesUcPresenter.GetUserControlView());

                _contrAgentUcPresenter.SetStyleDropDown();
                _contrAgentUcPresenter.SetCategoryValues();
                _view.AddUserControl(_contrAgentUcPresenter.GetUserControlView());

                _identityUcPresenter.SetStyleDropDown();
                _identityUcPresenter.SetCategoryValues();
                _view.AddUserControl(_identityUcPresenter.GetUserControlView());
            }

            _view.AddHorizontalLine();
            _view.AddUserControl(_continueCancelButtonsUcPresenter.GetUserControlView());

            _continueCancelButtonsUcPresenter.Continue += ContinueCancelButtonsUcPresenterOnContinue;
        }

        private void ContinueCancelButtonsUcPresenterOnContinue()
        {
            _transactionServices.Add(new TransactionDto
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
            _view.Close();
        }

        #endregion
    }
}