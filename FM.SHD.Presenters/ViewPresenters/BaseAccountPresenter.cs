using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHD.UI.WindowsForms.Presenters;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.ViewPresenters
{
    public abstract class BaseAccountPresenter : BasePresenter<IAccountBaseView, AccountDto>
    {
        public BaseAccountPresenter(IAccountBaseView baseView) : base(baseView)
        {
        }
    }
}