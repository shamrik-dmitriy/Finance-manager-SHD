using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace FM.SHD.Plugins.Infrastructure
{
    public class PluginSearcher<T> where T : IPlugin
    {
        public PluginSearcher()
        {
        }

        public IReadOnlyCollection<string> SearchPlugins()
        {
            var assemblies = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Modules"),
                "FM.SHD.Plugin.*.dll");
            return SearchPluginsInAssemblies(assemblies);
        }

        private IReadOnlyCollection<string> SearchPluginsInAssemblies(string[] assemblyPaths)
        {
            var assemblyPluginsInfos = new List<string>();
            var pluginSearcherAssemblyContext = new AssemblyLoadContext("PluginSearcherAssemblyContext");
            foreach (var assemblyPath in assemblyPaths)
            {
                var assembly = pluginSearcherAssemblyContext.LoadFromAssemblyPath(assemblyPath);
                if (GetPluginsTypes(assembly).Any())
                {
                    assemblyPluginsInfos.Add(assembly.Location);
                }
            }

            pluginSearcherAssemblyContext.Unload();
            return assemblyPluginsInfos;
        }

        public static IReadOnlyCollection<Type> GetPluginsTypes(Assembly assembly)
        {
            return assembly.GetTypes().Where(type => !type.IsAbstract && typeof(T).IsAssignableFrom(type)).ToArray();
        }
    }

    internal class PluginHost<T> where T : IPlugin
    {
        private Dictionary<string, T> _plugins = new Dictionary<string, T>();
        private readonly AssemblyLoadContext _pluginAssemblyLoadingContext;

        public PluginHost()
        {
            _pluginAssemblyLoadingContext = new AssemblyLoadContext("PluginAssemblyContext");
        }

        public T GetPlugin(string pluginName)
        {
            return _plugins[pluginName];
        }

        public IReadOnlyCollection<T> GetPlugins()
        {
            return _plugins.Values;
        }

        public void LoadPlugins(IReadOnlyCollection<string> assembliesWithPlugins)
        {
            foreach (var assemblyPath in assembliesWithPlugins)
            {
                var assembly = _pluginAssemblyLoadingContext.LoadFromAssemblyPath(assemblyPath);
                var validPluginTypes = PluginSearcher<T>.GetPluginsTypes(assembly);
                foreach (var pluginType in validPluginTypes)
                {
                    var pluginInstance = (T)Activator.CreateInstance(pluginType);
                    RegisterPlugin(pluginInstance);
                }
            }
        }

        private void RegisterPlugin(T pluginInstance)
        {
            throw new NotImplementedException();
        }

        public void Unload()
        {
            _plugins.Clear();
            _pluginAssemblyLoadingContext.Unload();
        }
    }
}