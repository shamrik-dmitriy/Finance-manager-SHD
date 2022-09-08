using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FM.SHD.Services.CommonServices;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.Dtos;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;

namespace FM.SHD.Services.TransactionServices
{
    public class TransactionServices : ITransactionServices
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IModelValidator _modelValidator;
        private readonly IMapper _mapper;

        public TransactionServices(ITransactionRepository repository, IModelValidator modelValidator)
        {
            _transactionRepository = repository;
            _modelValidator = modelValidator;
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<TransactionExtendedModel, TransactionExtendedDto>();
                config.CreateMap<TransactionModel, TransactionDto>();
                config.CreateMap<TransactionDto, TransactionModel>()
                    .ForMember(
                        x => x.TypeTransactionId,
                        opt =>
                            opt.MapFrom(src =>
                                src.TypeTransactionId.HasValue ? src.TypeTransactionId.Value : (long?)null))
                    .ForMember(
                        x => x.CategoryId,
                        opt =>
                            opt.MapFrom(src => src.CategoryId.HasValue ? src.CategoryId.Value : (long?)null))
                    .ForMember(
                        x => x.ContragentId,
                        opt =>
                            opt.MapFrom(src => src.ContragentId.HasValue ? src.ContragentId.Value : (long?)null))
                    .ForMember(
                        x => x.IdentityId,
                        opt =>
                            opt.MapFrom(src => src.IdentityId.HasValue ? src.IdentityId.Value : (long?)null))
                    .ForMember(
                        x => x.CreditAccountId,
                        opt =>
                            opt.MapFrom(src => src.CreditAccountId.HasValue ? src.CreditAccountId.Value : (long?)null))
                    .ForMember(
                        x => x.DebitAccountId,
                        opt =>
                            opt.MapFrom(src => src.DebitAccountId.HasValue ? src.DebitAccountId.Value : (long?)null));
            }).CreateMapper();
        }

        public long Add(TransactionDto transactionDto)
        {
            var model = _mapper.Map<TransactionModel>(transactionDto);
            ValidateModel(model);
            return _transactionRepository.Add(model);
        }

        public void Update(TransactionDto transactionDto)
        {
            var model = _mapper.Map<TransactionModel>(transactionDto);
            ValidateModel(model);
            _transactionRepository.Update(model);
        }

        IEnumerable<TransactionDto> ITransactionServices.GetAll()
        {
            return _transactionRepository.GetAll().Select(x => _mapper.Map<TransactionDto>(x));
        }

        public TransactionDto GetById(int id)
        {
            return _mapper.Map<TransactionDto>(_transactionRepository.GetById(id));
        }

        public List<TransactionExtendedDto> GetExtendedTransactions()
        {
            return _transactionRepository.GetExtendedTransactions().Select(x => _mapper.Map<TransactionExtendedDto>(x)).ToList();
        }

        public void Delete(TransactionDto transactionDto)
        {
            _transactionRepository.Delete(_mapper.Map<TransactionModel>(transactionDto));
        }

        public void DeleteById(int transactionId)
        {
            _transactionRepository.DeleteById(transactionId);
        }

        public void ValidateModel(TransactionModel transactionModel)
        {
            _modelValidator.ValidateModel(transactionModel);
            // Тут вызываем дополнительную валидацию
        }
    }
}