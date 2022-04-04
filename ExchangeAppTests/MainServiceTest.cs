using ExchangeApp.Services;
using FluentAssertions;
using Xunit;

namespace ExchangeAppTests
{
    public class MainServiceTest
    {
        [Fact]
        public void GetResult_GivenSampleText_CountCorrectly()
        {
            InfoService infoService = new InfoService();
            CountingService countingService = new CountingService(infoService);

            string isoFrom = "EUR";
            string isoTo = "DKK";
            decimal amount = 100M;


            decimal result = countingService.Count(isoFrom, isoTo, amount);

            result.Should().Be(743.3400M);

        }
    }
}
