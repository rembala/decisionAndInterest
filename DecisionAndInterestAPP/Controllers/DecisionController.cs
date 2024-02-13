using DecisionAndInterestApplication.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DecisionAndInterestAPP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DecisionController : ControllerBase
    {
        private readonly ISender _sender;

        public DecisionController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<string> GetDecisionBasedOnAppliedAmount(int creditAmount, int currentPreExistingAmount)
        {
            var result = await _sender.Send(new CreditAmountQuery { 
                CreditAmount = creditAmount,
                CurrentPreExistingAmount = currentPreExistingAmount
            });

            return result.Decision;
        }
    }
}
