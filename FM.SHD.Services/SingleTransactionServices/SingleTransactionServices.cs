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
                config.CreateMap<SingleTransactionDto, SingleTransactionModel>()
                    .ForMember(
                        x=>x.TypeTransactionId,
                        opt => 
                            opt.MapFrom(src => src.TypeTransactionId.HasValue ? src.TypeTransactionId.Value : (long?)null))
                    .ForMember(
                        x=>x.CategoryId,
                        opt => 
                            opt.MapFrom(src => src.CategoryId.HasValue ? src.CategoryId.Value : (long?)null))
                    .ForMember(
                        x=>x.ContragentId,
                        opt => 
                            opt.MapFrom(src => src.ContragentId.HasValue ? src.ContragentId.Value : (long?)null))
                    .ForMember(
                        x=>x.IdentityId,
                        opt => 
                            opt.MapFrom(src => src.IdentityId.HasValue ? src.IdentityId.Value : (long?)null))
                    .ForMember(
                        x=>x.CreditAccountId,
                        opt => 
                            opt.MapFrom(src => src.CreditAccountId.HasValue ? src.CreditAccountId.Value : (long?)null))
                    .ForMember(
                        x=>x.DebitAccountId,
                        opt => 
                            opt.MapFrom(src => src.DebitAccountId.HasValue ? src.DebitAccountId.Value : (long?)null));
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