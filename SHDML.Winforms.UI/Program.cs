using System;
using System.IO;
using System.Windows.Forms;
using FM.SHD.Presenters;
using FM.SHD.Services.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

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

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .Build();
            
            var builder = new HostBuilder()
                .ConfigureServices((hostBuilder, services) =>
                {
                    services
                    .AddTransient<IMainView, MainView>()
                    .AddTransient<IMainPresenter, MainPresenter>()
                    .AddSingleton<IConfiguration>(config)
                    .Configure<DatabaseOptions>(config.GetSection("ConnectionStrings"))
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


    }
}
