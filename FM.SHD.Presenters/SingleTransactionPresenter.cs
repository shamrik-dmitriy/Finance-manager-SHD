using System;
using FM.SHD.Presenters.Interfaces;
using FM.SHD.Presenters.Interfaces.UserControls;
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
        private readonly ITypeTransactionUCPresenter _typeTransactionUcPresenter;
        private readonly INameTransactionUCPresenter _nameTransactionUcPresenter;

        public SingleTransactionPresenter(
            IServiceProvider serviceProvider,
            ISingleTransactionView singleTransactionView,
            ISingleTransactionServices singleTransactionServices,
            ITypeTransactionUCPresenter typeTransactionUcPresenter,
            INameTransactionUCPresenter nameTransactionUcPresenter)
        {
            _singleTransactionView = singleTransactionView;
            _singleTransactionServices = singleTransactionServices;
            _typeTransactionUcPresenter = typeTransactionUcPresenter;
            _nameTransactionUcPresenter = nameTransactionUcPresenter;
            _serviceProvider = serviceProvider;
            _singleTransactionView.OnLoadEventrsss += SingleTransactionViewOnOnLoad;
            //_singleTransactionView.Add += SingleTransactionViewOnAdd;
            //_singleTransactionView.OnChangeTypeTransaction += _singleTransactionView_OnChangeTypeTransaction;
        }

        private void SingleTransactionViewOnOnLoad()
        {
            _singleTransactionView.AddTypeTransactionUserControl(_typeTransactionUcPresenter.GetUserControlView());
            _singleTransactionView.AddNameTransactionUserControl(_nameTransactionUcPresenter.GetUserControlView());
        }

        private void _singleTransactionView_OnChangeTypeTransaction(int transactionType)
        {
        }

        private void SingleTransactionViewOnAdd(object sender, EventArgs e)
        {
            SingleTransactionDTO dto = _singleTransactionView.GetTransactionInfo();
            _singleTransactionServices.Add(dto);
        }

        public ISingleTransactionView GetView()
        {
            return _singleTransactionView;
        }
    }
}