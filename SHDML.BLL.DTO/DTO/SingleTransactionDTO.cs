using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHDML.BLL.DTO.DTO
{
    public class SingleTransactionDTO
    {
        public long Id { get; set; }
        public int TypeTransaction { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long DebitAccount { get; set; }
        public long CreditAccount { get; set; }
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
        public long Category { get; set; }
        public long Contragent { get; set; }
        public long FamilyMember { get; set; }
    }
}