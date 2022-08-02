using System;
using FM.SHD.Presenters.Interfaces;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Services.SingleTransactionServices;
using Microsoft.Extensions.DependencyInjection;
using SHDML.BLL.DTO.DTO;

namespace FM.SHD.Presenters
{
    public class SingleTransactionPresenter : ISingleTransactionPresenter
    {
        private ISingleTransactionView _singleTransactionView;
        private IServiceProvider _serviceProvider;
        private ISingleTransactionServices _singleTransactionServices;
        private ISingleTransactionRepository _singleTransactionRepository;
        
        public SingleTransactionPresenter(IServiceProvider serviceProvider, ISingleTransactionView singleTransactionView, ISingleTransactionServices singleTransactionServices, ISingleTransactionRepository singleTransactionRepository)
        {
            _singleTransactionView = singleTransactionView;
            _singleTransactionServices = singleTransactionServices;
            _serviceProvider = serviceProvider;
            _singleTransactionRepository = singleTransactionRepository;
            
            _singleTransactionView.Add += SingleTransactionViewOnAdd;
        }

        private void SingleTransactionViewOnAdd(object sender, EventArgs e)
        {
            SingleTransactionDTO dto =  _singleTransactionView.GetTransactionInfo();
        }

        public ISingleTransactionView GetView()
        {
            return _singleTransactionView;
        }
    }
}