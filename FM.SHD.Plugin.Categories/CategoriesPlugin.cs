using System;
using System.Windows.Forms;
using FM.SHD.Plugins.Interfaces;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.AClasses;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Plugin.Categories
{
    public class CategoriesPlugin : IPlugin, ICategoriesPlugin
    {
        public string Name => "Плагин категорий";
        public string Id => "Categories";
        public string Description => "Плагин добавляет функциональность для работы с категориями";
        public bool IsAddDataToTab { get; }
        public bool IsAddDataToMenu { get; }

        public TabPage GetTab()
        {
            throw new NotImplementedException();
        }

        public ToolStripMenuItem GetMenuItem()
        {
            throw new NotImplementedException();
        }

        public IServiceCollection AddPluginServices()
        {
            throw new NotImplementedException();
        }

        public ATransactionBasePresenter GetPluginPresenter(string pluginPresenterName)
        {
            throw new NotImplementedException();
        }
    }
}