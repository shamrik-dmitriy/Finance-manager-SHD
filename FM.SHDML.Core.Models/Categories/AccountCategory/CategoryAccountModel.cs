using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHDML.Core.Models.Categories.AccountCategory
{
    public class CategoryAccountModel : ICategoryAccountModel
    {
        [MaxLength(255, ErrorMessage = "Длина названия категории счёта не может превышать 255 символов")]
        public string Name { get; set; }

        [MaxLength(255, ErrorMessage = "Длина описания категории счёта не может превышать 255 символов")]
        public string Description { get; set; }
    }
}
