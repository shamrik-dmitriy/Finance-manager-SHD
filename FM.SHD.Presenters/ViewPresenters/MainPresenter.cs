using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FM.SHD.Infastructure.Impl.Repositories;
using FM.SHD.Infastructure.Impl.Repositories.Specific.Account;
using FM.SHD.Infastructure.Impl.Repositories.Specific.Transaction;
using FM.SHD.Presenters.Common;
using FM.SHD.Presenters.Interfaces.UserControls.Main;
using FM.SHD.Presenters.Interfaces.UserControls.Wallet;
using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHD.Services.AccountServices;
using FM.SHD.Services.CommonServices;
using FM.SHD.Services.TransactionServices;
using FM.SHD.Settings.Services;
using FM.SHD.Settings.Services.SettingsCollection;
using FM.SHDML.Core.Models.Dtos.UIDto;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Presenters.ViewPresenters
{
    public class MainPresenter : BasePresenter<IMainView>
    {
        #region Private member variables

        private readonly IMainView _view;
        private readonly IServiceProvider _serviceProvider;
        private readonly IRepositoryManager _repositoryManager;
        private readonly SettingServices<SystemRecentOpenFilesSettings> _recentOpenFilesSettings;

        private List<RecentOpenFilesDto> RecentOpenFilesDtos { get; set; }
        private IAccountServices _accountServices;
        private ITransactionServices _transactionServices;

        #endregion

        #region Constructor / Destructor

        public MainPresenter(
            IMainView view,
            IServiceProvider serviceProvider,
            SettingServices<SystemRecentOpenFilesSettings> settingServices,
            IRepositoryManager repositoryManager)
            : base(view)
        {
            _view = view;
            _serviceProvider = serviceProvider;
            _repositoryManager = repositoryManager;
            _recentOpenFilesSettings = settingServices;
            
            _view.OnLoadView += OnLoadView;
            _view.OpenDataFile += OnOpenDataFile;
            _view.AddTransaction += OnAddTransaction;
            _view.AddAccount += OnAddAccount;
        }

        ~MainPresenter()
        {
            _view.OnLoadView -= OnLoadView;
            _view.OpenDataFile -= OnOpenDataFile;
            _view.AddTransaction -= OnAddTransaction;
            _view.AddAccount -= OnAddAccount;
        }

        #endregion

        private void OnAddAccount()
        {
            var accountPresenter = _serviceProvider.GetRequiredService<AccountPresenter>();
            accountPresenter.SetTitle("Добавить счёт");
            accountPresenter.Run(null);
        }

        private void OnAddTransaction()
        {
            var transactionPresenter = _serviceProvider.GetRequiredService<TransactionPresenter>();
            transactionPresenter.SetTitle("Добавить операцию");
            transactionPresenter.Run(null);
        }

        private void OnOpenDataFile(string filePath)
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

            _view.AddElementInRecentOpenItems(RecentOpenFilesDtos);

            _recentOpenFilesSettings.GetSetting().RecentOpen =
                RecentOpenFilesDtos.Select(x => (x.FileName, x.FilePath)).ToList();
            _recentOpenFilesSettings.Save();

            _view.SetViewOnActiveUI();
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

        private void OnLoadView()
        {
            var isLoad = LoadListRecentOpenFiles();

            if (isLoad)
            {
                _view.SetViewOnActiveUI();

                CreateConnection(_recentOpenFilesSettings.GetSetting().RecentOpen.Last().FilePath);
                _accountServices = new AccountServices(new AccountRepository(_repositoryManager), new ModelValidator());
                var data = new List<IAccountSummaryUCPresenter>();
                foreach (var accountDto in _accountServices.GetAll()
                             .Select((value, index) => new { Index = index, Value = value }))
                {
                    var s = _serviceProvider.GetRequiredService<IAccountSummaryUCPresenter>();
                    s.GetUserControlView().SetData(accountDto.Value);
                    data.Add(s);
                    _view.AddAccountsSummaryUserControl(s.GetUserControlView());
                }

                _transactionServices =
                    new TransactionServices(new TransactionRepository(_repositoryManager),
                        new ModelValidator());
                
                var dgv = _serviceProvider.GetRequiredService<IAllTransactionUCPresenter>();
                _view.AddUserControl(dgv.GetUserControlView());
                dgv.GetUserControlView().SetData(_transactionServices.GetExtendedTransactions());
            }
            else
            {
                _view.SetViewOnUnActiveUI();
            }

            _view.SetVisibleUserLoginInfo(false);

            /*
             * 1. Следует проверить, зашифрован ли открываемый файл.
             *  1.1 Если файл зашифрован - вызываем форму логина. После успешного логина  _mainView.SetVisibleUserLoginInfo(true);
             *  1.2 Если файл не зашифрован -  _mainView.SetVisibleUserLoginInfo(false);
             * 2. Нужно загрузить все данные из файла - добавить методы на загрузку того, что лежит на главной форме - операции, кошельки, информация о пользователе 
             */
            // _mainView.SetAccountsData(_accountServices.GetAll());
        }

        #region Public Methods

        public override void SetTitle(string title)
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            View.Show();
        }

        #endregion

        #region Private methods

        private bool LoadListRecentOpenFiles()
        {
            RecentOpenFilesDtos = _recentOpenFilesSettings.GetSetting().RecentOpen
                .Select(x => new RecentOpenFilesDto()
                {
                    FileName = x.FileName, FilePath = x.FilePath
                }).ToList();

            if (RecentOpenFilesDtos.Count == 0)
                return false;

            _view.AddElementInRecentOpenItems(RecentOpenFilesDtos);
            return true;
        }

        #endregion
    }
}