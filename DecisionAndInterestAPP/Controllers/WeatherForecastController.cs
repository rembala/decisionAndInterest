using DecisionAndInterestApplication.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DecisionAndInterestAPP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ISender _sender;

        public WeatherForecastController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _sender.Send(new CreditAmountQuery());

            return null;
        }
    }
}
