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
using FM.SHDML.Core.Models.Dtos.UIDto;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Presenters.ViewPresenters
{
    public class MainPresenter : IMainPresenter
    {
        private IMainView _mainView;

        private IServiceProvider _serviceProvider;

        private readonly SettingServices<SystemSettingsServices> _systemSettings;
        private readonly IAccountServices _accountServices;
        private readonly IAccountSummaryUCPresenter _accountSummaryUcPresenter;

        private List<RecentOpenFilesDto> RecentOpenFilesDto { get; set; }

        public MainPresenter(
            IServiceProvider serviceProvider,
            SettingServices<SystemSettingsServices> systemSettings,
            IMainView mainView)
        {
            _mainView = mainView;
            _serviceProvider = serviceProvider;
            _systemSettings = systemSettings;

            _mainView.OnLoadView += MainViewOnOnLoadView;
            _mainView.OpenDataFile += MainViewOnOpenDataFile;
            _mainView.AddTransaction += MainViewOnAddTransaction;
            _mainView.AddAccount += MainViewOnAddAccount;
        }

        private void LoadRecentOpenFiles()
        {
            if (RecentOpenFilesDto.Count == 0)
                return;

            _mainView.SetVisibleRecentOpenMenuItem(true);
            _mainView.AddElementInRecentOpenItems(RecentOpenFilesDto);
        }


        private void MainViewOnOpenDataFile(string filePath)
        {
            var recentOpens = _systemSettings.Extract().RecentOpen;
            var fileName = Path.GetFileName(filePath);
            var recentOpenItem = new RecentOpenFilesDto()
            {
                FileName = fileName,
                FilePath = filePath
            };

            if (recentOpens.Count != 0)
            {
                if (recentOpens.Count == 3)
                {
                    var findElement = recentOpens.Where(x => x.FileName == fileName && x.FilePath == filePath);
                    if (findElement.Any())
                    {
                        recentOpens.Remove(findElement.First());
                        recentOpens.Add(recentOpenItem);
                    }
                    else
                    {
                        recentOpens.Remove(recentOpens.Last());
                        recentOpens.Add(recentOpenItem);
                    }
                }
                else
                {
                    if (!recentOpens.Contains(recentOpenItem))
                    {
                        recentOpens.Add(recentOpenItem);
                    }
                }
            }
            else
            {
                recentOpens.Add(new RecentOpenFilesDto()
                {
                    FileName = fileName,
                    FilePath = filePath
                });
            }

            _mainView.SetVisibleRecentOpenMenuItem(true);
            _mainView.AddElementInRecentOpenItems(recentOpens);
            _systemSettings.Save();
        }

        private void MainViewOnOnLoadView()
        {
            RecentOpenFilesDto = _systemSettings.Extract().RecentOpen;
            LoadRecentOpenFiles();

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