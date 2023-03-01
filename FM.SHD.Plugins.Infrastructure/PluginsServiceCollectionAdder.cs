using System;
using System.Linq;
using System.Reflection;
using FM.SHD.Plugin.Transaction;
using FM.SHD.Plugins.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace FM.SHD.Plugins.Infrastructure
{
    public class PluginsServiceCollectionAdder
    {
        public IServiceCollection UpdateServices(IServiceCollection services)
        {
            PluginAssemblyLoader.LoadAssemblies();
            if (!PluginAssemblyLoader.PluginAssemblyGroups.Any())
                return services;

            foreach (var pluginGroup in PluginAssemblyLoader.PluginAssemblyGroups)
            {
                //WriteLine($"Добавляем в зависимости плагины {pluginGroup.Key}");
                foreach (var assemblyInfo in pluginGroup)
                {
                    var pluginClass = assemblyInfo.Assembly.GetTypes()
                        .SingleOrDefault(type => typeof(IPlugin).IsAssignableFrom(type));
                    if (pluginClass == null)
                        continue;
                    
                    var pluginInterface = pluginClass.GetInterfaces().First(x => x.Name == $"I{pluginClass.Name}");

                    services.AddSingleton(pluginInterface, pluginClass);
                    //services.AddSingleton(pluginInterface, x =>
                    //{
                    //    return new Func<IServiceProvider,dynamic>(provider => new TransactionPlugin(services));
                    //});
                }
            }

            return services;
        }
    }
}