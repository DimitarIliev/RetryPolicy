using Microsoft.AspNetCore.Mvc;
using RetryPolicy.Services;

namespace RetryPolicy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILocationWeatherService _locationWeatherService;
        public LocationController(ILocationWeatherService locationWeatherService)
        {
            _locationWeatherService = locationWeatherService;
        }

        [HttpGet(Name = "GetWeatherForecastForLocation")]
        public async Task<WeatherForecast> Get()
        {
            var response = await _locationWeatherService.GetWeatherForecastsAsync();

            return response.FirstOrDefault();
        }
    }
}
