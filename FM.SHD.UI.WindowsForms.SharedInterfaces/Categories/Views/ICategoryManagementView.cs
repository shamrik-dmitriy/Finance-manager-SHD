using FM.SHD.UI.WindowsForms.Presenters;

namespace FM.SHD.UI.WindowsForms.SharedInterfaces.Categories.Views
{
    public interface ICategoryManagementView: IBaseView
    {
        bool ShowMessageDelete(string title, string message);

    }
}