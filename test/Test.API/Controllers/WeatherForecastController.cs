using Forismatic;
using Microsoft.AspNetCore.Mvc;

namespace Test.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IForismaticApiClient _client;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IForismaticApiClient client)
    {
        _logger = logger;
        _client = client;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IActionResult> Get()
    {
        var result = await _client.GetQuoteAsync(Forismatic.Models.LanguageEnum.English);
        return Ok(result);
    }
}
