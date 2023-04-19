using FM.SHD.Plugins.Interfaces;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Categories.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Categories.UserControls;

namespace FM.SHD.Plugin.Categories.WindowsForms.Presenters
{
    public class CategoriesManagementUCPresenter : ICategoriesManagementUCPresenter
    {
        private readonly ICategoriesManagerUCView _categoriesManagerUCView;
        private readonly IPluginManager _pluginManager;
        
        public CategoriesManagementUCPresenter(ICategoriesManagerUCView categoriesManagerUCView, IPluginManager pluginManager)
        {
            _categoriesManagerUCView = categoriesManagerUCView;
            _pluginManager = pluginManager;
            
            _categoriesManagerUCView.AddCategory += OnAddCategory;
            _categoriesManagerUCView.Search += OnSearch;
        }

        private void OnSearch()
        {
            throw new System.NotImplementedException();
        }

        private void OnAddCategory()
        {
            var plugin = _pluginManager.GetPlugin<ICategoriesPlugin>();
            plugin.GetPluginPresenter("TransactionPresenter").Run("Добавить транзакцию");

        }

        public ICategoriesManagerUCView GetUserControlView()
        {
            return _categoriesManagerUCView;
        }
    }
}