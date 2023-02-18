using System;
using FM.SHD.Plugin.Transaction;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Plugins.Infrastructure
{
    public static class PluginManagerExtensions
    {
        public static IServiceCollection AddPluginManager(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            // Найти все плагины и подключить их в систему
            var pluginManager = new PluginManager(services);
            pluginManager.LoadPlugins();
            return pluginManager.UpdateServices();
        }
    }
}