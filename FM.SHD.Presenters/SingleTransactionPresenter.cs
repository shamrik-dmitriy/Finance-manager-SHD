using System;
using FM.SHD.Presenters.Interfaces;
using FM.SHD.Presenters.Interfaces.UserControls;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Services.Repositories;
using FM.SHD.Services.SingleTransactionServices;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;
using Microsoft.Extensions.DependencyInjection;
using SHDML.BLL.DTO.DTO;

namespace FM.SHD.Presenters
{
    public class SingleTransactionPresenter : ISingleTransactionPresenter
    {
        private ISingleTransactionView _singleTransactionView;
        private IServiceProvider _serviceProvider;
        private ISingleTransactionServices _singleTransactionServices;
        private readonly ITypeTransactionUCPresenter _typeTransactionUcPresenter;
        private readonly INameTransactionUCPresenter _nameTransactionUcPresenter;
        private readonly IDescriptionTransactionUCPresenter _descriptionTransactionUcPresenter;
        private readonly IAccountsInfoTransactionUCPresenter _accountsInfoTransactionUcPresenter;

        public SingleTransactionPresenter(
            IServiceProvider serviceProvider,
            ISingleTransactionView singleTransactionView,
            ISingleTransactionServices singleTransactionServices,
            ITypeTransactionUCPresenter typeTransactionUcPresenter,
            INameTransactionUCPresenter nameTransactionUcPresenter,
            IDescriptionTransactionUCPresenter descriptionTransactionUcPresenter,
            IAccountsInfoTransactionUCPresenter accountsInfoTransactionUcPresenter)
        {
            _singleTransactionView = singleTransactionView;
            _singleTransactionServices = singleTransactionServices;
            _typeTransactionUcPresenter = typeTransactionUcPresenter;
            _nameTransactionUcPresenter = nameTransactionUcPresenter;
            _descriptionTransactionUcPresenter = descriptionTransactionUcPresenter;
            _accountsInfoTransactionUcPresenter = accountsInfoTransactionUcPresenter;
            _serviceProvider = serviceProvider;
            _singleTransactionView.OnLoadEventrsss += SingleTransactionViewOnOnLoad;
        }

        private void SingleTransactionViewOnOnLoad()
        {
            _singleTransactionView.AddTypeTransactionUserControl(_typeTransactionUcPresenter.GetUserControlView());
            _singleTransactionView.AddNameTransactionUserControl(_nameTransactionUcPresenter.GetUserControlView());
            _singleTransactionView.AddDescriptionTransactionUserControl(_descriptionTransactionUcPresenter.GetUserControlView());
            _singleTransactionView.AddHorizontalLine();
            _singleTransactionView.AddAccountsInfoTransactionUserControl(_accountsInfoTransactionUcPresenter.GetUserControlView());
            _singleTransactionView.AddHorizontalLine();
        }

        private void _singleTransactionView_OnChangeTypeTransaction(int transactionType)
        {
        }

        private void SingleTransactionViewOnAdd(object sender, EventArgs e)
        {
            SingleTransactionDTO dto = _singleTransactionView.GetTransactionInfo();
            _singleTransactionServices.Add(dto);
        }

        public ISingleTransactionView GetView()
        {
            return _singleTransactionView;
        }
    }
}