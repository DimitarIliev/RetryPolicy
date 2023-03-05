using System.Text.Json;

namespace RetryPolicy.Services
{
    public class LocationWeatherService : ILocationWeatherService
    {
        private readonly HttpClient _httpClient;

        public LocationWeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecastsAsync()
        {
            var response = await _httpClient.GetAsync("/WeatherForecast");

            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<IEnumerable<WeatherForecast>>(content)!;
        }
    }
}
