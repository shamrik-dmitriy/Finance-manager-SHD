using System;
using FM.SHD.Presenters.Interfaces.UserControls.Wallet;
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
        private readonly IAccountSummaryUCPresenter _accountSummaryUcPresenter;

        public MainPresenter(
            IServiceProvider serviceProvider,
            //   IAccountServices accountServices,
            //   IAccountSummaryUCPresenter accountSummaryUcPresenter,
            IMainView mainView)
        {
            _mainView = mainView;
            _serviceProvider = serviceProvider;
            //_accountServices = accountServices;
            //_accountSummaryUcPresenter = accountSummaryUcPresenter;

            _mainView.OnLoadView += MainViewOnOnLoadView;
            _mainView.OpenDataFile += MainViewOnOpenDataFile;
            _mainView.AddTransaction += MainViewOnAddTransaction;
            _mainView.AddAccount += MainViewOnAddAccount;
        }

        private void MainViewOnOpenDataFile(string filePath)
        {
            
         /*   _recentOpenOptions.Value.RecentOpen ??= new Dictionary<string, string>();

            if (_recentOpenOptions.Value.RecentOpen.Count == 10)
            {
                _recentOpenOptions.Value.RecentOpen.Remove(_recentOpenOptions.Value.RecentOpen.First().Key);
            }

            if (_recentOpenOptions.Value.RecentOpen.ContainsKey(Path.GetFileName(filePath)) &&
                _recentOpenOptions.Value.RecentOpen.ContainsValue(filePath))
            {
                
            }
            else
            {
                _recentOpenOptions.Value.RecentOpen.Add(Path.GetFileName(filePath), filePath);
            }
            
            var jsonWriteOptions = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            jsonWriteOptions.Converters.Add(new JsonStringEnumConverter());

            var newJson = JsonSerializer.Serialize(_recentOpenOptions, jsonWriteOptions);
            
            var appSettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            File.WriteAllText(appSettingsPath, newJson);*/
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