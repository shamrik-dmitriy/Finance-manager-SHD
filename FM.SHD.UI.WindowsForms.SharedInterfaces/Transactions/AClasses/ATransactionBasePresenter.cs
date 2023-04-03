using FM.SHD.UI.WindowsForms.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Views;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.AClasses
{
    public abstract class ATransactionBasePresenter 
        : BasePresenter<ITransactionManagementView, TransactionDto>
    {
        public ATransactionBasePresenter(ITransactionManagementView managementView) : base(managementView)
        {
        }
    }
}