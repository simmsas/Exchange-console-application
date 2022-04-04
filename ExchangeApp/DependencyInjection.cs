using ExchangeApp.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApp
{
    public static class DependencyInjection
    {
        public static void ConfigureServices(this IServiceCollection services)
        { 
            services.AddTransient<MainService>();
            services.AddTransient<InfoService>();
            services.AddTransient<CountingService>();
        }
    }
}
