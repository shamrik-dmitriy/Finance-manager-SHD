using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Services.ContragentServices
{
    public interface IContragentServices
    {
        IEnumerable<ContragentDto> GetAll();
        
        ContragentDto GetById(int id);
        
        ContragentDto GetByName(string name);
    }
}