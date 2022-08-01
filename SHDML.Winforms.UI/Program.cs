using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

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

            var builder = new HostBuilder()
                .ConfigureServices((hostBuilder, services) =>
                {
                    services.AddScoped<MainView>()
                   .AddLogging(configure => configure.AddConsole());
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
