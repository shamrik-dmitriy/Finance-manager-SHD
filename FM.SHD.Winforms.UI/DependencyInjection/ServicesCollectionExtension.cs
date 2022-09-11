using FM.SHD.Infastructure.Impl.Factory;
using FM.SHD.Infastructure.Impl.Repositories;
using FM.SHD.Infastructure.Impl.Repositories.Specific.Account;
using FM.SHD.Infastructure.Impl.Repositories.Specific.Categories;
using FM.SHD.Infastructure.Impl.Repositories.Specific.Contragents;
using FM.SHD.Infastructure.Impl.Repositories.Specific.Currency;
using FM.SHD.Infastructure.Impl.Repositories.Specific.Identities;
using FM.SHD.Infastructure.Impl.Repositories.Specific.Transaction;
using FM.SHD.Infastructure.Impl.Repositories.Specific.TypeTransaction;
using FM.SHD.Infrastructure.Dal.Factory;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.Interfaces.UserControls.Main;
using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.Interfaces.UserControls.Wallet;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Main;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet;
using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHD.Presenters.UserControlPresenters.Common;
using FM.SHD.Presenters.UserControlPresenters.Main;
using FM.SHD.Presenters.UserControlPresenters.Transactions;
using FM.SHD.Presenters.UserControlPresenters.Wallet;
using FM.SHD.Presenters.ViewPresenters;
using FM.SHD.Services.AccountServices;
using FM.SHD.Services.CategoriesServices;
using FM.SHD.Services.CommonServices;
using FM.SHD.Services.ComponentsServices.TypeTransactionService;
using FM.SHD.Services.ContragentServices;
using FM.SHD.Services.CurrencyServices;
using FM.SHD.Services.IdentityServices;
using FM.SHD.Services.Repositories;
using FM.SHD.Services.TransactionServices;
using FM.SHD.Winforms.UI.UserControls.Common;
using FM.SHD.Winforms.UI.UserControls.Main;
using FM.SHD.Winforms.UI.UserControls.Transactions.TransactionUserControls;
using FM.SHD.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions;
using FM.SHD.Winforms.UI.UserControls.Wallet;
using FM.SHD.Winforms.UI.Views.Account;
using FM.SHD.Winforms.UI.Views.Transactions;
using Microsoft.Extensions.DependencyInjection;
using IAccountView = FM.SHD.Presenters.IntrefacesViews.Views.IAccountView;
using IMainView = FM.SHD.Presenters.IntrefacesViews.Views.IMainView;
using MainPresenter = FM.SHD.Presenters.ViewPresenters.MainPresenter;

namespace FM.SHD.Winforms.UI.DependencyInjection
{
    public static class ServicesCollectionExtension
    {
        public static IServiceCollection AddViews(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddScoped<IMainView, MainView>()
                .AddScoped<MainPresenter>()
                .AddTransient<ITransactionView, TransactionView>()
                .AddTransient<TransactionPresenter>()
                .AddTransient<IAccountView, AccountView>()
                .AddTransient<AccountPresenter>();
        }

        public static IServiceCollection AddUserControlViews(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<ITypeTransactionUCView, TypeTransactionUCView>()
                .AddTransient<ITypeTransactionUCPresenter, TypeTransactionUCPresenter>()
                .AddTransient<INameTextboxUCView, NameTextboxUCView>()
                .AddTransient<INameUCPresenter, NameUcPresenter>()
                .AddTransient<IDescriptionTextboxUCView, DescriptionTextboxUCView>()
                .AddTransient<IDescriptionUCPresenter, DescriptionUcPresenter>()
                .AddTransient<IAccountsInfoTransactionUCView, AccountsInfoTransactionUCView>()
                .AddTransient<IAccountsInfoTransactionUCPresenter, AccountsInfoTransactionUCPresenter>()
                .AddTransient<ICategoryUCPresenter<AccountServices>, CategoryUcPresenter<IAccountServices>>()
                .AddTransient<ICategoryUCPresenter<AccountCategoryServices>, CategoryUcPresenter<IAccountCategoryServices>>()
                .AddTransient<ICategoryUCPresenter<TypeTransactionServices>,
                    CategoryUcPresenter<ITypeTransactionServices>>()
                .AddTransient<ICategoryUCPresenter<CategoriesServices>, CategoryUcPresenter<ICategoriesServices>>()
                .AddTransient<ICategoryUCPresenter<ContragentServices>, CategoryUcPresenter<IContragentServices>>()
                .AddTransient<ICategoryUCPresenter<IdentityServices>, CategoryUcPresenter<IIdentityServices>>()
                .AddTransient<ICategoryUCPresenter<CurrencyServices>, CategoryUcPresenter<ICurrencyServices>>()
                .AddTransient<ICategoryUCView, CategoryUCView>()
                .AddTransient<IContrAgentUCView, ContrAgentUCView>()
                .AddTransient<IContrAgentUCPresenter, ContrAgentUCPresenter>()
                .AddTransient<IIdentityUCView, IdentityUCView>()
                .AddTransient<IIdentityUCPresenter, IdentityUCPresenter>()
                .AddTransient<IDataControlButtonsUCView, DataControlButtonsUCView>()
                .AddTransient<IContinueCancelButtonsUCPresenter, DataControlButtonsUcPresenter>()
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
                .AddTransient<BaseAccountPresenter, AccountPresenter>()
                .AddTransient<BaseTransactionPresenter, TransactionPresenter>()
                .AddTransient<IAccountSummaryUCView, AccountSummaryUCView>()
                .AddTransient<IAccountSummaryUCPresenter, AccountSummaryUCPresenter>()
                .AddTransient<IAllTransactionUCView, AllTransactionUCView>()
                .AddTransient<IAllTransactionUCPresenter, AllTransactionUCPresenter>();
        }

        public static IServiceCollection AddRepositories(this IServiceCollection
                serviceCollection)
        {
            return serviceCollection
                .AddScoped<ISqliteConnectionFactory, SqliteConnectionFactory>()
                .AddScoped<IRepositoryManager, RepositoryManager>()
                .AddTransient<ITransactionRepository, TransactionRepository>()
                .AddTransient<IAccountRepository, AccountRepository>()
                .AddTransient<ITypeTransactionRepository, TypeTransactionRepository>()
                .AddTransient<IAccountCategoryRepository, AccountCategoryRepository>()
                .AddTransient<ICategoriesRepository, CategoriesRepository>()
                .AddTransient<IIdentitiesRepository, IdentitiesRepository>()
                .AddTransient<IContragentsRepository, ContragentsRepository>()
                .AddTransient<ICurrencyRepository, CurrencyRepository>();
        }

        public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<ITransactionServices, TransactionServices>()
                .AddTransient<IAccountServices, AccountServices>()
                .AddTransient<ITypeTransactionServices, TypeTransactionServices>()
                .AddTransient<IAccountCategoryServices, AccountCategoryServices>()
                .AddTransient<IBaseCategoryServices, AccountServices>()
                .AddTransient<ICategoriesServices, CategoriesServices>()
                .AddTransient<IIdentityServices, IdentityServices>()
                .AddTransient<IContragentServices, ContragentServices>()
                .AddTransient<ICurrencyServices, CurrencyServices>()
                .AddTransient<IBaseCategoryServices, TypeTransactionServices>();
            //   .AddTransient<CategoryServices<AccountServices>>()
            //   .AddTransient<CategoryServices<TypeTransactionServices>>();
        }
    }
}