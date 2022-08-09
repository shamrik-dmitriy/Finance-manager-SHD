using FM.SHD.Presenters.Interfaces;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using System;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Services.Repositories;
using FM.SHD.Services.SingleTransactionServices;
using FM.SHD.Services.TypeTransactionService;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Presenters.UserControlPresenters
{
    public class SelectTypeTransactionUserControlPresenter : ISelectTypeTransactionUserControlPresenter
    {
        private readonly ISelectTypeTransactionUserControlView _selectTypeTransactionUserControlView;
        private readonly ITypeTransactionServices _typeTransactionServices;
        private readonly ITypeTransactionRepository _typeTransactionRepository;

        public SelectTypeTransactionUserControlPresenter(
            ISelectTypeTransactionUserControlView selectTypeTransactionUserControlView,
            ITypeTransactionServices typeTransactionServices, ITypeTransactionRepository typeTransactionRepository)
        {
            _selectTypeTransactionUserControlView = selectTypeTransactionUserControlView;
            _typeTransactionServices = typeTransactionServices;
            _typeTransactionRepository = typeTransactionRepository;

            _selectTypeTransactionUserControlView.LoadUserControl +=
                SelectTypeTransactionUserControlViewOnLoadUserControl;
        }

        private void SelectTypeTransactionUserControlViewOnLoadUserControl()
        {
            _selectTypeTransactionUserControlView.SetTransactionTypes(_typeTransactionServices.GetAll());
        }


        public ISelectTypeTransactionUserControlView GetSelectTypeTransactionUserControlView()
        {
            return _selectTypeTransactionUserControlView;
        }
    }
}