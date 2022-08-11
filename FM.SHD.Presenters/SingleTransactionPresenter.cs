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
        private readonly ICategoryTransactionUCPresenter _categoryTransactionUcPresenter;
        private readonly IContrAgentUCPresenter _contrAgentUcPresenter;
        private readonly IFamilyMemberUCPresenter _familyMemberUcPresenter;
        private readonly IAddCancelButtonsUCPresenter _addCancelButtonsUcPresenter;

        public SingleTransactionPresenter(
            IServiceProvider serviceProvider,
            ISingleTransactionView singleTransactionView,
            ISingleTransactionServices singleTransactionServices,
            ITypeTransactionUCPresenter typeTransactionUcPresenter,
            INameTransactionUCPresenter nameTransactionUcPresenter,
            IDescriptionTransactionUCPresenter descriptionTransactionUcPresenter,
            IAccountsInfoTransactionUCPresenter accountsInfoTransactionUcPresenter,
            ICategoryTransactionUCPresenter categoryTransactionUcPresenter,
            IContrAgentUCPresenter contrAgentUcPresenter,
            IFamilyMemberUCPresenter familyMemberUcPresenter,
            IAddCancelButtonsUCPresenter addCancelButtonsUcPresenter)
        {
            _singleTransactionView = singleTransactionView;
            _singleTransactionServices = singleTransactionServices;
            _typeTransactionUcPresenter = typeTransactionUcPresenter;
            _nameTransactionUcPresenter = nameTransactionUcPresenter;
            _descriptionTransactionUcPresenter = descriptionTransactionUcPresenter;
            _accountsInfoTransactionUcPresenter = accountsInfoTransactionUcPresenter;
            _categoryTransactionUcPresenter = categoryTransactionUcPresenter;
            _contrAgentUcPresenter = contrAgentUcPresenter;
            _familyMemberUcPresenter = familyMemberUcPresenter;
            _addCancelButtonsUcPresenter = addCancelButtonsUcPresenter;
            _serviceProvider = serviceProvider;
            _singleTransactionView.OnLoadEventrsss += SingleTransactionViewOnOnLoad;
        }

        private void SingleTransactionViewOnOnLoad()
        {
            _singleTransactionView.AddTypeTransactionUserControl(_typeTransactionUcPresenter.GetUserControlView());
            _singleTransactionView.AddNameTransactionUserControl(_nameTransactionUcPresenter.GetUserControlView());
            _singleTransactionView.AddDescriptionTransactionUserControl(_descriptionTransactionUcPresenter
                .GetUserControlView());
            _singleTransactionView.AddHorizontalLine();
            _singleTransactionView.AddAccountsInfoTransactionUserControl(_accountsInfoTransactionUcPresenter
                .GetUserControlView());
            _singleTransactionView.AddHorizontalLine();
            _singleTransactionView.AddCategoryTransactionUserControl(
                _categoryTransactionUcPresenter.GetUserControlView());
            _singleTransactionView.AddContrAgentUserControl(_contrAgentUcPresenter.GetUserControlView());
            _singleTransactionView.AddFamilyMemberUserControl(_familyMemberUcPresenter.GetUserControlView());
            _singleTransactionView.AddAddCancelButtonsUserControl(_addCancelButtonsUcPresenter.GetUserControlView());
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