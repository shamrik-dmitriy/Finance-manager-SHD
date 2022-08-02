using System;
using FM.SHD.Presenters.Interfaces;
using FM.SHD.Presenters.IntrefacesViews;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Presenters
{
    public class SingleTransactionPresenter : ISingleTransactionPresenter
    {
        private ISingleTransactionView _singleTransactionView;
        private IServiceProvider _serviceProvider;
        
        public SingleTransactionPresenter(IServiceProvider serviceProvider, ISingleTransactionView singleTransactionView)
        {
            _singleTransactionView = singleTransactionView;
            _serviceProvider = serviceProvider;
        }

        private void MainViewOnAddTransaction(object sender, EventArgs e)
        {
            _serviceProvider.GetRequiredService<MainPresenter>();
            // new SingleTransactionForm("Добавить операцию").ShowDialog();
        }

        public ISingleTransactionView GetView()
        {
            return _singleTransactionView;
        }
    }
}