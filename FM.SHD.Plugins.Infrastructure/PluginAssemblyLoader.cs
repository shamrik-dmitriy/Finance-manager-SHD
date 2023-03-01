using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace FM.SHD.Plugins.Infrastructure
{
    public static class PluginAssemblyLoader
    {
        public static IEnumerable<IGrouping<string, AssemblyInfo>> PluginAssemblyGroups { get; set; }

        public static void LoadAssemblies()
        {
            var dlls = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Modules"),
                "FM.SHD.Plugin.*.dll", SearchOption.TopDirectoryOnly);

            var pluginCollection = dlls
                .Select(Assembly.LoadFrom)
                .Select(plugin => new AssemblyInfo(plugin))
                .ToList();

            PluginAssemblyGroups = pluginCollection.GroupBy(x => x.PluginName);
        }
    }
}