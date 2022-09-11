using System;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Events.Transactions;
using FM.SHD.Presenters.Interfaces.UserControls.Main;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Main;
using FM.SHD.Presenters.ViewPresenters;
using FM.SHD.Services.TransactionServices;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.UserControlPresenters.Main
{
    public class AllTransactionUCPresenter : IAllTransactionUCPresenter
    {
        private readonly IAllTransactionUCView _view;
        private readonly BaseTransactionPresenter _baseTransactionPresenter;
        private readonly ITransactionServices _transactionServices;

        public AllTransactionUCPresenter(
            IAllTransactionUCView view,
            BaseTransactionPresenter baseTransactionPresenter,
            ITransactionServices transactionServices)
        {
            _view = view;
            _baseTransactionPresenter = baseTransactionPresenter;
            _transactionServices = transactionServices;

            _view.UpdateTransaction += ViewOnUpdateTransaction;
        }

        private void ViewOnUpdateTransaction(TransactionExtendedDto transactionExtendedDto)
        {
            _baseTransactionPresenter.SetTitle("Редактирование транзакции");
            _baseTransactionPresenter.Run(_transactionServices.GetById(transactionExtendedDto.Id));
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