using FM.SHD.UI.WindowsForms.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.AClasses;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Views;

namespace FM.SHD.Plugins.Interfaces
{
    public interface ITransactionPlugin: IPlugin
    {

        public ATransactionBasePresenter GetPluginPresenter(string pluginPresenterName);
    }
}