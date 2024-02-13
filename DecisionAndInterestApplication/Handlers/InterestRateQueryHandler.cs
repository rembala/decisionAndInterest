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
        private readonly IInterestRateService _interestRateService;

        public InterestRateQueryHandler(IInterestRateValidation interestRateValidation, IInterestRateService interestRateService)
        {
            _interestRateValidation = interestRateValidation;
            _interestRateService = interestRateService;
        }

        public async Task<InterestRateResponse> Handle(InterestRateQuery request, CancellationToken cancellationToken)
        {
            _interestRateValidation.Validate(request.totalFutureDebt);

            var result = await _interestRateService.GetInterestRateBasedOnFutureDebtAsync(request.totalFutureDebt.Value);

            var response = new InterestRateResponse { InterestRate = result.Rate };

            return response;
        }
    }
}
