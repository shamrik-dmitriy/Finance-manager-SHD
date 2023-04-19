using FM.SHD.UI.WindowsForms.SharedInterfaces.AClasses;

namespace FM.SHD.Plugins.Interfaces
{
    public interface ICategoriesPlugin : IPlugin
    {
        public ACategoriesBasePresenter GetPluginPresenter(string pluginPresenterName);
    }
}