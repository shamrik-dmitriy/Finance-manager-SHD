using FM.SHD.Presenters.Common;
using FM.SHD.Presenters.NewViews;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.NewPresenters
{
    public abstract class BaseLoginPresenter
        : BasePresenter<ILoginView, IdentityDto>
    {
        public BaseLoginPresenter(ILoginView view) : base(view)
        {
        }
    }
}