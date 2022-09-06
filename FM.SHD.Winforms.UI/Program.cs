using System;
using System.Threading;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Events;
using FM.SHD.Services.CommonServices;
using FM.SHD.Settings.Services;
using FM.SHD.Settings.Services.SettingsCollection;
using FM.SHD.Winforms.UI.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MainPresenter = FM.SHD.Presenters.NewPresenters.MainPresenter;

namespace FM.SHD.Winforms.UI
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


          var builder = new HostBuilder()
                .ConfigureServices((hostBuilder, services) =>
                {
                    services
                        .AddSingleton<EventAggregator>()
                        .AddTransient<IApplicationEvent, OnSelectedTypeOfTransactionApplicationEvent>()
                        .AddServices()
                        .AddScoped<ApplicationContext>()
                        .AddViews()
                        .AddUserControlViews()
                        .AddSingleton<SystemRecentOpenFilesSettings>()
                        .AddSingleton<SettingServices<SystemRecentOpenFilesSettings>>()
                        .AddRepositories()
                        .AddTransient<IModelValidator, ModelValidator>()
                        .AddLogging(configure =>
                        {
                            configure.SetMinimumLevel(LogLevel.Information);
                            configure.AddConsole();
                        });
                });

            var host = builder.Build();
            using var serviceScope = host.Services.CreateScope();
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var mainPresenter = services.GetRequiredService<MainPresenter>();
                    mainPresenter.Run();
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