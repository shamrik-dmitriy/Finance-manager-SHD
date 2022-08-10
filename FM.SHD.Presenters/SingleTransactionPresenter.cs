using System;
using FM.SHD.Presenters.Interfaces;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Services.Repositories;
using FM.SHD.Services.SingleTransactionServices;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;
using Microsoft.Extensions.DependencyInjection;
using SHDML.BLL.DTO.DTO;

namespace FM.SHD.Presenters
{
    public class SingleTransactionPresenter : ISingleTransactionPresenter
    {
        private ISingleTransactionView _singleTransactionView;
        private IServiceProvider _serviceProvider;
        private ISingleTransactionServices _singleTransactionServices;
        private readonly ITypeTransactionUserControlPresenter _typeTransactionUserControlPresenter;

        public SingleTransactionPresenter(
            IServiceProvider serviceProvider, 
            ISingleTransactionView singleTransactionView, 
            ISingleTransactionServices singleTransactionServices,
            ITypeTransactionUserControlPresenter typeTransactionUserControlPresenter)
        {
            _singleTransactionView = singleTransactionView;
            _singleTransactionServices = singleTransactionServices;
            _typeTransactionUserControlPresenter = typeTransactionUserControlPresenter;
            _serviceProvider = serviceProvider;
            _singleTransactionView.OnLoadEventrsss += SingleTransactionViewOnOnLoad;
            //_singleTransactionView.Add += SingleTransactionViewOnAdd;
            //_singleTransactionView.OnChangeTypeTransaction += _singleTransactionView_OnChangeTypeTransaction;
        }

        private void SingleTransactionViewOnOnLoad()
        {
            _singleTransactionView.AddTypeTransactionUserControl(_typeTransactionUserControlPresenter.GetUserControlView());
        }

        private void _singleTransactionView_OnChangeTypeTransaction(int transactionType)
        {

        }

        private void SingleTransactionViewOnAdd(object sender, EventArgs e)
        {
            SingleTransactionDTO dto =  _singleTransactionView.GetTransactionInfo();
            _singleTransactionServices.Add(dto);
        }

        public ISingleTransactionView GetView()
        {
            return _singleTransactionView;
        }
    }
}