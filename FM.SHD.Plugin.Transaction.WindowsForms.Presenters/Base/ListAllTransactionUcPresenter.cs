using System;
using System.Collections.Generic;
using FM.SHD.Domain;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Infrastructure.Events.ApplicationEvents.Transactions;
using FM.SHD.Presenters.Events.Accounts;
using FM.SHD.Services.AccountServices;
using FM.SHD.Services.TransactionServices;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.AClasses;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Base
{
    public class ListAllTransactionUcPresenter : IListAllTransactionUCPresenter
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IListAllTransactionUCView _view;
        private readonly ATransactionBasePresenter _aTransactionBasePresenter;
        private readonly ITransactionServices _transactionServices;
        private readonly IAccountServices _accountServices;
        private TransactionsDomain _transactionsDomain;

        public ListAllTransactionUcPresenter(
            EventAggregator eventAggregator,
            IListAllTransactionUCView view,
            ATransactionBasePresenter aTransactionBasePresenter,
            ITransactionServices transactionServices, IAccountServices accountServices)
        {
            _eventAggregator = eventAggregator;

            _view = view;
            _aTransactionBasePresenter = aTransactionBasePresenter;
            _transactionServices = transactionServices;
            _accountServices = accountServices;

            _view.UpdateTransaction += ViewOnUpdateTransaction;
            _view.OnLoadUserControl += ViewOnOnLoad;

            _eventAggregator.Subscribe<OnAddedTransactionApplicationEvent>(OnAddedTransaction);
            _eventAggregator.Subscribe<OnUpdateTransactionApplicationEvent>(OnUpdateTransaction);
            _eventAggregator.Subscribe<OnDeleteTransactionApplicationEvent>(OnDeleteTransaction);

            _eventAggregator.Subscribe<OnChangingAccountApplicationEvent>(OnChangingAccount);
            _eventAggregator.Subscribe<OnDeletingAccountApplicationEvent>(OnDeletingAccount);
        }


        ~ListAllTransactionUcPresenter()
        {
            _eventAggregator.Unsubscribe<OnAddedTransactionApplicationEvent>(OnAddedTransaction);
            _eventAggregator.Unsubscribe<OnUpdateTransactionApplicationEvent>(OnUpdateTransaction);
            _eventAggregator.Unsubscribe<OnDeleteTransactionApplicationEvent>(OnDeleteTransaction);

            _eventAggregator.Unsubscribe<OnChangingAccountApplicationEvent>(OnChangingAccount);
            _eventAggregator.Unsubscribe<OnDeletingAccountApplicationEvent>(OnDeletingAccount);
        }


        #region Accounts event processing

        private void OnDeletingAccount(OnDeletingAccountApplicationEvent obj)
        {
            ReloadTransactions();
        }

        private void OnChangingAccount(OnChangingAccountApplicationEvent obj)
        {
            ReloadTransactions();
        }

        #endregion

        #region Transaction Event processing

        private void OnAddedTransaction(OnAddedTransactionApplicationEvent args)
        {
            _transactionsDomain.OnAddedTransaction(args.TransactionDto);
            ReloadTransactions();
            _eventAggregator.Publish<OnReloadAccountsApplicationEvent>();
        }

        private void OnUpdateTransaction(OnUpdateTransactionApplicationEvent args)
        {
            _transactionsDomain.OnUpdateTransaction(args.TransactionDto);
            ReloadTransactions();
            _eventAggregator.Publish<OnReloadAccountsApplicationEvent>();
        }

        private void OnDeleteTransaction(OnDeleteTransactionApplicationEvent args)
        {
            _transactionsDomain.OnDeleteTransaction(args.TransactionDto);
            ReloadTransactions();
            _eventAggregator.Publish<OnReloadAccountsApplicationEvent>();
        }


        private void ViewOnOnLoad()
        {
            _transactionsDomain = new TransactionsDomain(_transactionServices, _accountServices);
            SetTransactions();
        }

        #endregion

        private void SetTransactions()
        {
            _view.SetData(GetAllTransactions());
        }

        private List<TransactionExtendedDto> GetAllTransactions()
        {
            return _transactionServices.GetExtendedTransactions();
        }

        private void ReloadTransactions()
        {
            _view.ClearData();
            SetTransactions();
        }

        private void ViewOnUpdateTransaction(TransactionExtendedDto transactionExtendedDto)
        {
            _aTransactionBasePresenter.Run("Редактирование транзакции",
                _transactionServices.GetById(transactionExtendedDto.Id));
            try
            {
                _view.SetData(_transactionServices.GetExtendedById(transactionExtendedDto.Id));
            }
            catch (ArgumentException)
            {
                // ignored
            }
        }
        
        public IListAllTransactionUCView GetUserControlView()
        {
            return _view;
        }
    }
}