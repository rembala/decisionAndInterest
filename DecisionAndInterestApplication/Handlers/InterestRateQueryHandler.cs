using DecisionAndInterestApplication.Helpers;
using DecisionAndInterestApplication.Interfaces.Helpers;
using DecisionAndInterestApplication.Interfaces.Validations;
using DecisionAndInterestApplication.Queries;
using DecisionAndInterestApplication.Responses;
using MediatR;

namespace DecisionAndInterestApplication.Handlers
{
    public class InterestRateQueryHandler : IRequestHandler<InterestRateQuery, InterestRateResponse>
    {
        private readonly IInterestRateValidation _interestRateValidation;
        private readonly IInterestRateHelper _interestRateHelper;

        public InterestRateQueryHandler(IInterestRateValidation interestRateValidation, IInterestRateHelper interestRateHelper)
        {
            _interestRateValidation = interestRateValidation;
            _interestRateHelper = interestRateHelper;
        }

        public async Task<InterestRateResponse> Handle(InterestRateQuery request, CancellationToken cancellationToken)
        {
            _interestRateValidation.Validate(request.Amount);

            var result = await _interestRateHelper.GetInterestRateBasedOnFutureDebt(request.Amount.Value);

            var response = new InterestRateResponse { InterestRate = result.Amount };

            return response;
        }
    }
}
