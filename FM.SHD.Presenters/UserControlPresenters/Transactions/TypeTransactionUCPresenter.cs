﻿using System;
using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using FM.SHD.Services.ComponentsServices.TypeTransactionService;
using FM.SHD.Services.Repositories;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
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