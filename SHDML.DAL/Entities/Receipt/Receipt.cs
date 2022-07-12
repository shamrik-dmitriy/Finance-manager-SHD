using System;
using System.Collections.Generic;
using SHDML.DAL.Entities.Receipt.Types;

namespace SHDML.DAL.Entities.Receipt
{
    public class Receipt
    {
        #region Retail info

        /// <summary>
        ///     Наименование организации, включая её тип (ООО, АО, ОАО, ЗАО и т.д.)
        /// </summary>
        public string RetailName { get; set; }

        /// <summary>
        ///     Место продажи
        /// </summary>
        public string RetailPlaceAddress { get; set; }

        /// <summary>
        ///     Инн организации
        /// </summary>
        public string RetailInn { get; set; }

        /// <summary>
        ///     Наименование торговой точки
        /// </summary>
        public string RetailPlaceName { get; set; }

        /// <summary>
        ///     Данные продавца-кассира
        /// </summary>
        public string SellerCashier { get; set; }

        #endregion

        #region Tax info

        /// <summary>
        ///     Сумма удерживаемого налога на добавленную стоимость (НДС) по ставке 18 %
        /// </summary>
        public decimal Nds18 { get; set; }

        /// <summary>
        ///     Сумма удерживаемого налога на добавленную стоимость (НДС) по ставке 10 %
        /// </summary>
        public decimal Nds10 { get; set; }

        /// <summary>
        ///     Сумма по операциям, не облагаемая НДС
        /// </summary>
        public decimal nds0 { get; set; }

        /// <summary>
        ///     Тип налогообложения
        /// </summary>
        public TaxationType TaxationType { get; set; }

        #endregion

        #region Cashbox info

        /// <summary>
        ///     Фискальная подпись, ФП, ФПД
        /// </summary>
        public ulong FiscalSign { get; set; }

        /// <summary>
        ///     Номер фискального документа, ФД
        /// </summary>
        public long FiscalDocumentNumber { get; set; }

        /// <summary>
        ///     Регистрационный номер ККТ
        /// </summary>
        public string KKTRegId { get; set; }

        /// <summary>
        ///     Номер смены, в течение которой был сгенерирован документ
        /// </summary>
        public string ShiftNumber { get; set; }

        /// <summary>
        ///     Номер документа внутри смены
        /// </summary>
        public string DocShiftNumber { get; set; }

        #endregion

        #region Money info

        /// <summary>
        ///     Общая сумма чека
        /// </summary>
        public decimal TotalSum { get; set; }

        /// <summary>
        ///     Сумма к оплате наличными
        /// </summary>
        public decimal CashTotalSum { get; set; }

        /// <summary>
        ///     Сумма к оплате электронными деньгами
        /// </summary>
        public decimal ECashTotalSum { get; set; }

        /// <summary>
        ///     Сумма предоплаты (авансами)
        /// </summary>
        public decimal PrepaidSum { get; set; }

        /// <summary>
        ///     Сумма постоплаты (кредитами)
        /// </summary>
        public decimal CreditSum { get; set; }

        /// <summary>
        ///     Сумма резерва (встречные предоставления)
        /// </summary>
        public decimal ProvisionSum { get; set; }

        #endregion

        #region Opertions info

        /// <summary>
        ///     Тип операции
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        ///     Дата совершения операции
        /// </summary>
        public DateTime DateTime { get; set; }

        #endregion

        /// <summary>
        ///     Список позиций в чеке
        /// </summary>
        public IEnumerable<Item> Items { get; set; }
    }
}