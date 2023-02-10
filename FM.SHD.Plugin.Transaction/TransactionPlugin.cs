using System;
using System.Windows.Forms;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters;
using FM.SHD.Plugin.Transaction.WindowsForms.Views;
using FM.SHD.Plugin.Transaction.WindowsForms.Views.Transactions;
using FM.SHD.Plugin.Transaction.WindowsForms.Views.Transactions.TransactionUserControls;
using FM.SHD.Plugin.Transaction.WindowsForms.Views.Transactions.UserControlsOfTransactions;
using FM.SHD.Plugins.Infrastructure;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.AClasses;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Views;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Plugin.Transaction
{
    public class TransactionPlugin : IPlugin
    {
        private readonly IServiceCollection _serviceCollection;
        private string _connectionString;

        public string Name => "Плагин транзакций";
        public string Id => "Transaction";
        public string Description => "Плагин добавляет функциональность для работы с транзакциями";
        public bool IsAddDataToTab => true;
        public bool IsAddDataToMenu => false;

        public TransactionPlugin()
        {
        }

        public void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }

        public TransactionPlugin(IServiceCollection serviceCollection, string connectionString)
        {
            _connectionString = connectionString;
            _serviceCollection = serviceCollection;
            AddTransactions(_serviceCollection);
        }

        private IServiceCollection AddTransactions(IServiceCollection serviceCollection)
        {
            return serviceCollection
                //Views
                .AddTransient<ITransactionBaseView, TransactionBaseView>()
                .AddTransient<ATransactionBasePresenter, TransactionPresenter>()
                //UserControls
                .AddTransient<ITypeTransactionUCView, TypeTransactionUCView>()
                .AddTransient<ITypeTransactionUCPresenter, TypeTransactionUCPresenter>()
                .AddTransient<IAccountsInfoTransactionUCView, AccountsInfoTransactionUCView>()
                .AddTransient<IAccountsInfoTransactionUCPresenter, AccountsInfoTransactionUCPresenter>()
                .AddTransient<IContrAgentUCView, ContrAgentUCView>()
                .AddTransient<IContrAgentUCPresenter, ContrAgentUCPresenter>()
                .AddTransient<IIdentityUCView, IdentityUCView>()
                .AddTransient<IIdentityUCPresenter, IdentityUCPresenter>()
                .AddTransient<IAccountInfoUCView, AccountInfoUCView>()
                .AddTransient<IAccountInfoUCPresenter, AccountInfoUCPresenter>()
                .AddTransient<ISumTransactionUCView, SumTransactionUCView>()
                .AddTransient<ISumTransactionUCPresenter, SumTransactionUCPresenter>()
                .AddTransient<IDateTransactionUCView, DateTransactionUCView>()
                .AddTransient<IDateTransactionUCPresenter, DateTransactionUCPresenter>()
                .AddTransient<IAllTransactionUCView, AllTransactionUCView>()
                .AddTransient<IAllTransactionUCPresenter, AllTransactionUCPresenter>();
        }

        public TabPage GetTab()
        {
            throw new NotImplementedException();
        }

        public ToolStripMenuItem GetMenuItem()
        {
            throw new NotImplementedException();
        }
    }
}