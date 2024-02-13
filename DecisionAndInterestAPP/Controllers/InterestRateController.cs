using DecisionAndInterestApplication.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DecisionAndInterestPresentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InterestRateController : ControllerBase
    {
        private readonly ISender _sender;

        public InterestRateController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<int> GetInterestRateBasedOnTotalFutueDebt(int repainmentInMonths)
        {
            var result = await _sender.Send(new InterestRateQuery { totalFutureDebt = repainmentInMonths });

            return result.InterestRate;
        }
    }
}
