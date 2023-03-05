using System;
using FM.SHD.Services.TransactionServices;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.AClasses;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Base
{
    public class ListAllTransactionUcPresenter : IListAllTransactionUCPresenter
    {
        private readonly IListAllTransactionUCView _view;
        private readonly ATransactionBasePresenter _aTransactionBasePresenter;
        private readonly ITransactionServices _transactionServices;

        public ListAllTransactionUcPresenter(
            IListAllTransactionUCView view,
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
            _aTransactionBasePresenter.Run("Редактирование транзакции",
                _transactionServices.GetById(transactionExtendedDto.Id));
            try
            {
                _view.SetData(_transactionServices.GetExtendedById(transactionExtendedDto.Id));
            }
            catch (ArgumentException)
            {
                // ignored
            }
        }

        public IListAllTransactionUCView GetUserControlView()
        {
            return _view;
        }
    }
}