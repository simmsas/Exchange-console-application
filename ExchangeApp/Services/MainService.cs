using ExchangeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApp.Services
{
    public class MainService
    {
        InfoService infoService;
        CountingService countingService;

        public MainService(InfoService infoService, CountingService countingService)
        {
            this.infoService = infoService;
            this.countingService = countingService;
        }
        public void GetResult()
        {
            string infos;
            string isoFrom;
            string isoTo;
            decimal amount;

            Console.Write("Exchange <currency pair> <amount to exchange>");
            infos = Console.ReadLine();
            
            string[] splitInfo = infos.Split(" ");

            isoFrom = splitInfo[0];
            isoTo = splitInfo[1];
            amount = Convert.ToDecimal(splitInfo[2]);

            decimal result = countingService.Count(isoFrom, isoTo, amount);

            Console.WriteLine(result);

            
        }
    }
}
