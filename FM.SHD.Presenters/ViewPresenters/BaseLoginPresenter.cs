using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHD.UI.WindowsForms.Presenters;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.ViewPresenters
{
    public abstract class BaseBaseLoginPresenter
        : BaseBasePresenter<ILoginBaseView, IdentityDto>
    {
        public BaseBaseLoginPresenter(ILoginBaseView baseView) : base(baseView)
        {
        }
    }
}