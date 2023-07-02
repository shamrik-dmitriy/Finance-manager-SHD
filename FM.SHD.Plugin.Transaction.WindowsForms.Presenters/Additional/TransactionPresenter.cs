using FM.SHD.Domain;
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
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Category.ComboboxCategory;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Category.ToolStripDropDownButtonCategory;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.ContinueCancelButtons;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Description;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Name;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Additional
{
    public class TransactionPresenter : ATransactionBasePresenter
    {
        private readonly EventAggregator _eventAggregator;
        private readonly ITransactionManagementView _managementView;

        #region Private member variables

        private readonly ICategoryComboboxUCPresenter<TypeTransactionServices> _typeTransactionComboboxUCPresenter;
        private readonly INameUCPresenter _nameUcPresenter;
        private readonly IDescriptionUCPresenter _descriptionUcPresenter;
        private readonly IAccountsInfoTransactionUCPresenter _accountsInfoTransactionUcPresenter;
        private readonly ICategoryToolStripUCPresenter<CategoriesServices> _categoriesToolStripUCPresenter;
        private readonly ICategoryComboboxUCPresenter<ContragentServices> _contrAgentComboboxUCPresenter;
        private readonly ICategoryComboboxUCPresenter<IdentityServices> _identityComboboxUCPresenter;
        private readonly IContinueCancelButtonsUCPresenter _continueCancelButtonUcPresenter;

        #endregion

        #region Constructor / Destructor

        public TransactionPresenter(
            EventAggregator eventAggregator,
            ITransactionManagementView managementView,
            ICategoryComboboxUCPresenter<TypeTransactionServices> typeTransactionComboboxUCPresenter,
            INameUCPresenter nameUcPresenter,
            IDescriptionUCPresenter descriptionUcPresenter,
            IAccountsInfoTransactionUCPresenter accountsInfoTransactionUcPresenter,
            ICategoryToolStripUCPresenter<CategoriesServices> categoriesToolStripUCPresenter,
            ICategoryComboboxUCPresenter<ContragentServices> contrAgentComboboxUCPresenter,
            ICategoryComboboxUCPresenter<IdentityServices> identityComboboxUCPresenter,
            IContinueCancelButtonsUCPresenter continueCancelButtonUcPresenter)
            : base(managementView)
        {
            _eventAggregator = eventAggregator;
            _managementView = managementView;

            _typeTransactionComboboxUCPresenter = typeTransactionComboboxUCPresenter;
            _nameUcPresenter = nameUcPresenter;
            _descriptionUcPresenter = descriptionUcPresenter;
            _accountsInfoTransactionUcPresenter = accountsInfoTransactionUcPresenter;
            _categoriesToolStripUCPresenter = categoriesToolStripUCPresenter;
            _contrAgentComboboxUCPresenter = contrAgentComboboxUCPresenter;
            _identityComboboxUCPresenter = identityComboboxUCPresenter;
            _continueCancelButtonUcPresenter = continueCancelButtonUcPresenter;

            _managementView.OnLoadView += OnLoadManagementView;
            _typeTransactionComboboxUCPresenter.CategoryChanged += TypeTransactionComboboxUCPresenterOnCategoryChanged;
        }

        ~TransactionPresenter()
        {
            _managementView.OnLoadView -= OnLoadManagementView;
        }

        #endregion

        #region Public Properties

        public TransactionDto TransactionDto { get; set; }

        #endregion

        #region Public methods
        
        public override void Run(TransactionDto categoryDto)
        {
            TransactionDto = categoryDto;
            _managementView.Show();
        }

        public override void Run(string title, TransactionDto transactionDto = default)
        {
            TransactionDto = transactionDto;
            _managementView.SetTitle(title);
            _managementView.Show();
        }

        #endregion

        #region Private methods

        private void TypeTransactionComboboxUCPresenterOnCategoryChanged(long id)
        {
            _accountsInfoTransactionUcPresenter.CategoryChanged(id);
        }

        private void OnLoadManagementView()
        {
            _typeTransactionComboboxUCPresenter.SetText("Тип транзакции");
            _categoriesToolStripUCPresenter.SetText("Категория");
            _contrAgentComboboxUCPresenter.SetText("Контрагент");
            _identityComboboxUCPresenter.SetText("Член семьи");
            _managementView.Clear();

            if (TransactionDto != null)
            {
                _typeTransactionComboboxUCPresenter.SetCategoryValues();
                _typeTransactionComboboxUCPresenter.SetStyleDropDownList();
                _managementView.AddUserControl(_typeTransactionComboboxUCPresenter.GetUserControlView());
                _typeTransactionComboboxUCPresenter.GetUserControlView().SetCategoryId(TransactionDto.TypeTransactionId);

                _managementView.AddUserControl(_nameUcPresenter.GetUserControlView());
                _nameUcPresenter.GetUserControlView().SetName(TransactionDto.Name);

                _managementView.AddUserControl(_descriptionUcPresenter.GetUserControlView());
                _descriptionUcPresenter.GetUserControlView().SetDescription(TransactionDto.Description);

                _managementView.AddHorizontalLine();
                _managementView.AddUserControl(_accountsInfoTransactionUcPresenter
                    .GetUserControlView());
                _accountsInfoTransactionUcPresenter.SetDate(TransactionDto.Date);
                _accountsInfoTransactionUcPresenter.SetSum(TransactionDto.Sum);
                _accountsInfoTransactionUcPresenter.SetCreditAccountId(TransactionDto.CreditAccountId);
                _accountsInfoTransactionUcPresenter.SetDebitAccountId(TransactionDto.DebitAccountId);
                _managementView.AddHorizontalLine();

                _categoriesToolStripUCPresenter.SetCategoryValues();
                _managementView.AddUserControl(_categoriesToolStripUCPresenter.GetUserControlView());
                _categoriesToolStripUCPresenter.GetUserControlView().SetCategoryId(TransactionDto.CategoryId);

                _contrAgentComboboxUCPresenter.SetStyleDropDown();
                _contrAgentComboboxUCPresenter.SetCategoryValues();
                _managementView.AddUserControl(_contrAgentComboboxUCPresenter.GetUserControlView());
                _contrAgentComboboxUCPresenter.GetUserControlView().SetCategoryId(TransactionDto.ContragentId);

                _identityComboboxUCPresenter.SetStyleDropDown();
                _identityComboboxUCPresenter.SetCategoryValues();
                _managementView.AddUserControl(_identityComboboxUCPresenter.GetUserControlView());
                _identityComboboxUCPresenter.GetUserControlView().SetCategoryId(TransactionDto.IdentityId);

                _managementView.AddHorizontalLine();
                _continueCancelButtonUcPresenter.SetTextButtonContinue("Применить");
                _continueCancelButtonUcPresenter.SetVisibleButtonDelete(true);
                _managementView.AddUserControl(_continueCancelButtonUcPresenter.GetUserControlView());
            }
            else
            {
                _typeTransactionComboboxUCPresenter.SetCategoryValues();
                _typeTransactionComboboxUCPresenter.SetStyleDropDownList();
                _managementView.AddUserControl(_typeTransactionComboboxUCPresenter.GetUserControlView());

                _managementView.AddUserControl(_nameUcPresenter.GetUserControlView());
                _managementView.AddUserControl(_descriptionUcPresenter
                    .GetUserControlView());

                _managementView.AddHorizontalLine();
                _managementView.AddUserControl(_accountsInfoTransactionUcPresenter
                    .GetUserControlView());
                _managementView.AddHorizontalLine();

                _categoriesToolStripUCPresenter.SetCategoryValues();
                _managementView.AddUserControl(_categoriesToolStripUCPresenter.GetUserControlView());

                _contrAgentComboboxUCPresenter.SetStyleDropDown();
                _contrAgentComboboxUCPresenter.SetCategoryValues();
                _managementView.AddUserControl(_contrAgentComboboxUCPresenter.GetUserControlView());

                _identityComboboxUCPresenter.SetStyleDropDown();
                _identityComboboxUCPresenter.SetCategoryValues();
                _managementView.AddUserControl(_identityComboboxUCPresenter.GetUserControlView());

                _managementView.AddHorizontalLine();
                _continueCancelButtonUcPresenter.SetVisibleButtonDelete(false);
                _managementView.AddUserControl(_continueCancelButtonUcPresenter.GetUserControlView());
            }

            _continueCancelButtonUcPresenter.Continue += ContinueCancelButtonUcPresenterOnContinue;
            _continueCancelButtonUcPresenter.Delete += DataControlsButtonsUcPresenterOnDelete;
        }

        private void DataControlsButtonsUcPresenterOnDelete()
        {
            if (_managementView.ShowMessageDelete("Удаление транзакции",
                    $"Транзакция \"{TransactionDto.Name}\" будет удалена, продолжить?"))
            {
                _eventAggregator.Publish(new OnDeleteTransactionApplicationEvent(TransactionDto));

                _continueCancelButtonUcPresenter.Continue -= ContinueCancelButtonUcPresenterOnContinue;
                _continueCancelButtonUcPresenter.Delete -= DataControlsButtonsUcPresenterOnDelete;
                _managementView.Close();
            }
        }

        private void ContinueCancelButtonUcPresenterOnContinue()
        {
            if (TransactionDto != null)
            {
                TransactionDto.TypeTransactionId = _typeTransactionComboboxUCPresenter.GetCategoryId();
                TransactionDto.Name = _nameUcPresenter.GetName();
                TransactionDto.Description = _descriptionUcPresenter.GetDescription();

                switch ((TransactionType)TransactionDto.TypeTransactionId)
                {
                    case TransactionType.Expense:
                    {
                        TransactionDto.DebitAccountId = _accountsInfoTransactionUcPresenter.GetDebitAccountId();
                        TransactionDto.CreditAccountId = null;
                        break;
                    }
                    case TransactionType.Income:
                    {
                        TransactionDto.DebitAccountId = null;
                        TransactionDto.CreditAccountId = _accountsInfoTransactionUcPresenter.GetCreditAccountId();
                        break;
                    }
                    case TransactionType.Transfer:
                    {
                        TransactionDto.DebitAccountId = _accountsInfoTransactionUcPresenter.GetDebitAccountId();
                        TransactionDto.CreditAccountId = _accountsInfoTransactionUcPresenter.GetCreditAccountId();
                        break;
                    }
                }

                TransactionDto.Sum = _accountsInfoTransactionUcPresenter.GetSum();
                TransactionDto.Date = _accountsInfoTransactionUcPresenter.GetDate();
                TransactionDto.CategoryId = _categoriesToolStripUCPresenter.GetCategoryId();
                TransactionDto.ContragentId = _contrAgentComboboxUCPresenter.GetCategoryId();
                TransactionDto.IdentityId = _identityComboboxUCPresenter.GetCategoryId();

                _eventAggregator.Publish(new OnUpdateTransactionApplicationEvent(TransactionDto));
            }
            else
            {
                var transactionDto = new TransactionDto();
                var typeTransaction = _typeTransactionComboboxUCPresenter.GetCategoryId();
                switch (typeTransaction)
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

                transactionDto.TypeTransactionId = typeTransaction;
                transactionDto.Name = _nameUcPresenter.GetName();
                transactionDto.Description = _descriptionUcPresenter.GetDescription();
                transactionDto.Sum = _accountsInfoTransactionUcPresenter.GetSum();
                transactionDto.Date = _accountsInfoTransactionUcPresenter.GetDate();
                transactionDto.CategoryId = _categoriesToolStripUCPresenter.GetCategoryId();
                transactionDto.ContragentId = _contrAgentComboboxUCPresenter.GetCategoryId();
                transactionDto.IdentityId = _identityComboboxUCPresenter.GetCategoryId();

                _eventAggregator.Publish(new OnAddedTransactionApplicationEvent(transactionDto));
            }

            _continueCancelButtonUcPresenter.Continue -= ContinueCancelButtonUcPresenterOnContinue;
            _continueCancelButtonUcPresenter.Delete -= DataControlsButtonsUcPresenterOnDelete;

            _managementView.Close();
        }

        #endregion
    }
}