using FM.SHD.Services.CommonServices;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FM.SHD.Services.Repositories;
using SHDML.BLL.DTO.DTO;

namespace FM.SHD.Services.SingleTransactionServices
{
    public class SingleTransactionServices : ISingleTransactionServices
    {
        private readonly ISingleTransactionRepository _singleTransactionRepository;
        private readonly IModelValidator _modelValidator;
        private readonly IMapper _mapper;

        public SingleTransactionServices(ISingleTransactionRepository repository, IModelValidator modelValidator)
        {
            _singleTransactionRepository = repository;
            _modelValidator = modelValidator;
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<SingleTransactionDto, SingleTransactionModel>();
                config.CreateMap<SingleTransactionModel, SingleTransactionDto>();
            }).CreateMapper();
        }

        public long Add(SingleTransactionDTO singleTransactionDto)
        {
            var model = _mapper.Map<SingleTransactionModel>(singleTransactionDto);
            ValidateModel(model);
            return _singleTransactionRepository.Add(model);
        }

        public void Update(SingleTransactionDTO singleTransactionDto)
        {
            var model = _mapper.Map<SingleTransactionModel>(singleTransactionDto);
            ValidateModel(model);
            _singleTransactionRepository.Update(model);
        }

        IEnumerable<SingleTransactionDTO> ISingleTransactionServices.GetAll()
        {
            return _singleTransactionRepository.GetAll().Select(x => _mapper.Map<SingleTransactionDTO>(x));
        }

        public SingleTransactionDTO GetById(int id)
        {
            return _mapper.Map<SingleTransactionDTO>(_singleTransactionRepository.GetById(id));
        }

        public void Delete(SingleTransactionDTO singleTransactionDto)
        {
            _singleTransactionRepository.Delete(_mapper.Map<SingleTransactionModel>(singleTransactionDto));
        }

        public void DeleteById(int singleTransactionId)
        {
            _singleTransactionRepository.DeleteById(singleTransactionId);
        }

        public void ValidateModel(SingleTransactionModel singleTransactionModel)
        {
            _modelValidator.ValidateModel(singleTransactionModel);
            if (singleTransactionModel.CreditAccount == singleTransactionModel.DebitAccount)
            {
                throw new ArgumentException("Перевод при одинаковых счетах списания и пополнения невозможен");
            }
            // Тут вызываем дополнительную валидацию
        }
    }
}