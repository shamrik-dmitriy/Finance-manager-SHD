using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FM.SHD.Services.Repositories;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;
using FM.SHDML.Core.Models.TransactionModels.Transactions.TypeTransaction;

namespace FM.SHD.Services.ComponentsServices.TypeTransactionService
{
    public class TypeTransactionServices : ITypeTransactionServices
    {
        private readonly ITypeTransactionRepository _typeTransactionRepository;
        private readonly IMapper _mapper;

        public TypeTransactionServices(ITypeTransactionRepository typeTransactionRepository)
        {
            _typeTransactionRepository = typeTransactionRepository;
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<TypeTransactionModel, TypeTransactionDto>();
                config.CreateMap<TypeTransactionDto, TypeTransactionModel>();
            }).CreateMapper();
        }

        public IEnumerable<TypeTransactionDto> GetAll()
        {
            return _typeTransactionRepository.GetAll().Select(x => _mapper.Map<TypeTransactionDto>(x));
        }

        public TypeTransactionDto GetById(int id)
        {
            return _mapper.Map<TypeTransactionDto>(_typeTransactionRepository.GetById(id));
        }
    }
}