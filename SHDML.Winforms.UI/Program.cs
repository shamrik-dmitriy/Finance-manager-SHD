using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
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

            var services = new ServiceCollection();
            ConfigureServices(services);
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var mainView = serviceProvider.GetRequiredService<MainView>();
                Application.Run(mainView);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<MainView>()
                    .AddLogging(configure => configure.AddConsole());
        }
    }
}
