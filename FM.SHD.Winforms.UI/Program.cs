using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FM.SHD.Domain;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Plugins.Infrastructure;
using FM.SHD.Presenters.Events;
using FM.SHD.Presenters.ViewPresenters;
using FM.SHD.Services.CommonServices;
using FM.SHD.Settings.Services;
using FM.SHD.Settings.Services.SettingsCollection;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Events;
using FM.SHD.Winforms.UI.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

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

            // TODO: Захардкожено, исправить
            var moduleAssembly = System.Reflection.Assembly.LoadFrom(@"D:\repos\SHD\FM.SHD.Plugin.Transaction\bin\Debug\net5.0-windows\FM.SHD.Plugin.Transaction.dll");
            var moduleTypes = moduleAssembly.GetTypes().Where(t => 
                t.GetInterfaces().Contains(typeof(IPlugin)));

            var modules = moduleTypes.Select( type =>
            {   
                return  (IPlugin) Activator.CreateInstance(type,"");
            });

            var transactionModule = modules.Where(x => x.Id == "Transaction");

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
                        .AddTransient<TransactionsDomain>()
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
                    var mainPresenter = services.GetRequiredService<MainBasePresenter>();
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
                $"{((Exception)e.ExceptionObject).Message}{Environment.NewLine}" +
                $"Пожалуйста свяжитесь с разработчиком");

            MessageBox.Show(message, "Неожиданная ошибка");
        }

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (e.Exception is FileNotFoundException)
            {
                stringBuilder.Append(String.Format(
                    $"Произошла ошибка при работе с файлом. {Environment.NewLine}" +
                    $"{e.Exception.Message}{Environment.NewLine}"));
                MessageBox.Show(stringBuilder.ToString(), "Произошла ошибка при работе с файлом");
            }
            else
            {
                var message = String.Format(
                    $"Произошла ошибка. {Environment.NewLine}" +
                    $"{e.Exception.Message}{Environment.NewLine}" +
                    $"Пожалуйста свяжитесь с разработчиком");

                MessageBox.Show(message, "Неожиданная ошибка");
            }
        }
    }
}