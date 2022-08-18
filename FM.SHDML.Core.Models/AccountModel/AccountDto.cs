using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHDML.Core.Models.AccountModel
{
    public class AccountDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal CurrentSum { get; set; }

        public decimal InitialSum { get; set; }

        public bool IsClosed { get; set; }

        public string Currency { get; set; }
    }
}
