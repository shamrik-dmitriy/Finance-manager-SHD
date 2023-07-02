using FM.SHD.Services.CategoriesServices;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Category.ToolStripDropDownButtonCategory
{
    public class CategoryToolStripUCPresenter<T> :
        ICategoryToolStripUCPresenter<CategoriesServices>
    {
        private readonly T _service;
        private readonly ICategoryToolStripUCView _view;

        public CategoryToolStripUCPresenter(
            T service, ICategoryToolStripUCView view)
        {
            _service = service;
            _view = view;
        }

        public void SetText(string text)
        {
            _view.SetText(text);
        }

        public void SetCategoryValues()
        {
            throw new System.NotImplementedException();
        }

        public ICategoryToolStripUCView GetUserControlView()
        {
            return _view;
        }

        public long? GetCategoryId(bool isPossibleNull = false)
        {
            throw new System.NotImplementedException();
        }
    }
}