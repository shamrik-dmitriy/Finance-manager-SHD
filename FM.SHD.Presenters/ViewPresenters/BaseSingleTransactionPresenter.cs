using FM.SHD.Presenters.Common;
using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.ViewPresenters
{
    public abstract class BaseSingleTransactionPresenter 
        : BasePresenter<ISingleTransactionView, SingleTransactionDto>
    {
        public BaseSingleTransactionPresenter(ISingleTransactionView view) : base(view)
        {
        }
    }
}