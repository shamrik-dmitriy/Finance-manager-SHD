using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FM.SHD.Presenters.Interfaces.UserControls.Wallet;
using FM.SHD.Presenters.Interfaces.Views;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Services;
using FM.SHD.Services.AccountServices;
using FM.SHD.Settings.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Presenters.ViewPresenters
{
    public class MainPresenter : IMainPresenter
    {
        private IMainView _mainView;
        private IServiceProvider _serviceProvider;
        private readonly ISettingServices _settingServices;
        private readonly IAccountServices _accountServices;
        private readonly IAccountSummaryUCPresenter _accountSummaryUcPresenter;

        public MainPresenter(
            IServiceProvider serviceProvider,
            ISettingServices settingServices, 
            //   IAccountServices accountServices,
            //   IAccountSummaryUCPresenter accountSummaryUcPresenter,
            IMainView mainView)
        {
            _mainView = mainView;
            _serviceProvider = serviceProvider;
            _settingServices = settingServices;
            //_accountServices = accountServices;
            //_accountSummaryUcPresenter = accountSummaryUcPresenter;

            _mainView.OnLoadView += MainViewOnOnLoadView;
            _mainView.OpenDataFile += MainViewOnOpenDataFile;
            _mainView.AddTransaction += MainViewOnAddTransaction;
            _mainView.AddAccount += MainViewOnAddAccount;
        }

        private void MainViewOnOpenDataFile(string filePath)
        {
            var recentFiles = _settingServices.GetRecentOpenFiles();
            if (recentFiles.Count == 10)
            {
                if (recentFiles.Contains((Path.GetFileName(filePath), filePath)))
                {
                    var index = recentFiles.FindIndex(a => a.FileName == Path.GetFileName(filePath) && a.FilePath == filePath);
                    (recentFiles[index], recentFiles[0]) = (recentFiles[0], recentFiles[index]);
                }
            }

            if (!recentFiles.Contains((Path.GetFileName(filePath), filePath)))
            {
                recentFiles.Add((Path.GetFileName(filePath), filePath));
            }
            else
            {
                var index = recentFiles.FindIndex(a => a.FileName == Path.GetFileName(filePath) && a.FilePath == filePath);
                (recentFiles[index], recentFiles[0]) = (recentFiles[0], recentFiles[index]);
            }
            _settingServices.Save();
        }

        private void MainViewOnOnLoadView()
        {
            /*if (_recentOpenOptions.Value.RecentOpen == null)
                _mainView.SetViewOnUnCompleteLoadData();*/

            // TODO: Вызывать тут код для авторизации, опять таки
            // TODO: проверить, есть ли пароль. Если пароль есть - вызвать форму авторизации
            // TODO: иначе просто загрузить базу
            // TODO: Написать код по добавлению репозиториев 
            // TODO: после того как загрузилась система
            //foreach (var accountDto in _accountServices.GetAll())
            //{
            //    _mainView.AddAccountsSummaryUserControl(_accountSummaryUcPresenter.GetUserControlView(accountDto));
            //}

            // _mainView.SetAccountsData(_accountServices.GetAll());
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

        public IMainView GetView()
        {
            return _mainView;
        }
    }
}