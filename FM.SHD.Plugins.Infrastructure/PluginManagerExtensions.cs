using System;
using FM.SHD.Plugin.Transaction;
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

            var pluginSearcher = new PluginSearcher<TransactionPlugin>();
            pluginSearcher.SearchPlugins();

            
            var pluginManager = new PluginManager(services, path);
            pluginManager.LoadPlugins();
            return pluginManager.UpdateServices();
           // return services;
        }
    }
}