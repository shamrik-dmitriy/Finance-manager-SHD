using FM.SHD.Services.CommonServices;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Category.ToolStripDropDownButtonCategory
{
    public interface ICategoryToolStripUCPresenter<T> where T : IBaseCategoryServices
    {

        void SetText(string text);
        void SetCategoryValues();

        ICategoryToolStripUCView GetUserControlView();

        long? GetCategoryId(bool isPossibleNull = false);

    }
}