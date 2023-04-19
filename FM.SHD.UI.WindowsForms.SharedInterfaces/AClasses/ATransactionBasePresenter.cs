using FM.SHD.UI.WindowsForms.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Categories.Views;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.UI.WindowsForms.SharedInterfaces.AClasses
{
    public abstract class ACategoriesBasePresenter 
        : BasePresenter<ICategoryManagementView, CategoryDto>
    {
        public ACategoriesBasePresenter(ICategoryManagementView managementView) : base(managementView)
        {
        }
    }
}