using FM.SHD.UI.WindowsForms.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.AClasses;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Views;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Plugins.Interfaces
{
    public interface ITransactionPlugin
    {
        public IBasePresenter<ITransactionBaseView> GetPluginPresenter();

        public ATransactionBasePresenter GetPluginPresenter(string pluginPresenterName, string captionText,
            BaseDto dto = null);
    }
}