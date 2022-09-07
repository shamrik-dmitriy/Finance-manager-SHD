using System;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.NewViews;
using FM.SHD.Services.CategoriesServices;
using FM.SHD.Services.ComponentsServices.TypeTransactionService;
using FM.SHD.Services.ContragentServices;
using FM.SHD.Services.IdentityServices;
using FM.SHD.Services.SingleTransactionServices;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.NewPresenters
{
    public class SingleTransactionPresenter : BaseSingleTransactionPresenter
    {
        private readonly ISingleTransactionView _view;

        #region Private member variables

        private ISingleTransactionServices _singleTransactionServices;
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

        public SingleTransactionPresenter(
            ISingleTransactionView view,
            ISingleTransactionServices singleTransactionServices,
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
            _singleTransactionServices = singleTransactionServices;

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

        public SingleTransactionDto SingleTransactionDto { get; set; }

        #endregion

        #region Public methods

        public override void SetTitle(string title)
        {
            _view.SetTitle(title);
        }

        public override void Run(SingleTransactionDto accountDto)
        {
            SingleTransactionDto = accountDto;
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

            if (SingleTransactionDto != null)
            {
                _typeTransactionUcPresenter.SetCategoryValues();
                _typeTransactionUcPresenter.SetStyleDropDownList();
                _view.AddUserControl(_typeTransactionUcPresenter.GetUserControlView());
                _typeTransactionUcPresenter.GetUserControlView().SetCategoryId(SingleTransactionDto.TypeTransactionId);

                _view.AddUserControl(_nameUcPresenter.GetUserControlView());
                _nameUcPresenter.GetUserControlView().SetName(SingleTransactionDto.Name);

                _view.AddUserControl(_descriptionUcPresenter.GetUserControlView());
                _descriptionUcPresenter.GetUserControlView().SetDescription(SingleTransactionDto.Description);

                _view.AddHorizontalLine();
                _view.AddUserControl(_accountsInfoTransactionUcPresenter
                    .GetUserControlView());
                _accountsInfoTransactionUcPresenter.SetDate(SingleTransactionDto.Date);
                _accountsInfoTransactionUcPresenter.SetSum(SingleTransactionDto.Sum);
                _accountsInfoTransactionUcPresenter.SetCreditAccountId(SingleTransactionDto.CreditAccountId);
                _accountsInfoTransactionUcPresenter.SetDebitAccountId(SingleTransactionDto.DebitAccountId);
                _view.AddHorizontalLine();

                _categoriesUcPresenter.SetStyleDropDown();
                _categoriesUcPresenter.SetCategoryValues();
                _view.AddUserControl(_categoriesUcPresenter.GetUserControlView());
                _categoriesUcPresenter.GetUserControlView().SetCategoryId(SingleTransactionDto.CategoryId);

                _contrAgentUcPresenter.SetStyleDropDown();
                _contrAgentUcPresenter.SetCategoryValues();
                _view.AddUserControl(_contrAgentUcPresenter.GetUserControlView());
                _contrAgentUcPresenter.GetUserControlView().SetCategoryId(SingleTransactionDto.ContragentId);

                _identityUcPresenter.SetStyleDropDown();
                _identityUcPresenter.SetCategoryValues();
                _view.AddUserControl(_identityUcPresenter.GetUserControlView());
                _identityUcPresenter.GetUserControlView().SetCategoryId(SingleTransactionDto.IdentityId);
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
            _view.Close();
        }

        private void SingleTransactionViewOnAdd(object sender, EventArgs e)
        {
            SingleTransactionDto dto = _view.GetTransactionInfo();
            _singleTransactionServices.Add(dto);
        }

        #endregion
    }
}