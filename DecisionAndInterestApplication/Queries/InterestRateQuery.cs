using DecisionAndInterestApplication.Responses;
using MediatR;

namespace DecisionAndInterestApplication.Queries
{
    public class InterestRateQuery : IRequest<InterestRateResponse>
    {
        public int? totalFutureDebt { get; set; }
    }
}
