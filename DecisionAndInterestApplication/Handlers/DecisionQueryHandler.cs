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
        private readonly IDecisionHelper _decisionHelper;

        public DecisionQueryHandler(IDecisionValidation decisionValidation, IDecisionHelper decisionHelper)
        {
            _decisionValidation = decisionValidation;
            _decisionHelper = decisionHelper;
        }

        public async Task<DecisionResponse> Handle(CreditAmountQuery request, CancellationToken cancellationToken)
        {
            _decisionValidation.Validate(request.Amount);

            var result = await _decisionHelper.GetDecisionBasedOnAppliedAmountAsync(request.Amount.Value);

            var response = new DecisionResponse {  Decision = result.Title };

            return response;
        }
    }
}
