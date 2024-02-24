using System.Collections.Generic;
using FM.SHD.Domain.Entities.System;

namespace FM.SHD.Currencies
{
    public static class TypeOfCurrencies
    {

        public static List<SystemCurrency> GetTypeOfCurrencies()
        {
            return new List<SystemCurrency>()
            {
                new() { Id = 1, Name = "Рубль", Symbol = "P" },
                new() { Id = 2, Name = "Доллар", Symbol = "$" }
            };
        }
    }
}