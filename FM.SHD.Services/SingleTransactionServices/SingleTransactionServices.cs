using FM.SHD.Services.CommonServices;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FM.SHD.Services.Repositories;

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
            }).CreateMapper();
        }

        public long Add(SingleTransactionDto singleTransactionDto)
        {
            var model = _mapper.Map<SingleTransactionModel>(singleTransactionDto);
            ValidateModel(model);
            return _singleTransactionRepository.Add(model);
        }

        public void Update(SingleTransactionDto singleTransactionDto)
        {
            var model = _mapper.Map<SingleTransactionModel>(singleTransactionDto);
            ValidateModel(model);
            _singleTransactionRepository.Update(model);
        }

        IEnumerable<SingleTransactionDto> ISingleTransactionServices.GetAll()
        {
            return _singleTransactionRepository.GetAll().Select(x => _mapper.Map<SingleTransactionDto>(x));
        }

        public SingleTransactionDto GetById(int id)
        {
            return _mapper.Map<SingleTransactionDto>(_singleTransactionRepository.GetById(id));
        }

        public void Delete(SingleTransactionDto singleTransactionDto)
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
            // Тут вызываем дополнительную валидацию
        }
    }
}