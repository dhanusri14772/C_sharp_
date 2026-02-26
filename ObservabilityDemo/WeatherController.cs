using Microsoft.AspNetCore.Mvc;
namespace ObservabilityDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;
        public WeatherController(ILogger<WeatherController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult GetWeather()
        {
            _logger.LogInformation("Weather endpoint hit at {Time}", DateTime.UtcNow);
            try
            {
                var summaries = new[]
                {
                    "Freezing", "Bracing", "Chilly", "Cool",
                    "Mild", "Warm", "Balmy", "Hot",
                    "Sweltering", "Scorching"
                };
                var forecast = Enumerable.Range(1, 5).Select(index =>
                    new WeatherForecast
                    (
                        DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                        Random.Shared.Next(-20, 55),
                        summaries[Random.Shared.Next(summaries.Length)]
                    ))
                    .ToArray();
                _logger.LogInformation("Successfully generated {Count} weather records", forecast.Length);
                return Ok(forecast);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while generating weather data");
                return StatusCode(500, "Internal server error");
            }
        }
    }
    public record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}