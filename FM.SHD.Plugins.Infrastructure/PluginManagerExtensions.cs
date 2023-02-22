using System;
using FM.SHD.Plugin.Transaction;
using FM.SHD.Plugins.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Plugins.Infrastructure
{
    public static class PluginManagerExtensions
    {
        public static IServiceCollection AddPlugins(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            PluginsServiceCollectionAdder test = new PluginsServiceCollectionAdder();
            return test.UpdateServices(services);
        }
    }
}