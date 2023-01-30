using FM.SHD.Plugin.Transaction.WindowsForms.Presenters;
using FM.SHD.UI.WindowsForms.Presenters;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.ViewPresenters
{
    public abstract class BaseBaseTransactionPresenter 
        : BaseBasePresenter<ITransactionBaseView, TransactionDto>
    {
        public BaseBaseTransactionPresenter(ITransactionBaseView baseView) : base(baseView)
        {
        }
    }
}