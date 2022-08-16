using System;
using FM.SHD.Presenters.Interfaces;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.Interfaces.Views;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Services.SingleTransactionServices;
using SHDML.BLL.DTO.DTO;

namespace FM.SHD.Presenters.ViewPresenters
{
    public class SingleTransactionPresenter : ISingleTransactionPresenter
    {
        private ISingleTransactionView _singleTransactionView;
        private ISingleTransactionServices _singleTransactionServices;
        private readonly ITypeTransactionUCPresenter _typeTransactionUcPresenter;
        private readonly INameUCPresenter _nameUcPresenter;
        private readonly IDescriptionUCPresenter _descriptionUcPresenter;
        private readonly IAccountsInfoTransactionUCPresenter _accountsInfoTransactionUcPresenter;
        private readonly ICategoryUCPresenter _categoryUcPresenter;
        private readonly IContrAgentUCPresenter _contrAgentUcPresenter;
        private readonly IIdentityUCPresenter _identityUcPresenter;
        private readonly IAddCancelButtonsUCPresenter _addCancelButtonsUcPresenter;

        public SingleTransactionPresenter(
            ISingleTransactionView singleTransactionView,
            ISingleTransactionServices singleTransactionServices,
            ITypeTransactionUCPresenter typeTransactionUcPresenter,
            INameUCPresenter nameUcPresenter,
            IDescriptionUCPresenter descriptionUcPresenter,
            IAccountsInfoTransactionUCPresenter accountsInfoTransactionUcPresenter,
            ICategoryUCPresenter categoryUcPresenter,
            IContrAgentUCPresenter contrAgentUcPresenter,
            IIdentityUCPresenter identityUcPresenter,
            IAddCancelButtonsUCPresenter addCancelButtonsUcPresenter)
        {
            _singleTransactionView = singleTransactionView;
            _singleTransactionServices = singleTransactionServices;

            _typeTransactionUcPresenter = typeTransactionUcPresenter;
            _nameUcPresenter = nameUcPresenter;
            _descriptionUcPresenter = descriptionUcPresenter;
            _accountsInfoTransactionUcPresenter = accountsInfoTransactionUcPresenter;
            _categoryUcPresenter = categoryUcPresenter;
            _contrAgentUcPresenter = contrAgentUcPresenter;
            _identityUcPresenter = identityUcPresenter;
            _addCancelButtonsUcPresenter = addCancelButtonsUcPresenter;

            _singleTransactionView.OnLoadView += SingleTransactionViewOnOnLoad;
        }

        private void SingleTransactionViewOnOnLoad()
        {
            _singleTransactionView.AddUserControl(_typeTransactionUcPresenter.GetUserControlView());
            _singleTransactionView.AddUserControl(_nameUcPresenter.GetUserControlView());
            _singleTransactionView.AddUserControl(_descriptionUcPresenter
                .GetUserControlView());
            _singleTransactionView.AddHorizontalLine();
            _singleTransactionView.AddUserControl(_accountsInfoTransactionUcPresenter
                .GetUserControlView());
            _singleTransactionView.AddHorizontalLine();
            _singleTransactionView.AddUserControl(
                _categoryUcPresenter.GetUserControlView());
            _singleTransactionView.AddUserControl(_contrAgentUcPresenter.GetUserControlView());
            _singleTransactionView.AddUserControl(_identityUcPresenter.GetUserControlView());
            _singleTransactionView.AddUserControl(_addCancelButtonsUcPresenter.GetUserControlView());
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