using FM.SHD.Presenters.Common;
using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.ViewPresenters
{
    public abstract class BaseLoginPresenter
        : BasePresenter<ILoginView, IdentityDto>
    {
        public BaseLoginPresenter(ILoginView view) : base(view)
        {
        }
    }
}