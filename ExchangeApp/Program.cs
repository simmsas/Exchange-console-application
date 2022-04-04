// See https://aka.ms/new-console-template for more information

using ExchangeApp;
using ExchangeApp.Services;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new ServiceCollection();

services.ConfigureServices();

ServiceProvider serviceProvider = services.BuildServiceProvider();
MainService mainService = serviceProvider.GetService<MainService>();
mainService.GetResult();