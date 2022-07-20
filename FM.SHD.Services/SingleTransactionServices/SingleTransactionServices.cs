using FM.SHD.Services.CommonServices;
using FM.SHDML.Core.Models.TransactionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Services.SingleTransactionServices
{
    public class SingleTransactionServices : ISingleTransactionServices, ISingleTransactionRepository
    {
        private ISingleTransactionRepository _singleTransactionRepository;
        private IModelValidator _modelValidator;

        public SingleTransactionServices(ISingleTransactionRepository repository, IModelValidator modelValidator)
        {
            _singleTransactionRepository = repository;
            _modelValidator = modelValidator;
        }

        public void Add(ISingleTransactionModel singleTransactionModel)
        {
            ValidateModel(singleTransactionModel);
            _singleTransactionRepository.Add(singleTransactionModel);
        }
        public void Update(ISingleTransactionModel singleTransactionModel)
        {
            ValidateModel(singleTransactionModel);
            _singleTransactionRepository.Update(singleTransactionModel);
        }

        public SingleTransactionModel GetById(int id)
        {
            return _singleTransactionRepository.GetById(id);
        }

        public void Delete(ISingleTransactionModel singleTransactionModel)
        {
            _singleTransactionRepository.Delete(singleTransactionModel);
        }

        public void DeleteById(int singleTransactionId)
        {
            _singleTransactionRepository.DeleteById(singleTransactionId);
        }

        public void ValidateModel(ISingleTransactionModel singleTransactionModel)
        {
            _modelValidator.ValidateModel(singleTransactionModel);
            // Тут вызываем дополнительную валидацию
        }
    }
}
