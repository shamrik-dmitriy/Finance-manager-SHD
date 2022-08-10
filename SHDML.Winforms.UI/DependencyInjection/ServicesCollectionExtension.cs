using FM.SHD.Infastructure.Impl.Repositories.Specific.SingleTransaction;
using FM.SHD.Presenters;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Services.Repositories;
using FM.SHD.Services.SingleTransactionServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SHDML.Winforms.UI.Transactions;

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

        public static IServiceCollection AddRepositories(this IServiceCollection serviceCollection,
            IConfigurationRoot config)
        {
            return serviceCollection
                .AddTransient<ISingleTransactionRepository, SingleTransactionRepository>(provider =>
                    new SingleTransactionRepository(
                        config.GetConnectionString("DefaultConnection")))
                .AddTransient<ISingleTransactionRepository, SingleTransactionRepository>(provider =>
                    new SingleTransactionRepository(
                        config.GetConnectionString("DefaultConnection")));
        }

        public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<ISingleTransactionServices, SingleTransactionServices>();
        }
    }
}