using System;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Transactions;
using FM.SHD.Services.TransactionServices;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory2.Transactions
{
    public class AllTransactionUCPresenter : IAllTransactionUCPresenter
    {
        private readonly IAllTransactionUCView _view;
        private readonly BaseBaseTransactionPresenter _baseBaseTransactionPresenter;
        private readonly ITransactionServices _transactionServices;

        public AllTransactionUCPresenter(
            IAllTransactionUCView view,
            BaseBaseTransactionPresenter baseBaseTransactionPresenter,
            ITransactionServices transactionServices)
        {
            _view = view;
            _baseBaseTransactionPresenter = baseBaseTransactionPresenter;
            _transactionServices = transactionServices;

            _view.UpdateTransaction += ViewOnUpdateTransaction;
        }

        private void ViewOnUpdateTransaction(TransactionExtendedDto transactionExtendedDto)
        {
            _baseBaseTransactionPresenter.SetTitle("Редактирование транзакции");
            _baseBaseTransactionPresenter.Run(_transactionServices.GetById(transactionExtendedDto.Id));
            try
            {
                _view.SetData(_transactionServices.GetExtendedById(transactionExtendedDto.Id));
            }
            catch (ArgumentException)
            {
                // ignored
            }
        }

        public IAllTransactionUCView GetUserControlView()
        {
            return _view;
        }
    }
}