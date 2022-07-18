using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHDML.BLL.DTO.DTO
{
    public class SingleTransactionDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
    }
}
