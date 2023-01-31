using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHD.UI.WindowsForms.Presenters;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.ViewPresenters
{
    public abstract class BaseLoginPresenter
        : BasePresenter<ILoginBaseView, IdentityDto>
    {
        public BaseLoginPresenter(ILoginBaseView baseView) : base(baseView)
        {
        }
    }
}