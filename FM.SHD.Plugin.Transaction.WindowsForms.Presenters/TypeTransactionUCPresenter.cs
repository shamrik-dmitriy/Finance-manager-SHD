using FM.SHD.Services.ComponentsServices.TypeTransactionService;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters
{
    public class TypeTransactionUCPresenter : ITypeTransactionUCPresenter
    {
        private readonly ITypeTransactionUCView _typeTransactionUcView;
        private readonly ITypeTransactionServices _typeTransactionServices;

        public TypeTransactionUCPresenter(
            ITypeTransactionUCView typeTransactionUcView,
            ITypeTransactionServices typeTransactionServices)
        {
            _typeTransactionUcView = typeTransactionUcView;
            _typeTransactionServices = typeTransactionServices;

            _typeTransactionUcView.OnLoadUserControlView += TypeTransactionUcViewOnOnLoadUserControlView;
        }

        private void TypeTransactionUcViewOnOnLoadUserControlView()
        {
            _typeTransactionUcView.SetTransactionTypes(_typeTransactionServices.GetAll());
        }

        public ITypeTransactionUCView GetUserControlView()
        {
            return _typeTransactionUcView;
        }
    }
}