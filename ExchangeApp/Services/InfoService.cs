using ExchangeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApp.Services
{
    public class InfoService
    {
        public decimal GetCurrency (string Iso)
        {
            List<Currency> list = CreateCurrencies();
            decimal value = list.FirstOrDefault(i => i.Iso == Iso).Amount;

            return value;
        }

        public List<Currency> CreateCurrencies()
        {
            List<Currency> currencies = new List<Currency>();
            Currency currency = new Currency();
            currency.Iso = "EUR";
            currency.Amount = 743.34M;
            currencies.Add(currency);

            Currency currency2 = new Currency();
            currency2.Iso = "USD";
            currency2.Amount = 663.11M;
            currencies.Add(currency2);

            Currency currency3 = new Currency();
            currency3.Iso = "GBP";
            currency3.Amount = 852.85M;
            currencies.Add(currency3);

            Currency currency4 = new Currency();
            currency4.Iso = "SEK";
            currency4.Amount = 76.10M;
            currencies.Add(currency4);

            Currency currency5 = new Currency();
            currency5.Iso = "NOK";
            currency5.Amount = 78.40M;
            currencies.Add(currency5);

            Currency currency6 = new Currency();
            currency6.Iso = "CHF";
            currency6.Amount = 683.58M;
            currencies.Add(currency6);

            Currency currency7 = new Currency();
            currency7.Iso = "JPY";
            currency7.Amount = 5.9740M;
            currencies.Add(currency7);

            Currency currency8 = new Currency();
            currency8.Iso = "DKK";
            currency8.Amount = 100M;
            currencies.Add(currency8);

            return currencies;
        }
    }
}
