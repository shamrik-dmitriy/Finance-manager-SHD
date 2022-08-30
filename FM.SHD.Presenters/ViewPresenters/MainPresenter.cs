using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FM.SHD.Infastructure.Impl.Repositories;
using FM.SHD.Infastructure.Impl.Repositories.Specific.SingleTransaction;
using FM.SHD.Presenters.Interfaces.UserControls.Wallet;
using FM.SHD.Presenters.Interfaces.Views;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Services.AccountServices;
using FM.SHD.Services.Repositories;
using FM.SHD.Services.SingleTransactionServices;
using FM.SHD.Settings.Services;
using FM.SHD.Settings.Services.SettingsCollection;
using FM.SHDML.Core.Models.Dtos.UIDto;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Presenters.ViewPresenters
{
    public class MainPresenter : IMainPresenter
    {
        private IMainView _mainView;
        private readonly IRepositoryManager _repositoryManager;

        private IServiceProvider _serviceProvider;

        private readonly SettingServices<SystemRecentOpenFilesSettings> _recentOpenFilesSettings;
        private readonly IAccountServices _accountServices;
        private readonly IAccountSummaryUCPresenter _accountSummaryUcPresenter;

        public MainPresenter(
            IServiceProvider serviceProvider,
            SettingServices<SystemRecentOpenFilesSettings> recentOpenFilesSettings,
            IMainView mainView,
            IRepositoryManager repositoryManager)
        {
            _mainView = mainView;
            _repositoryManager = repositoryManager;
            _serviceProvider = serviceProvider;
            _recentOpenFilesSettings = recentOpenFilesSettings;

            _mainView.OnLoadView += MainViewOnOnLoadView;
            _mainView.OpenDataFile += MainViewOnOpenDataFile;
            _mainView.AddTransaction += MainViewOnAddTransaction;
            _mainView.AddAccount += MainViewOnAddAccount;
        }

        private List<RecentOpenFilesDto> RecentOpenFilesDtos { get; set; }

        private void LoadListRecentOpenFiles()
        {
            RecentOpenFilesDtos = _recentOpenFilesSettings.GetSetting().RecentOpen
                .Select(x => new RecentOpenFilesDto()
                {
                    FileName = x.FileName, FilePath = x.FilePath
                }).ToList();

            if (RecentOpenFilesDtos.Count == 0)
                return;

            _mainView.AddElementInRecentOpenItems(RecentOpenFilesDtos);
        }

        private void MainViewOnOpenDataFile(string filePath)
        {
            var fileName = Path.GetFileName(filePath);
            var recentOpenItem = new RecentOpenFilesDto()
            {
                FileName = fileName,
                FilePath = filePath
            };

            if (RecentOpenFilesDtos.Count != 0)
            {
                if (RecentOpenFilesDtos.Count == 3)
                {
                    var findElement = RecentOpenFilesDtos.Where(x => x.FileName == fileName && x.FilePath == filePath);
                    if (findElement.Any())
                    {
                        RecentOpenFilesDtos.Remove(findElement.First());
                        RecentOpenFilesDtos.Add(recentOpenItem);
                    }
                    else
                    {
                        RecentOpenFilesDtos.Remove(RecentOpenFilesDtos.Last());
                        RecentOpenFilesDtos.Add(recentOpenItem);
                    }
                }
                else
                {
                    if (!RecentOpenFilesDtos.Contains(recentOpenItem))
                    {
                        RecentOpenFilesDtos.Add(recentOpenItem);
                    }
                }
            }
            else
            {
                RecentOpenFilesDtos.Add(recentOpenItem);
            }

            _mainView.AddElementInRecentOpenItems(RecentOpenFilesDtos);

            _recentOpenFilesSettings.GetSetting().RecentOpen =
                RecentOpenFilesDtos.Select(x => (x.FileName, x.FilePath)).ToList();
            _recentOpenFilesSettings.Save();

            CreateConnection(filePath);
        }

        private void CreateConnection(string filePath)
        {
            _repositoryManager.ConfigureConnection($"DataSource={filePath}");
            _repositoryManager.CreateConnection();
        }

        private void MainViewOnOnLoadView()
        {
            LoadListRecentOpenFiles();

            /*  if (_recentOpenFilesSettings.GetSetting().RecentOpen.Count != 0)
              {
                    CreateConnection($"DataSource={_recentOpenFilesSettings.GetSetting().RecentOpen.Last().FilePath}");
              }*/

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