using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApp.Services
{
    public class CountingService
    {
        InfoService infoService;

        public CountingService(InfoService infoService)
        {
            this.infoService = infoService;
        }
        public decimal Count(string isoFrom, string isoTo, decimal amount)
        {
           infoService.CreateCurrencies() ;
            decimal rateFrom = infoService.GetCurrency(isoFrom);
            decimal rateTo = infoService.GetCurrency(isoTo);


            decimal value1 = rateFrom;
            decimal value2 = rateTo;
            decimal result = 0;
            if (amount > 0)
            {
               result = rateFrom / rateTo * amount;
            };

            return result;
        }
    }
}
