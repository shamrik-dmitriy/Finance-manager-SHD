using System;
using System.Collections.Generic;
using FM.SHD.Presenters.Interfaces;
using FM.SHD.Presenters.Interfaces.Views;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Services.AccountServices;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Presenters.ViewPresenters
{
    public class MainPresenter : IMainPresenter
    {
        private IMainView _mainView;
        private IServiceProvider _serviceProvider;
        private readonly IAccountServices _accountServices;

        public MainPresenter(
            IServiceProvider serviceProvider,
            IAccountServices accountServices,
            IMainView mainView)
        {
            _mainView = mainView;
            _serviceProvider = serviceProvider;
            _accountServices = accountServices;

            _mainView.OnLoadView += MainViewOnOnLoadView;
            _mainView.AddTransaction += MainViewOnAddTransaction;
            _mainView.AddAccount += MainViewOnAddAccount;
        }

        private void MainViewOnOnLoadView()
        {
            _mainView.SetAccountsData(_accountServices.GetAll());
        }

        private void MainViewOnAddAccount()
        {
            var accountPresenter = _serviceProvider.GetRequiredService<AccountPresenter>();
            var view = accountPresenter.GetView();
            view.ShowDialog("Добавить счёт");
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