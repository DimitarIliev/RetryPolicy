using Newtonsoft.Json;
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

            var result = JsonConvert.DeserializeObject<IEnumerable<WeatherForecast>>(content);

            return result;
        }
    }
}
