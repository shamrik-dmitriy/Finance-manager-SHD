using System.Windows.Forms;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.AClasses;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Plugins.Interfaces
{
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        string Id { get; }

        bool IsAddDataToTab { get; }
        bool IsAddDataToMenu { get; }

        TabPage GetTab();

        ToolStripMenuItem GetMenuItem();

        IServiceCollection AddPluginServices();

        ATransactionBasePresenter GetPluginPresenter(string pluginPresenterName);
    }
}