using System;
using System.Linq;
using FM.SHD.Plugins.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Plugins.Infrastructure.DependencyInjection
{
    public class PluginsServiceCollectionTypesAdder
    {
        public IServiceCollection UpdateServices(IServiceCollection services)
        {
            PluginAssemblyLoader.LoadAssemblies();
            if (!PluginAssemblyLoader.PluginAssemblyGroups.Any())
                return services;

            foreach (var pluginGroup in PluginAssemblyLoader.PluginAssemblyGroups)
            {
                //WriteLine($"Добавляем в зависимости типы плагина {pluginGroup.Key}");
                foreach (var assemblyInfo in pluginGroup)
                {
                    var pluginClass = assemblyInfo.Assembly.GetTypes()
                        .SingleOrDefault(type => typeof(IPlugin).IsAssignableFrom(type));
                    if (pluginClass == null)
                        continue;
                    
                    var pluginInstance = Activator.CreateInstance(pluginClass, services);
                    
                    var loadMethod = pluginClass.GetMethod("AddPluginServices");
                    var t = loadMethod.Invoke(pluginInstance, null);
                    //return (IServiceCollection)t;
                    //loadMethod.Invoke(pluginInstance, null);
                    // https://gunnarpeipman.com/aspnet-core-plugins/
                    // foreach (var type in assemblyInfo.Assembly.GetTypes()) //.OrderBy(t=>t.GetTypeInfo()))
                    // {
                    //     _services.AddTransient(type);
                    // }
                }
            }

            return services;
        }
        public IServiceCollection UpdateServiceProvider(IServiceCollection services)
        {
            PluginAssemblyLoader.LoadAssemblies();
            if (!PluginAssemblyLoader.PluginAssemblyGroups.Any())
                return services;

            foreach (var pluginGroup in PluginAssemblyLoader.PluginAssemblyGroups)
            {
                //WriteLine($"Добавляем в зависимости типы плагина {pluginGroup.Key}");
                foreach (var assemblyInfo in pluginGroup)
                {
                    var pluginClass = assemblyInfo.Assembly.GetTypes()
                        .SingleOrDefault(type => typeof(IPlugin).IsAssignableFrom(type));
                    if (pluginClass == null)
                        continue;
                    
                    var pluginInstance = Activator.CreateInstance(pluginClass, services);
                    
                    var loadMethod = pluginClass.GetMethod("AddPluginServices");
                    var t = loadMethod.Invoke(pluginInstance, null);
                    //return (IServiceCollection)t;
                    //loadMethod.Invoke(pluginInstance, null);
                    // https://gunnarpeipman.com/aspnet-core-plugins/
                    // foreach (var type in assemblyInfo.Assembly.GetTypes()) //.OrderBy(t=>t.GetTypeInfo()))
                    // {
                    //     _services.AddTransient(type);
                    // }
                }
            }

            return services;
        }

    }
}