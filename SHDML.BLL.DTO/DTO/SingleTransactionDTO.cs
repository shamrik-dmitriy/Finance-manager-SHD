using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHDML.BLL.DTO.DTO
{
    public class SingleTransactionDTO
    {
        public int TypeTransaction { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DebitAccount { get; set; }
        public string CreditAccount { get; set; }
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Contragent { get; set; }

        public string FamilyMember { get; set; }
    }
}