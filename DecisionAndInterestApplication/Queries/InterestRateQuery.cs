using DecisionAndInterestApplication.Responses;
using MediatR;

namespace DecisionAndInterestApplication.Queries
{
    public class InterestRateQuery : IRequest<InterestRateResponse>
    {
        public int? Amount { get; set; }
    }
}
