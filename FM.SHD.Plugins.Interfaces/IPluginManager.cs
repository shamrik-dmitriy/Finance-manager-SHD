using System;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Plugins.Interfaces
{
    public interface IPluginManager
    {
        T GetPlugin<T>();
        //void SetServiceProvider(IServiceProvider serviceProvider);
    }
}