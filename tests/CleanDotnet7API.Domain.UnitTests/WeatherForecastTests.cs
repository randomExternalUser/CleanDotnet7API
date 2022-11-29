using CleanDotnet7API.Domain.Services;

namespace CleanDotnet7API.Domain.UnitTests
{
    public class WeatherForecastServiceTests
    {
        private readonly WeatherForecastService _sut;
        public WeatherForecastServiceTests()
        {
            _sut = new WeatherForecastService();
        }

        [Fact]
        public void GetForecastsShouldReturn5Results()
        {
            var forecasts = _sut.GetForecasts();
            Assert.Equal(5, forecasts.Count());
        }
    }
}
