using DecisionAndInterestApplication.Responses;
using MediatR;

namespace DecisionAndInterestApplication.Queries
{
    public class CreditAmountQuery : IRequest<DecisionResponse>
    {
        public int? CreditAmount { get; set; }

        public int? CurrentPreExistingAmount { get; set; }
    }
}
