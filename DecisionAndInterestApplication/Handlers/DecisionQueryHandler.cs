using DecisionAndInterestApplication.Interfaces.Helpers;
using DecisionAndInterestApplication.Interfaces.Validations;
using DecisionAndInterestApplication.Queries;
using DecisionAndInterestApplication.Responses;
using MediatR;

namespace DecisionAndInterestApplication.Handlers
{
    public class DecisionQueryHandler : IRequestHandler<CreditAmountQuery, DecisionResponse>
    {
        private readonly IDecisionValidation _decisionValidation;
        private readonly IDecisionService _decisionService;

        public DecisionQueryHandler(IDecisionValidation decisionValidation, IDecisionService decisionService)
        {
            _decisionValidation = decisionValidation;
            _decisionService = decisionService;
        }

        public async Task<DecisionResponse> Handle(CreditAmountQuery request, CancellationToken cancellationToken)
        {
            _decisionValidation.Validate(request.CreditAmount, request.CurrentPreExistingAmount);

            var result = await _decisionService.GetDecisionBasedOnAppliedAmountAsync(request.CreditAmount.Value);

            var response = new DecisionResponse {  Decision = result.Title };

            return response;
        }
    }
}
