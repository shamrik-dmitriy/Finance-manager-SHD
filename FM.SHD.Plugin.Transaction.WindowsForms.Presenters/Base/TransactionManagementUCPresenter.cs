using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Base
{
    public class TransactionManagementUCPresenter : ITransactionManagementUCPresenter
    {
        private readonly ITransactionManagementUCView _transactionManagementUCView;

        public TransactionManagementUCPresenter(ITransactionManagementUCView transactionManagementUCView)
        {
            _transactionManagementUCView = transactionManagementUCView;
        }

        public ITransactionManagementUCView GetUserControlView()
        {
            return _transactionManagementUCView;
        }
    }
}