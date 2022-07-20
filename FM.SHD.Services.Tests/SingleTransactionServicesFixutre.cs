using FM.SHD.Services.CommonServices;
using FM.SHD.Services.SingleTransactionServices;
using FM.SHDML.Core.Models.TransactionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Services.Tests
{
    public class SingleTransactionServicesFixutre
    {
        private ISingleTransactionServices _singleTransactionServices;
        private ISingleTransactionModel _singleTransactionModel;

        public SingleTransactionServicesFixutre()
        {
            _singleTransactionModel = new SingleTransactionModel();
            _singleTransactionServices = new SingleTransactionServices.SingleTransactionServices(null, new ModelValidator());
        }

        public SingleTransactionModel SingleTransactionModel
        {
            get => (SingleTransactionModel)_singleTransactionModel;
            set => _singleTransactionModel = value;
        }
        public SingleTransactionServices.SingleTransactionServices SingleTransactionServices
        {
            get => (SingleTransactionServices.SingleTransactionServices)_singleTransactionServices;
            set => _singleTransactionServices = value;
        }
    }
}
