using System;
using FM.SHD.Presenters.Interfaces;
using FM.SHD.Presenters.IntrefacesViews;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private IMainView _mainView;
        private IServiceProvider _serviceProvider;

        public MainPresenter(IServiceProvider serviceProvider, IMainView mainView)
        {
            _mainView = mainView;
            _serviceProvider = serviceProvider;
            _mainView.AddTransaction += MainViewOnAddTransaction;
        }

        private void MainViewOnAddTransaction()
        {
            var singleTransactionPresenter = _serviceProvider.GetRequiredService<SingleTransactionPresenter>();
            var view = singleTransactionPresenter.GetView();
            view.ShowDialog("Добавить операцию");
        }

        public IMainView GetMainView()
        {
            return _mainView;
        }
    }
}