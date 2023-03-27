using System;
using FM.SHD.Plugins.Interfaces;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Base
{
    public class TransactionManagementUCPresenter : ITransactionManagementUCPresenter
    {
        private readonly IPluginManager _pluginManager;
        private readonly ITransactionManagementUCView _transactionManagementUCView;

        public TransactionManagementUCPresenter(IPluginManager pluginManager,
            ITransactionManagementUCView transactionManagementUCView)
        {
            _pluginManager = pluginManager;
            _transactionManagementUCView = transactionManagementUCView;

            _transactionManagementUCView.AddTransaction += OnAddingTransaction;
            _transactionManagementUCView.Search += OnSearch;
            _transactionManagementUCView.AddReceipt += OnAddingReceipt;
        }

        public ITransactionManagementUCView GetUserControlView()
        {
            return _transactionManagementUCView;
        }

        private void OnAddingTransaction()
        {
            var transactionPresenter = _pluginManager.GetPlugin<ITransactionPlugin>();
            transactionPresenter.GetPluginPresenter("TransactionPresenter").Run("Добавить транзакцию");
        }
        
        private void OnAddingReceipt()
        {
            throw new InvalidOperationException("Функциональность не реализована");
        }
        
        private void OnSearch()
        {
            throw new InvalidOperationException("Функциональность не реализована");
        }
    }
}