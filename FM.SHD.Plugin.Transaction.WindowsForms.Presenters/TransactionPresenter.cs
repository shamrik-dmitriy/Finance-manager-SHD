using FM.SHD.Infrastructure.Events;
using FM.SHD.Infrastructure.Events.ApplicationEvents.Transactions;
using FM.SHD.Services.CategoriesServices;
using FM.SHD.Services.ComponentsServices.TypeTransactionService;
using FM.SHD.Services.ContragentServices;
using FM.SHD.Services.IdentityServices;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.AClasses;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Views;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Category;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.ContinueCancelButtons;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Description;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Name;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters
{
    public class TransactionPresenter : ATransactionBasePresenter
    {
        private readonly EventAggregator _eventAggregator;
        private readonly ITransactionBaseView _baseView;

        #region Private member variables

        private readonly ICategoryUCPresenter<TypeTransactionServices> _typeTransactionUcPresenter;
        private readonly INameUCPresenter _nameUcPresenter;
        private readonly IDescriptionUCPresenter _descriptionUcPresenter;
        private readonly IAccountsInfoTransactionUCPresenter _accountsInfoTransactionUcPresenter;
        private readonly ICategoryUCPresenter<CategoriesServices> _categoriesUcPresenter;
        private readonly ICategoryUCPresenter<ContragentServices> _contrAgentUcPresenter;
        private readonly ICategoryUCPresenter<IdentityServices> _identityUcPresenter;
        private readonly IContinueCancelButtonsUCPresenter _dataControlButtonsUcPresenter;

        #endregion

        #region Constructor / Destructor

        public TransactionPresenter(
            EventAggregator eventAggregator,
            ITransactionBaseView baseView,
            ICategoryUCPresenter<TypeTransactionServices> typeTransactionUcPresenter,
            INameUCPresenter nameUcPresenter,
            IDescriptionUCPresenter descriptionUcPresenter,
            IAccountsInfoTransactionUCPresenter accountsInfoTransactionUcPresenter,
            ICategoryUCPresenter<CategoriesServices> categoriesUcPresenter,
            ICategoryUCPresenter<ContragentServices> contrAgentUcPresenter,
            ICategoryUCPresenter<IdentityServices> identityUcPresenter,
            IContinueCancelButtonsUCPresenter dataControlButtonsUcPresenter)
            : base(baseView)
        {
            _eventAggregator = eventAggregator;
            _baseView = baseView;

            _typeTransactionUcPresenter = typeTransactionUcPresenter;
            _nameUcPresenter = nameUcPresenter;
            _descriptionUcPresenter = descriptionUcPresenter;
            _accountsInfoTransactionUcPresenter = accountsInfoTransactionUcPresenter;
            _categoriesUcPresenter = categoriesUcPresenter;
            _contrAgentUcPresenter = contrAgentUcPresenter;
            _identityUcPresenter = identityUcPresenter;
            _dataControlButtonsUcPresenter = dataControlButtonsUcPresenter;

            _baseView.OnLoadView += OnLoadBaseView;
            _typeTransactionUcPresenter.CategoryChanged += TypeTransactionUcPresenterOnCategoryChanged;
        }

        ~TransactionPresenter()
        {
            _baseView.OnLoadView -= OnLoadBaseView;
        }

        #endregion

        #region Public Properties

        public TransactionDto TransactionDto { get; set; }

        #endregion

        #region Public methods

        public override void SetTitle(string title)
        {
            _baseView.SetTitle(title);
        }

        public override void Run(TransactionDto accountDto)
        {
            TransactionDto = accountDto;
            _baseView.Show();
        }

        #endregion

        #region Private methods

        private void TypeTransactionUcPresenterOnCategoryChanged(long id)
        {
            _accountsInfoTransactionUcPresenter.CategoryChanged(id);
        }

        private void OnLoadBaseView()
        {
            _typeTransactionUcPresenter.SetText("Тип транзакции");
            _categoriesUcPresenter.SetText("Категория");
            _contrAgentUcPresenter.SetText("Контрагент");
            _identityUcPresenter.SetText("Член семьи");
            _baseView.Clear();

            if (TransactionDto != null)
            {
                _typeTransactionUcPresenter.SetCategoryValues();
                _typeTransactionUcPresenter.SetStyleDropDownList();
                _baseView.AddUserControl(_typeTransactionUcPresenter.GetUserControlView());
                _typeTransactionUcPresenter.GetUserControlView().SetCategoryId(TransactionDto.TypeTransactionId);

                _baseView.AddUserControl(_nameUcPresenter.GetUserControlView());
                _nameUcPresenter.GetUserControlView().SetName(TransactionDto.Name);

                _baseView.AddUserControl(_descriptionUcPresenter.GetUserControlView());
                _descriptionUcPresenter.GetUserControlView().SetDescription(TransactionDto.Description);

                _baseView.AddHorizontalLine();
                _baseView.AddUserControl(_accountsInfoTransactionUcPresenter
                    .GetUserControlView());
                _accountsInfoTransactionUcPresenter.SetDate(TransactionDto.Date);
                _accountsInfoTransactionUcPresenter.SetSum(TransactionDto.Sum);
                _accountsInfoTransactionUcPresenter.SetCreditAccountId(TransactionDto.CreditAccountId);
                _accountsInfoTransactionUcPresenter.SetDebitAccountId(TransactionDto.DebitAccountId);
                _baseView.AddHorizontalLine();

                _categoriesUcPresenter.SetStyleDropDown();
                _categoriesUcPresenter.SetCategoryValues();
                _baseView.AddUserControl(_categoriesUcPresenter.GetUserControlView());
                _categoriesUcPresenter.GetUserControlView().SetCategoryId(TransactionDto.CategoryId);

                _contrAgentUcPresenter.SetStyleDropDown();
                _contrAgentUcPresenter.SetCategoryValues();
                _baseView.AddUserControl(_contrAgentUcPresenter.GetUserControlView());
                _contrAgentUcPresenter.GetUserControlView().SetCategoryId(TransactionDto.ContragentId);

                _identityUcPresenter.SetStyleDropDown();
                _identityUcPresenter.SetCategoryValues();
                _baseView.AddUserControl(_identityUcPresenter.GetUserControlView());
                _identityUcPresenter.GetUserControlView().SetCategoryId(TransactionDto.IdentityId);

                _baseView.AddHorizontalLine();
                _dataControlButtonsUcPresenter.SetTextButtonContinue("Применить");
                _dataControlButtonsUcPresenter.SetVisibleButtonDelete(true);
                _baseView.AddUserControl(_dataControlButtonsUcPresenter.GetUserControlView());
            }
            else
            {
                _typeTransactionUcPresenter.SetCategoryValues();
                _typeTransactionUcPresenter.SetStyleDropDownList();
                _baseView.AddUserControl(_typeTransactionUcPresenter.GetUserControlView());

                _baseView.AddUserControl(_nameUcPresenter.GetUserControlView());
                _baseView.AddUserControl(_descriptionUcPresenter
                    .GetUserControlView());

                _baseView.AddHorizontalLine();
                _baseView.AddUserControl(_accountsInfoTransactionUcPresenter
                    .GetUserControlView());
                _baseView.AddHorizontalLine();

                _categoriesUcPresenter.SetStyleDropDown();
                _categoriesUcPresenter.SetCategoryValues();
                _baseView.AddUserControl(_categoriesUcPresenter.GetUserControlView());

                _contrAgentUcPresenter.SetStyleDropDown();
                _contrAgentUcPresenter.SetCategoryValues();
                _baseView.AddUserControl(_contrAgentUcPresenter.GetUserControlView());

                _identityUcPresenter.SetStyleDropDown();
                _identityUcPresenter.SetCategoryValues();
                _baseView.AddUserControl(_identityUcPresenter.GetUserControlView());

                _baseView.AddHorizontalLine();
                _dataControlButtonsUcPresenter.SetVisibleButtonDelete(false);
                _baseView.AddUserControl(_dataControlButtonsUcPresenter.GetUserControlView());
            }

            _dataControlButtonsUcPresenter.Continue += DataControlButtonsUcPresenterOnContinue;
            _dataControlButtonsUcPresenter.Delete += DataControlsButtonsUcPresenterOnDelete;
        }

        private void DataControlsButtonsUcPresenterOnDelete()
        {
            if (_baseView.ShowMessageDelete("Удаление транзакции",
                    $"Транзакция \"{TransactionDto.Name}\" будет удалена, продолжить?"))
            {
                _eventAggregator.Publish(new OnDeleteTransactionApplicationEvent(TransactionDto));
                
                _dataControlButtonsUcPresenter.Continue -= DataControlButtonsUcPresenterOnContinue;
                _dataControlButtonsUcPresenter.Delete -= DataControlsButtonsUcPresenterOnDelete;
                _baseView.Close();
            }
        }

        private void DataControlButtonsUcPresenterOnContinue()
        {
            if (TransactionDto != null)
            {
                
                TransactionDto.TypeTransactionId = _typeTransactionUcPresenter.GetCategoryId();
                TransactionDto.Name = _nameUcPresenter.GetName();
                TransactionDto.Description = _descriptionUcPresenter.GetDescription();

                switch (TransactionDto.TypeTransactionId)
                {
                    case 1:
                    {
                        TransactionDto.DebitAccountId = _accountsInfoTransactionUcPresenter.GetDebitAccountId();
                        TransactionDto.CreditAccountId = null;
                        break;
                    }
                    case 2:
                    {
                        TransactionDto.DebitAccountId = null;
                        TransactionDto.CreditAccountId = _accountsInfoTransactionUcPresenter.GetCreditAccountId();
                        break;
                    }
                    case 3:
                    {
                        TransactionDto.DebitAccountId = _accountsInfoTransactionUcPresenter.GetDebitAccountId();
                        TransactionDto.CreditAccountId = _accountsInfoTransactionUcPresenter.GetCreditAccountId();
                        break;
                    }
                }

                TransactionDto.Sum = _accountsInfoTransactionUcPresenter.GetSum();
                TransactionDto.Date = _accountsInfoTransactionUcPresenter.GetDate();
                TransactionDto.CategoryId = _categoriesUcPresenter.GetCategoryId();
                TransactionDto.ContragentId = _contrAgentUcPresenter.GetCategoryId();
                TransactionDto.IdentityId = _identityUcPresenter.GetCategoryId();
                
                _eventAggregator.Publish(new OnUpdateTransactionApplicationEvent(TransactionDto));

            }
            else
            {
                var transactionDto = new TransactionDto();
                switch (_typeTransactionUcPresenter.GetCategoryId())
                {
                    case 1:
                    {
                        // Расход
                        transactionDto.DebitAccountId = _accountsInfoTransactionUcPresenter.GetDebitAccountId();
                        transactionDto.CreditAccountId = null;
                        break;
                    }
                    case 2:
                    {
                        // Доход
                        transactionDto.DebitAccountId = null;
                        transactionDto.CreditAccountId = _accountsInfoTransactionUcPresenter.GetCreditAccountId();
                        break;
                    }
                    case 3:
                    {
                        // Перевод
                        transactionDto.DebitAccountId = _accountsInfoTransactionUcPresenter.GetDebitAccountId();
                        transactionDto.CreditAccountId = _accountsInfoTransactionUcPresenter.GetCreditAccountId();
                        break;
                    }
                }

                transactionDto.TypeTransactionId = _typeTransactionUcPresenter.GetCategoryId();
                transactionDto.Name = _nameUcPresenter.GetName();
                transactionDto.Description = _descriptionUcPresenter.GetDescription();
                transactionDto.Sum = _accountsInfoTransactionUcPresenter.GetSum();
                transactionDto.Date = _accountsInfoTransactionUcPresenter.GetDate();
                transactionDto.CategoryId = _categoriesUcPresenter.GetCategoryId();
                transactionDto.ContragentId = _contrAgentUcPresenter.GetCategoryId();
                transactionDto.IdentityId = _identityUcPresenter.GetCategoryId();

                _eventAggregator.Publish(new OnAddedTransactionApplicationEvent(transactionDto));
            }

            _dataControlButtonsUcPresenter.Continue -= DataControlButtonsUcPresenterOnContinue;
            _dataControlButtonsUcPresenter.Delete -= DataControlsButtonsUcPresenterOnDelete;

            _baseView.Close();
        }

        #endregion
    }
}