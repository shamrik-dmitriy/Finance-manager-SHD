using System;
using System.Collections.Generic;
using FM.SHDML.Core.Models.old.model.Receipt.Types;

namespace FM.SHDML.Core.Models.old.model.Receipt
{
    public class ReceiptModel
    {
        public ReceiptModel(string retailName, string retailPlaceAddress, string retailInn, string retailPlaceName,
            string sellerCashier, decimal nds18, decimal nds10, TaxationType taxationType, ulong fiscalSign,
            long fiscalDocumentNumber, string shiftNumber, decimal totalSum, decimal cashTotalSum,
            decimal eCashTotalSum, decimal prepaidSum, decimal creditSum, decimal provisionSum,
            OperationType operationType, DateTime dateTime, IEnumerable<ItemModel> items)
        {
            RetailName = retailName;
            RetailPlaceAddress = retailPlaceAddress;
            RetailInn = retailInn;
            RetailPlaceName = retailPlaceName;
            SellerCashier = sellerCashier;
            Nds18 = nds18;
            Nds10 = nds10;
            TaxationType = taxationType;
            FiscalSign = fiscalSign;
            FiscalDocumentNumber = fiscalDocumentNumber;
            ShiftNumber = shiftNumber;
            TotalSum = totalSum;
            CashTotalSum = cashTotalSum;
            ECashTotalSum = eCashTotalSum;
            PrepaidSum = prepaidSum;
            CreditSum = creditSum;
            ProvisionSum = provisionSum;
            OperationType = operationType;
            DateTime = dateTime;
            Items = items;
        }

        #region Retail info

        /// <summary>
        ///     Наименование организации, включая её тип (ООО, АО, ОАО, ЗАО и т.д.)
        /// </summary>
        public string RetailName { get; }

        /// <summary>
        ///     Место продажи
        /// </summary>
        public string RetailPlaceAddress { get; }

        /// <summary>
        ///     Инн организации
        /// </summary>
        public string RetailInn { get; }

        /// <summary>
        ///     Наименование торговой точки
        /// </summary>
        public string RetailPlaceName { get; }

        /// <summary>
        ///     Данные продавца-кассира
        /// </summary>
        public string SellerCashier { get; }

        #endregion

        #region Tax info

        /// <summary>
        ///     Сумма удерживаемого налога на добавленную стоимость (НДС) по ставке 18 %
        /// </summary>
        public decimal Nds18 { get; }

        /// <summary>
        ///     Сумма удерживаемого налога на добавленную стоимость (НДС) по ставке 10 %
        /// </summary>
        public decimal Nds10 { get; }

        /// <summary>
        ///     Сумма по операциям, не облагаемая НДС
        /// </summary>
        public decimal Nds0 { get; }

        /// <summary>
        ///     Тип налогообложения
        /// </summary>
        public TaxationType TaxationType { get; }

        #endregion

        #region Cashbox info

        /// <summary>
        ///     Фискальная подпись, ФП, ФПД
        /// </summary>
        public ulong FiscalSign { get; }

        /// <summary>
        ///     Номер фискального документа, ФД
        /// </summary>
        public long FiscalDocumentNumber { get; }

        /// <summary>
        ///     Регистрационный номер ККТ
        /// </summary>
        public string KktRegId { get; }

        /// <summary>
        ///     Номер смены, в течение которой был сгенерирован документ
        /// </summary>
        public string ShiftNumber { get; }

        /// <summary>
        ///     Номер документа внутри смены
        /// </summary>
        public string DocShiftNumber { get; }

        #endregion

        #region Money info

        /// <summary>
        ///     Общая сумма чека
        /// </summary>
        public decimal TotalSum { get; }

        /// <summary>
        ///     Сумма к оплате наличными
        /// </summary>
        public decimal CashTotalSum { get; }

        /// <summary>
        ///     Сумма к оплате электронными деньгами
        /// </summary>
        public decimal ECashTotalSum { get; }

        /// <summary>
        ///     Сумма предоплаты (авансами)
        /// </summary>
        public decimal PrepaidSum { get; }

        /// <summary>
        ///     Сумма постоплаты (кредитами)
        /// </summary>
        public decimal CreditSum { get; }

        /// <summary>
        ///     Сумма резерва (встречные предоставления)
        /// </summary>
        public decimal ProvisionSum { get; }

        #endregion

        #region Opertions info

        /// <summary>
        ///     Тип операции
        /// </summary>
        public OperationType OperationType { get; }

        /// <summary>
        ///     Дата совершения операции
        /// </summary>
        public DateTime DateTime { get; }

        #endregion

        /// <summary>
        ///     Список позиций в чеке
        /// </summary>
        public IEnumerable<ItemModel> Items { get; }
    }
}