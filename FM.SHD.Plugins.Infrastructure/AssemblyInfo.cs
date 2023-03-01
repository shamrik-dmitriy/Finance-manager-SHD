using System;
using System.Reflection;

namespace FM.SHD.Plugins.Infrastructure
{
    public class AssemblyInfo
    {
        public string PluginName { get; }

        public Assembly Assembly { get; }

        public AssemblyInfo(Assembly assembly)
        {
            PluginName = assembly.GetName().Name.Split('.', StringSplitOptions.None)[3];
            Assembly = assembly;
        }
    }
}