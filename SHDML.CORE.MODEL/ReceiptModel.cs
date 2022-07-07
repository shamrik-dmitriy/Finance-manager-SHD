using System;
using System.Collections.Generic;

namespace SHDML.CORE.MODEL
{
    public class ReceiptModel
    {
        public string TypeOfBusinessEntity { get; set; }
        public string RetailName { get; set; }

        public string RetailPlaceAddress { get; set; }
        public string RetailInn { get; set; }
        public string RetailPlaceName { get; set; }

        public string SellerCashier { get; set; }

        // 1 - приход (покупка), 2 уход (возврат), возможно перечисление
        public string OperationType { get; set; }
        public decimal TotalSum { get; set; }
        public decimal CashTotalSum { get; set; }
        public decimal ECashTotalSum { get; set; }
        public long KKTRegId { get; set; }
        public long FiscalDocumentNumber { get; set; }
        public long FiscalSign { get; set; }
        public IEnumerable<GoodsModel> Goods { get; set; }
        public decimal Nds18 { get; set; }
        public decimal Nds10 { get; set; }

        public decimal nds0 { get; set; }

        // TODO: Enum? Непонятно что это
        public int Code { get; set; }
        public decimal PrepaidSum { get; set; }
        public decimal CreditSum { get; set; }
        public decimal ProvisionSum { get; set; }

        public DateTime DateTime { get; set; }

        // TODO: непонятно что
        public string TaxationType { get; set; }
        public DateTime LocalDateTime { get; set; }
    }
}