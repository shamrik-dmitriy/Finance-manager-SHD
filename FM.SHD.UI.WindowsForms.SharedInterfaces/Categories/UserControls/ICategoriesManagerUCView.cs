using System;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.UI.WindowsForms.SharedInterfaces.Categories.UserControls
{
    public interface ICategoriesManagerUCView: IUserControlView
    {
        event Action AddCategory;
        event Action Search;
    }
}