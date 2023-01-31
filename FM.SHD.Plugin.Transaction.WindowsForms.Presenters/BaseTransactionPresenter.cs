using FM.SHD.UI.WindowsForms.Presenters;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters
{
    public abstract class BaseBaseTransactionPresenter 
        : BaseBasePresenter<ITransactionBaseView, TransactionDto>
    {
        public BaseBaseTransactionPresenter(ITransactionBaseView baseView) : base(baseView)
        {
        }
    }
}