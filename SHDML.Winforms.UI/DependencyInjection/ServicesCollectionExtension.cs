using FM.SHD.Infastructure.Impl.Repositories.Specific.Account;
using FM.SHD.Infastructure.Impl.Repositories.Specific.SingleTransaction;
using FM.SHD.Infastructure.Impl.Repositories.Specific.TypeTransaction;
using FM.SHD.Presenters;
using FM.SHD.Presenters.Interfaces;
using FM.SHD.Presenters.Interfaces.UserControls;
using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using FM.SHD.Presenters.UserControlPresenters;
using FM.SHD.Presenters.UserControlPresenters.Transactions;
using FM.SHD.Services.AccountServices;
using FM.SHD.Services.ComponentsServices.TypeTransactionService;
using FM.SHD.Services.Repositories;
using FM.SHD.Services.SingleTransactionServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SHDML.Winforms.UI.Transactions;
using SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls;
using SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions;
using IContrAgentUCPresenter = FM.SHD.Presenters.Interfaces.UserControls.Transactions.IContrAgentUCPresenter;

namespace SHDML.Winforms.UI.DependencyInjection
{
    public static class ServicesCollectionExtension
    {
        public static IServiceCollection AddViews(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddScoped<IMainView, MainView>()
                .AddScoped<MainPresenter>()
                .AddTransient<ISingleTransactionView, SingleTransactionView>()
                .AddTransient<SingleTransactionPresenter>();
        }

        public static IServiceCollection AddUserControlViews(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddScoped<ITypeTransactionUCView, TypeTransactionUCView>()
                .AddScoped<ITypeTransactionUCPresenter, TypeTransactionUCPresenter>()
                .AddScoped<INameTransactionUCView, NameTransactionUCView>()
                .AddScoped<INameTransactionUCPresenter, NameTransactionUcPresenter>()
                .AddScoped<IDescriptionTransactionUCView, DescriptionTransactionUCView>()
                .AddScoped<IDescriptionTransactionUCPresenter, DescriptionTransactionUCPresenter>()
                //Добавить то, что находится внутри IAccountsInfoTransactionUCView
                .AddScoped<IAccountsInfoTransactionUCView, AccountsInfoTransactionUCView>()
                .AddScoped<IAccountsInfoTransactionUCPresenter, AccountsInfoTransactionUCPresenter>()
                .AddScoped<ICategoryTransactionUCView, CategoryTransactionUCView>()
                .AddScoped<ICategoryTransactionUCPresenter, CategoryTransactionUCPresenter>()
                .AddScoped<IContrAgentUCView, ContrAgentUCView>()
                .AddScoped<IContrAgentUCPresenter, ContrAgentUCPresenter>()
                .AddScoped<IFamilyMemberUCView, FamilyMemberUCView>()
                .AddScoped<IFamilyMemberUCPresenter, FamilyMemberUCPresenter>()
                .AddScoped<IAddCancelButtonsUCView, AddCancelButtonsUCView>()
                .AddScoped<IAddCancelButtonsUCPresenter, AddCancelButtonsUCPresenter>();
        }

        public static IServiceCollection AddRepositories(this IServiceCollection serviceCollection,
            IConfigurationRoot config)
        {
            return serviceCollection
                .AddTransient<ISingleTransactionRepository, SingleTransactionRepository>(provider =>
                    new SingleTransactionRepository(
                        config.GetConnectionString("DefaultConnection")))
                .AddTransient<IAccountRepository, AccountRepository>(provider =>
                    new AccountRepository(
                        config.GetConnectionString("DefaultConnection")))
                .AddTransient<ITypeTransactionRepository, TypeTransactionRepository>(provider =>
                    new TypeTransactionRepository(
                        config.GetConnectionString("DefaultConnection")));
        }

        public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<ISingleTransactionServices, SingleTransactionServices>()
                .AddTransient<IAccountServices, AccountServices>()
                .AddTransient<ITypeTransactionServices, TypeTransactionServices>();
        }
    }
}