using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Transactions;
using FM.SHD.Services.ComponentsServices.TypeTransactionService;
using FM.SHD.Services.Repositories;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory2.Transactions
{
    public class TypeTransactionUCPresenter : ITypeTransactionUCPresenter
    {
        private readonly ITypeTransactionUCView _typeTransactionUcView;
        private readonly ITypeTransactionServices _typeTransactionServices;
        private readonly ITypeTransactionRepository _typeTransactionRepository;

        public TypeTransactionUCPresenter(
            ITypeTransactionUCView typeTransactionUcView,
            ITypeTransactionServices typeTransactionServices,
            ITypeTransactionRepository typeTransactionRepository)
        {
            _typeTransactionUcView = typeTransactionUcView;
            _typeTransactionServices = typeTransactionServices;
            _typeTransactionRepository = typeTransactionRepository;
            
            _typeTransactionUcView.OnLoadUserControlView +=TypeTransactionUcViewOnOnLoadUserControlView;
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