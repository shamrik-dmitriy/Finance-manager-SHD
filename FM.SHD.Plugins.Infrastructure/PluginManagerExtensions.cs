using System;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Plugins.Infrastructure
{
    public static class PluginManagerExtensions
    {
        public static IServiceCollection AddPluginManager(this IServiceCollection services, string path)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            var pluginManager = new PluginManager(services, path);
            pluginManager.LoadPlugins();
            return pluginManager.UpdateServices();

           // return services;
        }
    }
}