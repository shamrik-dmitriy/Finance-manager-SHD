using FM.SHD.Presenters.Common;
using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.ViewPresenters
{
    public abstract class BaseTransactionPresenter 
        : BasePresenter<ITransactionView, TransactionDto>
    {
        public BaseTransactionPresenter(ITransactionView view) : base(view)
        {
        }
    }
}