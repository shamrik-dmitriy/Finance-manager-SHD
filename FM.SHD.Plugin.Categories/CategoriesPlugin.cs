using System;
using System.Windows.Forms;
using FM.SHD.Plugins.Interfaces;
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
            return _serviceCollection;
        }
    }
}