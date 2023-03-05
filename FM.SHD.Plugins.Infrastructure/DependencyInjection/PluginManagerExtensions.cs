using System;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Plugins.Infrastructure.DependencyInjection
{
    public static class PluginManagerExtensions
    {
        public static IServiceCollection AddPlugins(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            PluginsServiceCollectionAdder plugins = new PluginsServiceCollectionAdder();
            return plugins.UpdateServices(services);
        }
        
        public static IServiceCollection AddPluginsTypes(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            
            PluginsServiceCollectionTypesAdder pluginsTypes = new PluginsServiceCollectionTypesAdder();
            return pluginsTypes.UpdateServices(services);
        }
    }
}