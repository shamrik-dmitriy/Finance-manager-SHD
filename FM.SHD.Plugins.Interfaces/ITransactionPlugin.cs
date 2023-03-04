using FM.SHD.UI.WindowsForms.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.AClasses;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Views;

namespace FM.SHD.Plugins.Interfaces
{
    public interface ITransactionPlugin
    {
        public IBasePresenter<ITransactionBaseView> GetPluginPresenter();

        public ATransactionBasePresenter GetPluginPresenter(string pluginPresenterName);
    }
}