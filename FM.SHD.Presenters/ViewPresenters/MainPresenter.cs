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

        private bool LoadListRecentOpenFiles()
        {
            RecentOpenFilesDtos = _recentOpenFilesSettings.GetSetting().RecentOpen
                .Select(x => new RecentOpenFilesDto()
                {
                    FileName = x.FileName, FilePath = x.FilePath
                }).ToList();

            if (RecentOpenFilesDtos.Count == 0)
                return false;

            _mainView.AddElementInRecentOpenItems(RecentOpenFilesDtos);
            return true;
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
                if (RecentOpenFilesDtos.Count == 5)
                {
                    if (!IsFindAndReplaceRecentOpenFile(filePath, fileName, recentOpenItem))
                    {
                        RecentOpenFilesDtos.Remove(RecentOpenFilesDtos.Last());
                        RecentOpenFilesDtos.Add(recentOpenItem);
                    }
                }
                else
                {
                    if (!IsFindAndReplaceRecentOpenFile(filePath, fileName, recentOpenItem))
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

            _mainView.SetViewOnActiveUI();
            CreateConnection(filePath);
        }

        private bool IsFindAndReplaceRecentOpenFile(string filePath, string fileName, RecentOpenFilesDto recentOpenItem)
        {
            var findElement = RecentOpenFilesDtos.Where(x => x.FileName == fileName && x.FilePath == filePath);
            if (!findElement.Any()) return false;
            RecentOpenFilesDtos.Remove(findElement.First());
            RecentOpenFilesDtos.Add(recentOpenItem);
            return true;
        }


        private void CreateConnection(string filePath)
        {
            _repositoryManager.ConfigureConnection($"DataSource={filePath}");
            _repositoryManager.CreateConnection();
        }

        private void MainViewOnOnLoadView()
        {
            var isLoad = LoadListRecentOpenFiles();

            if (isLoad)
            {
                _mainView.SetViewOnActiveUI();

                CreateConnection(_recentOpenFilesSettings.GetSetting().RecentOpen.Last().FilePath);
            }
            else
            {
                _mainView.SetViewOnUnActiveUI();
            }

            _mainView.SetVisibleUserLoginInfo(false);

            /*
             * 1. Следует проверить, зашифрован ли открываемый файл.
             *  1.1 Если файл зашифрован - вызываем форму логина. После успешного логина  _mainView.SetVisibleUserLoginInfo(true);
             *  1.2 Если файл не зашифрован -  _mainView.SetVisibleUserLoginInfo(false);
             * 2. Нужно загрузить все данные из файла - добавить методы на загрузку того, что лежит на главной форме - операции, кошельки, информация о пользователе 
             */
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