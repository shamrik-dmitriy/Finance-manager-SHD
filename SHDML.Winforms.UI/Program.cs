using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using FM.SHD.Infastructure.Impl.Repositories.Specific.SingleTransaction;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters;
using FM.SHD.Presenters.Events;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Presenters.ViewPresenters;
using FM.SHD.Services.CommonServices;
using FM.SHD.Services.Repositories;
using FM.SHD.Services.Settings;
using FM.SHD.Services.SingleTransactionServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SHDML.Winforms.UI.DependencyInjection;
using SHDML.Winforms.UI.Transactions;

namespace SHDML.Winforms.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationOnThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;


            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            var builder = new HostBuilder()
                .ConfigureServices((hostBuilder, services) =>
                {
                    services
                        .AddSingleton<IConfiguration>(config)
                        .Configure<DatabaseOptions>(config.GetSection("ConnectionStrings"))
                        .AddSingleton<EventAggregator>()
                        .AddTransient<IApplicationEvent, OnSelectedTypeOfTransactionApplicationEvent>()
                        .AddServices()
                        .AddViews()
                        .AddUserControlViews()
                        .AddRepositories(config)
                        .AddTransient<IModelValidator, ModelValidator>()
                        .AddLogging(configure =>
                        {
                            configure.SetMinimumLevel(LogLevel.Information);
                            configure.AddConsole();
                        });
                });

            var host = builder.Build();
            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var mainPresenter = services.GetRequiredService<MainPresenter>();
                    Application.Run((MainView)mainPresenter.GetMainView());
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"Error: {exception.Message}");
                }
            }
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var message = String.Format(
                $"Произошла ошибка. {Environment.NewLine}" +
                $"{((Exception)e.ExceptionObject).Message}" +
                $"Пожалуйста свяжитесь с разработчиком");

            MessageBox.Show(message, "Неожиданная ошибка");
        }

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var message = String.Format(
                $"Произошла ошибка. {Environment.NewLine}" +
                $"{e.Exception.Message}" +
                $"Пожалуйста свяжитесь с разработчиком");

            MessageBox.Show(message, "Неожиданная ошибка");
        }
    }
}