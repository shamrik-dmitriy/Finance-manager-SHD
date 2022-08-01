using System;
using System.IO;
using System.Windows.Forms;
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
                    .AddScoped<MainView>()
                    .AddSingleton(config)
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
                    var mainView = services.GetRequiredService<MainView>();

                    Application.Run(mainView);
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"Error: {exception.Message}");
                }

            }
        }


    }
}
