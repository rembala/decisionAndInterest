using DecisionAndInterestApplication.Responses;
using MediatR;

namespace DecisionAndInterestApplication.Queries
{
    public class CreditAmountQuery : IRequest<DecisionResponse>
    {
        public int? Amount { get; set; }
    }
}
