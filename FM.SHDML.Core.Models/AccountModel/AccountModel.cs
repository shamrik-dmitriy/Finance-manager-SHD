using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHDML.Core.Models.AccountModel
{
    public class AccountModel : IAccountModel
    {
        public long Id { get; set; }

        [MaxLength(255, ErrorMessage = "Длина названия счёта не может превышать 255 символов")]
        public string Name { get; set; }

        [MaxLength(255, ErrorMessage = "Длина описания счёта не может превышать 255 символов")]
        public string Description { get; set; }

        public decimal CurrentSum { get; set; }

        public decimal InitialSum { get; set; }

        public bool IsClosed { get; set; }

        [MaxLength(255, ErrorMessage = "Длина названия валюты не может превышать 255 символов")]
        public string Currency { get; set; }

        public long CategoryId { get; set; }

        public long IdentityId { get; set; }
    }
}
