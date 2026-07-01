using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Function;

public class WeatherHttpTrigger
{
    private readonly ILogger<WeatherHttpTrigger> _logger;

    public WeatherHttpTrigger(ILogger<WeatherHttpTrigger> logger)
    {
        _logger = logger;
    }
    

    [Function("WeatherHttpTrigger")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}
