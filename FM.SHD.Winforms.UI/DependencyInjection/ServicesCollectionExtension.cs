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
using FM.SHD.Presenters.Interfaces.UserControls.Wallet;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet;
using FM.SHD.Presenters.IntrefacesViews.Views;
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
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.AClasses;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Views;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Category;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Checkbox;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.ContinueCancelButtons;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Description;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Label;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Name;
using FM.SHD.UI.WindowsForms.UserControls.Views;
using FM.SHD.Winforms.UI.UserControls.Wallet;
using FM.SHD.Winforms.UI.Views.Account;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Winforms.UI.DependencyInjection
{
    public static class ServicesCollectionExtension
    {
        public static IServiceCollection AddViews(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddScoped<IMainBaseView, MainBaseView>()
                .AddScoped<MainBasePresenter>()
                //.AddTransient<ITransactionBaseView, TransactionBaseView>()
                //.AddTransient<TransactionPresenter>()
                // Было во AddUsersControlViews
                //.AddTransient<ATransactionBasePresenter, TransactionPresenter>()
                .AddTransient<IAccountBaseView, AccountBaseView>()
                .AddTransient<AccountPresenter>();
        }

        public static IServiceCollection AddUserControlViews(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                //.AddTransient<ITypeTransactionUCView, TypeTransactionUCView>()
                //.AddTransient<ITypeTransactionUCPresenter, TypeTransactionUCPresenter>()
                .AddTransient<INameTextboxUCView, NameTextboxUCView>()
                .AddTransient<INameUCPresenter, NameUcPresenter>()
                .AddTransient<IDescriptionTextboxUCView, DescriptionTextboxUCView>()
                .AddTransient<IDescriptionUCPresenter, DescriptionUcPresenter>()
                //.AddTransient<IAccountsInfoTransactionUCView, AccountsInfoTransactionUCView>()
                //.AddTransient<IAccountsInfoTransactionUCPresenter, AccountsInfoTransactionUCPresenter>()
                .AddTransient<ICategoryUCPresenter<AccountServices>, CategoryUCPresenter<IAccountServices>>()
                .AddTransient<ICategoryUCPresenter<AccountCategoryServices>,
                    CategoryUCPresenter<IAccountCategoryServices>>()
                .AddTransient<ICategoryUCPresenter<TypeTransactionServices>,
                    CategoryUCPresenter<ITypeTransactionServices>>()
                .AddTransient<ICategoryUCPresenter<CategoriesServices>, CategoryUCPresenter<ICategoriesServices>>()
                .AddTransient<ICategoryUCPresenter<ContragentServices>, CategoryUCPresenter<IContragentServices>>()
                .AddTransient<ICategoryUCPresenter<IdentityServices>, CategoryUCPresenter<IIdentityServices>>()
                .AddTransient<ICategoryUCPresenter<CurrencyServices>, CategoryUCPresenter<ICurrencyServices>>()
                .AddTransient<ICategoryUCView, CategoryUCView>()
                //.AddTransient<IContrAgentUCView, ContrAgentUCView>()
                //.AddTransient<IContrAgentUCPresenter, ContrAgentUCPresenter>()
                //.AddTransient<IIdentityUCView, IdentityUCView>()
                //.AddTransient<IIdentityUCPresenter, IdentityUCPresenter>()
                .AddTransient<IContinueCancelButtonsUcView, ContinueCancelButtonsUcView>()
                .AddTransient<IContinueCancelButtonsUCPresenter, ContinueCancelButtonsUCPresenter>()
                //.AddTransient<IAccountInfoUCView, AccountInfoUCView>()
                //.AddTransient<IAccountInfoUCPresenter, AccountInfoUCPresenter>()
                //.AddTransient<ISumTransactionUCView, SumTransactionUCView>()
                //.AddTransient<ISumTransactionUCPresenter, SumTransactionUCPresenter>()
                //.AddTransient<IDateTransactionUCView, DateTransactionUCView>()
                //.AddTransient<IDateTransactionUCPresenter, DateTransactionUCPresenter>()
                .AddTransient<ILabelTextBoxUCView, LabelTextBoxUCView>()
                .AddTransient<ILabelTextboxUcPresenter, LabelTextboxPresenter>()
                .AddTransient<ICheckboxUCView, CheckboxUCView>()
                .AddTransient<ICheckboxUCPresenter, CheckboxUCPresenter>()
                .AddTransient<IAccountBaseView, AccountBaseView>()
                .AddTransient<BaseAccountPresenter, AccountPresenter>()
                .AddTransient<IAccountSummaryUCView, AccountSummaryUCView>()
                .AddTransient<IAccountSummaryUCPresenter, AccountSummaryUCPresenter>();
            //.AddTransient<IAllTransactionUCView, AllTransactionUCView>()
            //.AddTransient<IAllTransactionUCPresenter, AllTransactionUCPresenter>();
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