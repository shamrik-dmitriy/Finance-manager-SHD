using System;
using FM.SHD.Presenters.Interfaces;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Services.SingleTransactionServices;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Presenters
{
    public class SingleTransactionPresenter : ISingleTransactionPresenter
    {
        private ISingleTransactionView _singleTransactionView;
        private IServiceProvider _serviceProvider;
        private ISingleTransactionServices _singleTransactionServices;
        
        public SingleTransactionPresenter(IServiceProvider serviceProvider, ISingleTransactionView singleTransactionView, ISingleTransactionServices singleTransactionServices)
        {
            _singleTransactionView = singleTransactionView;
            _singleTransactionServices = singleTransactionServices;
            _serviceProvider = serviceProvider;
            
            //_singleTransactionView.
        }

        public ISingleTransactionView GetView()
        {
            return _singleTransactionView;
        }
    }
}