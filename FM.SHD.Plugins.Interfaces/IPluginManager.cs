namespace FM.SHD.Plugins.Interfaces
{
    public interface IPluginManager
    {
        IPlugin GetPlugin<T>();
    }
}