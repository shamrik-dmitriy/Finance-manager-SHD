using System;
using System.Windows.Forms;
using FM.SHD.Plugin.Categories.WindowsForms.Presenters;
using FM.SHD.Plugin.Categories.WindowsForms.Views;
using FM.SHD.Plugins.Interfaces;
using FM.SHD.UI.WindowsForms.SharedInterfaces.AClasses;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Categories.Views;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.TabPage;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Plugin.Categories
{
    public class CategoriesPlugin : ICategoriesPlugin
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IServiceCollection _serviceCollection;
        public string Name => "Плагин категорий";
        public string Description => "Плагин добавляет функциональность для работы с категориями";
        public string Id => "Categories";
        public string TabText => "Категории";
        public bool IsAddDataToTab { get; }
        public bool IsAddDataToMenu { get; }

        public CategoriesPlugin(IServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        public CategoriesPlugin(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public TabPage GetTab()
        {
            var tabPageUCPresenter = _serviceProvider.GetRequiredService<ITabPageUCPresenter>();
            // Конструируем вкладку
            var tabPage = new TabPage()
            {
                Text = TabText
            };
            tabPage.Controls.Add((UserControl)tabPageUCPresenter.GetUserControlView());
            return tabPage;
        }

        public ToolStripMenuItem GetMenuItem()
        {
            throw new NotImplementedException();
        }

        public IServiceCollection AddPluginServices()
        {
            return _serviceCollection
                //Views
                .AddTransient<ICategoryManagementView, CategoryManagementView>()
                .AddTransient<ACategoriesBasePresenter, CategoryPresenter>();
            //UserControls
            /* .AddTransient<IListAllCategoryUCView, ListAllCategoryUcView>()
             .AddTransient<IListAllCategoryUCPresenter, IListAllCategoryUCPresenter>()
             .AddTransient<ICategoryManagementUCView, CategoryManagementUCView>()
             .AddTransient<ICategoryManagementUCPresenter, CategoryManagementUCPresenter>();*/
        }

        public ACategoriesBasePresenter GetPluginPresenter(string pluginPresenterName)
        {
            return _serviceProvider.GetRequiredService<ACategoriesBasePresenter>();
        }
    }
}