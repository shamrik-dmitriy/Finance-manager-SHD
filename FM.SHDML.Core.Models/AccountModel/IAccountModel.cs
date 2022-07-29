using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHDML.Core.Models.AccountModel
{
    public interface IAccountModel
    {
        /// <summary>
        ///     Идентификатор
        /// </summary>
        public long Id { get; set; }   
        
        /// <summary>
        ///     Наименование счёта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Описание счёта
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Текущая сумма счёта
        /// </summary>
        public decimal CurrentSum { get; set; }

        /// <summary>
        ///     Изначальная сумма счёта
        /// </summary>
        public decimal InitialSum { get; set; }

        /// <summary>
        ///     Определяет закрытый или открытый счёт
        /// </summary>
        public bool IsClosed { get; set; }

        /// <summary>
        ///     Валюта
        /// </summary>
        public string Currency { get; set; }
        
        /// <summary>
        ///     Идентификатор категории счёта
        /// </summary>
        public long CategoryId { get; set; }

        /// <summary>
        ///     Идентификатор личности
        /// </summary>
        public long IdentityId { get; set; }
    }
}
