namespace RetryPolicy.Services
{
    public interface ILocationWeatherService
    {
        Task<IEnumerable<WeatherForecast>> GetWeatherForecastsAsync();
    }
}
