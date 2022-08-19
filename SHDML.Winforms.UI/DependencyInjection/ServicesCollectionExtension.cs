using System.Collections.Generic;
using System.Linq;
using FM.SHD.Infastructure.Impl.Repositories.Specific.Account;
using FM.SHD.Infastructure.Impl.Repositories.Specific.SingleTransaction;
using FM.SHD.Infastructure.Impl.Repositories.Specific.TypeTransaction;
using FM.SHD.Presenters;
using FM.SHD.Presenters.Interfaces;
using FM.SHD.Presenters.Interfaces.UserControls;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.Interfaces.UserControls.Wallet;
using FM.SHD.Presenters.Interfaces.Views;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet;
using FM.SHD.Presenters.UserControlPresenters;
using FM.SHD.Presenters.UserControlPresenters.Common;
using FM.SHD.Presenters.UserControlPresenters.Transactions;
using FM.SHD.Presenters.UserControlPresenters.Wallet;
using FM.SHD.Presenters.ViewPresenters;
using FM.SHD.Services.AccountServices;
using FM.SHD.Services.CommonServices;
using FM.SHD.Services.ComponentsServices.TypeTransactionService;
using FM.SHD.Services.Repositories;
using FM.SHD.Services.SingleTransactionServices;
using FM.SHDML.Core.Models.Dtos;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SHDML.Winforms.UI.Account;
using SHDML.Winforms.UI.Transactions;
using SHDML.Winforms.UI.UserControls.Common;
using SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls;
using SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions;
using SHDML.Winforms.UI.UserControls.Wallet;
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
                .AddTransient<SingleTransactionPresenter>()
                .AddTransient<IAccountView, AccountView>()
                .AddTransient<AccountPresenter>();
        }

        public static IServiceCollection AddUserControlViews(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddScoped<ITypeTransactionUCView, TypeTransactionUCView>()
                .AddScoped<ITypeTransactionUCPresenter, TypeTransactionUCPresenter>()
                .AddTransient<INameTextboxUCView, NameTextboxUCView>()
                .AddTransient<INameUCPresenter, NameUcPresenter>()
                .AddTransient<IDescriptionTextboxUCView, DescriptionTextboxUCView>()
                .AddTransient<IDescriptionUCPresenter, DescriptionUcPresenter>()
                .AddScoped<IAccountsInfoTransactionUCView, AccountsInfoTransactionUCView>()
                .AddScoped<IAccountsInfoTransactionUCPresenter, AccountsInfoTransactionUCPresenter>()
                .AddTransient<ICategoryUCPresenter<AccountServices>, CategoryUcPresenter<IAccountServices>>()
                .AddTransient<ICategoryUCPresenter<TypeTransactionServices>, CategoryUcPresenter<ITypeTransactionServices>>()
                .AddTransient<ICategoryUCView, CategoryUCView>()
                .AddTransient<IContrAgentUCView, ContrAgentUCView>()
                .AddTransient<IContrAgentUCPresenter, ContrAgentUCPresenter>()
                .AddTransient<IIdentityUCView, IdentityUCView>()
                .AddTransient<IIdentityUCPresenter, IdentityUCPresenter>()
                .AddTransient<IAddCancelButtonsUCView, AddCancelButtonsUCView>()
                .AddTransient<IAddCancelButtonsUCPresenter, AddCancelButtonsUCPresenter>()
                .AddTransient<IAccountInfoUCView, AccountInfoUCView>()
                .AddTransient<IAccountInfoUCPresenter, AccountInfoUCPresenter>()
                .AddTransient<ISumTransactionUCView, SumTransactionUCView>()
                .AddTransient<ISumTransactionUCPresenter, SumTransactionUCPresenter>()
                .AddTransient<IDateTransactionUCView, DateTransactionUCView>()
                .AddTransient<IDateTransactionUCPresenter, DateTransactionUCPresenter>()
                .AddTransient<ILabelTextBoxUCView, LabelTextBoxUCView>()
                .AddTransient<ILabelTextboxUcPresenter, LabelTextboxPresenter>()
                .AddTransient<ICheckboxUCView, CheckboxUCView>()
                .AddTransient<ICheckboxUCPresenter, CheckboxUCPresenter>()
                .AddTransient<IAccountView, AccountView>()
                .AddTransient<IAccountPresenter, AccountPresenter>()
                .AddTransient<IAccountSummaryUCView, AccountSummaryUCView>()
                .AddTransient<IAccountSummaryUCPresenter, AccountSummaryUCPresenter>();
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
                        config.GetConnectionString("DefaultConnection")))
                .AddTransient<IAccountCategoryRepository, AccountCategoryRepository>(provider =>
                    new AccountCategoryRepository(
                        config.GetConnectionString("DefaultConnection")));
        }

        public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<ISingleTransactionServices, SingleTransactionServices>()
                .AddTransient<IAccountServices, AccountServices>()
                .AddTransient<ITypeTransactionServices, TypeTransactionServices>()
                .AddTransient<IAccountCategoryServices, AccountCategoryServices>()
                .AddTransient<ICategoryServices, AccountServices>()
                .AddTransient<ICategoryServices, TypeTransactionServices>();
            //   .AddTransient<CategoryServices<AccountServices>>()
            //   .AddTransient<CategoryServices<TypeTransactionServices>>();
        }
    }
}