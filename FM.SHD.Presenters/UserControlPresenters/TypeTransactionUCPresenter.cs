using FM.SHD.Presenters.Interfaces;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using System;
using FM.SHD.Presenters.Interfaces.UserControls;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Services.Repositories;
using FM.SHD.Services.SingleTransactionServices;
using FM.SHD.Services.TypeTransactionService;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Presenters.UserControlPresenters
{
    public class TypeTransactionUCPresenter : ITypeTransactionUCPresenter
    {
        private readonly ITypeTransactionUCView _typeTransactionUcView;
        private readonly ITypeTransactionServices _typeTransactionServices;
        private readonly ITypeTransactionRepository _typeTransactionRepository;

        public TypeTransactionUCPresenter(
            ITypeTransactionUCView typeTransactionUcView,
            ITypeTransactionServices typeTransactionServices, ITypeTransactionRepository typeTransactionRepository)
        {
            _typeTransactionUcView = typeTransactionUcView;
            _typeTransactionServices = typeTransactionServices;
            _typeTransactionRepository = typeTransactionRepository;
        }

        private void TypeTransactionUserControlViewOnLoadUserControl()
        {
            _typeTransactionUcView.LoadTransactionTypes(_typeTransactionServices.GetAll());
        }


        [Obsolete]
        public ITypeTransactionUCView GetSelectTypeTransactionUserControlView()
        {
            return _typeTransactionUcView;
        }

        public ITypeTransactionUCView GetUserControlView()
        {
            return _typeTransactionUcView;
        }
    }
}