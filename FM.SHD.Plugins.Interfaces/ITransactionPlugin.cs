using FM.SHD.UI.WindowsForms.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Views;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Plugins.Interfaces
{
    public interface ITransactionPlugin : IPlugin
    {
        public IBasePresenter<ITransactionBaseView> GetPluginPresenter();

        public IBasePresenter<ITransactionBaseView> GetPluginPresenter(string pluginPresenterName, string captionText,
            BaseDto dto = null);
    }
}