using FM.SHD.Presenters.Common;
using FM.SHD.Presenters.NewViews;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.NewPresenters
{
    public abstract class BaseAccountPresenter : BasePresenter<IAccountView, AccountDto>
    {
        public BaseAccountPresenter(IAccountView view) : base(view)
        {
        }

        public abstract void SetTitle(string редактированиеСчёта);
    }
}