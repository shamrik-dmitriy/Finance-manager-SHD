using FM.SHD.Services.CommonServices;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FM.SHD.Services.Repositories;
using SHDML.BLL.DTO.DTO;

namespace FM.SHD.Services.SingleTransactionServices
{
    public class SingleTransactionServices : ISingleTransactionServices
    {
        private ISingleTransactionRepository _singleTransactionRepository;
        private IModelValidator _modelValidator;

        public SingleTransactionServices(ISingleTransactionRepository repository, IModelValidator modelValidator)
        {
            _singleTransactionRepository = repository;
            _modelValidator = modelValidator;
        }

        private SingleTransactionModel ToSingleTransactionModel(SingleTransactionDTO singleTransactionDto)
        {
            return new SingleTransactionModel() { };
        }       
        
        private IEnumerable<SingleTransactionDTO> ToSingleTransactionDTOs(IEnumerable<ISingleTransactionModel> singleTransactionModels)
        {
            return new List<SingleTransactionDTO>();
        }    
        
        private SingleTransactionDTO ToSingleTransactionDTO(ISingleTransactionModel singleTransactionModel)
        {
            return new SingleTransactionDTO();
        }
        
        public long Add(SingleTransactionDTO singleTransactionDto)
        {
            var model = ToSingleTransactionModel(singleTransactionDto);
            ValidateModel(model);
            return _singleTransactionRepository.Add(model);
        }

        public void Update(SingleTransactionDTO singleTransactionDto)
        {
            var model = ToSingleTransactionModel(singleTransactionDto);
            ValidateModel(model);
            _singleTransactionRepository.Update(model);
        }

        IEnumerable<SingleTransactionDTO> ISingleTransactionServices.GetAll()
        {
            return ToSingleTransactionDTOs(_singleTransactionRepository.GetAll());
        }

        public SingleTransactionDTO GetById(int id)
        {
            return ToSingleTransactionDTO(_singleTransactionRepository.GetById(id));
        }

        public void Delete(SingleTransactionDTO singleTransactionDto)
        {
            _singleTransactionRepository.Delete(ToSingleTransactionModel(singleTransactionDto));
        }

        public void DeleteById(int singleTransactionId)
        {
            _singleTransactionRepository.DeleteById(singleTransactionId);
        }

        public void ValidateModel(SingleTransactionModel singleTransactionModel)
        {
            _modelValidator.ValidateModel(singleTransactionModel);
            // Тут вызываем дополнительную валидацию
        }
    }
}