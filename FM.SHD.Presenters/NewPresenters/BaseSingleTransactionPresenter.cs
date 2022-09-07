using FM.SHD.Presenters.Common;
using FM.SHD.Presenters.NewViews;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.NewPresenters
{
    public abstract class BaseSingleTransactionPresenter 
        : BasePresenter<ISingleTransactionView, SingleTransactionDto>
    {
        public BaseSingleTransactionPresenter(ISingleTransactionView view) : base(view)
        {
        }
    }
}