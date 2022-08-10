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
        private readonly ITypeTransactionUserControlView _typeTransactionUserControlView;
        private readonly ITypeTransactionServices _typeTransactionServices;
        private readonly ITypeTransactionRepository _typeTransactionRepository;

        public SelectTypeTransactionUserControlPresenter(
            ITypeTransactionUserControlView typeTransactionUserControlView,
            ITypeTransactionServices typeTransactionServices, ITypeTransactionRepository typeTransactionRepository)
        {
            _typeTransactionUserControlView = typeTransactionUserControlView;
            _typeTransactionServices = typeTransactionServices;
            _typeTransactionRepository = typeTransactionRepository;

            _typeTransactionUserControlView.LoadUserControl +=
                TypeTransactionUserControlViewOnLoadUserControl;
        }

        private void TypeTransactionUserControlViewOnLoadUserControl()
        {
            _typeTransactionUserControlView.SetTransactionTypes(_typeTransactionServices.GetAll());
        }


        public ITypeTransactionUserControlView GetSelectTypeTransactionUserControlView()
        {
            return _typeTransactionUserControlView;
        }
    }
}