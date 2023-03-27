using System;
using System.Windows.Forms;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Additional;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Additional.UserControls;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Base;
using FM.SHD.Plugin.Transaction.WindowsForms.UserControls;
using FM.SHD.Plugin.Transaction.WindowsForms.UserControls.ComponentsOfAdditionalView;
using FM.SHD.Plugin.Transaction.WindowsForms.UserControls.ComponentsOfMainView;
using FM.SHD.Plugin.Transaction.WindowsForms.Views;
using FM.SHD.Plugins.Interfaces;
using FM.SHD.UI.WindowsForms.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.AClasses;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Views;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Button;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.TabPage;
using FM.SHD.UI.WindowsForms.UserControls.Views.Additional;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Plugin.Transaction
{
    public class TransactionPlugin : ITransactionPlugin
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IServiceCollection _serviceCollection;
        private string _connectionString;

        public string Name => "Плагин транзакций";
        public string Id => "Transaction";
        public string TabText => "Транзакции";
        public string Description => "Плагин добавляет функциональность для работы с транзакциями";
        public bool IsAddDataToTab => true;
        public bool IsAddDataToMenu => false;

        public TransactionPlugin(IServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        public TransactionPlugin(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }

        public TransactionPlugin(string connectionString)
        {
            _connectionString = connectionString;
        }

        public TabPage GetTab()
        {
            var tabPageUCPresenter = _serviceProvider.GetRequiredService<ITabPageUCPresenter>();

            tabPageUCPresenter.GetUserControlView().AddUserControlToButtonBlock((UserControl)_serviceProvider
                .GetRequiredService<ITransactionManagementUCPresenter>()
                .GetUserControlView());

            tabPageUCPresenter.GetUserControlView().AddUserControlToWorkspaceBlock((UserControl)_serviceProvider
                .GetRequiredService<IListAllTransactionUCPresenter>()
                .GetUserControlView());

            //tabPageUCPresenter.GetUserControlView().AddUserControlToButtonBlock(new ContinueCancelButtonsUcView());
            // tabPageUCPresenter.GetUserControlView().AddUserControlToButtonBlock(new NameTextboxUCView(){Text = "Net"});
            // Конструируем вкладку
            var tabPage = new TabPage()
            {
                Text = TabText,
                Dock = DockStyle.Fill,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };
            tabPage.Controls.Add((UserControl)tabPageUCPresenter.GetUserControlView());
            return tabPage;
        }

        private void UcOnOnLoad()
        {
            throw new NotImplementedException();
        }

        public ToolStripMenuItem GetMenuItem()
        {
            throw new NotImplementedException();
        }

        public IServiceCollection AddPluginServices()
        {
            return _serviceCollection
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
                .AddTransient<IListAllTransactionUCView, ListAllTransactionUcView>()
                .AddTransient<IListAllTransactionUCPresenter, ListAllTransactionUcPresenter>()
                .AddTransient<ITransactionManagementUCView, TransactionManagementUCView>()
                .AddTransient<ITransactionManagementUCPresenter, TransactionManagementUCPresenter>();
        }

        public IBasePresenter<ITransactionBaseView> GetPluginPresenter()
        {
            throw new NotImplementedException();
        }

        public ATransactionBasePresenter GetPluginPresenter(string pluginPresenterName)
        {
            return _serviceProvider.GetRequiredService<ATransactionBasePresenter>();
        }
    }
}