using System;
using FM.SHD.Services.TransactionServices;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.AClasses;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.UserControls
{
    public class AllTransactionUCPresenter : IAllTransactionUCPresenter
    {
        private readonly IAllTransactionUCView _view;
        private readonly ATransactionBasePresenter _aTransactionBasePresenter;
        private readonly ITransactionServices _transactionServices;

        public AllTransactionUCPresenter(
            IAllTransactionUCView view,
            ATransactionBasePresenter aTransactionBasePresenter,
            ITransactionServices transactionServices)
        {
            _view = view;
            _aTransactionBasePresenter = aTransactionBasePresenter;
            _transactionServices = transactionServices;

            _view.UpdateTransaction += ViewOnUpdateTransaction;
        }

        private void ViewOnUpdateTransaction(TransactionExtendedDto transactionExtendedDto)
        {
            _aTransactionBasePresenter.SetTitle("Редактирование транзакции");
            _aTransactionBasePresenter.Run(_transactionServices.GetById(transactionExtendedDto.Id));
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