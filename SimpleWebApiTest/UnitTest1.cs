using Microsoft.Extensions.Logging;
using SimpleWebApi.Controllers;

namespace SimpleWebApiTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            WeatherForecastController asd = new WeatherForecastController(null);
            var t = asd.Get();
            Assert.NotNull(t);

        }
    }
}