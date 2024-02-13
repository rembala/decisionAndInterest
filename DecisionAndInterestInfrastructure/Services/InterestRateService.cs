using DecisionAndInterestApplication.Common.Constants;
using DecisionAndInterestApplication.Interfaces.Helpers;
using DecisionAndInterestApplication.Interfaces.Repositories;
using DecisionAndInterestDomain.Entities;

namespace DecisionAndInterestInfrastructure.Services
{
    public class InterestRateService : IInterestRateService
    {
        private readonly IInterestRateRepository _interestRateRepository;

        public InterestRateService(IInterestRateRepository interestRateRepository)
        {
            _interestRateRepository = interestRateRepository;
        }

        public async Task<InterestRate> GetInterestRateBasedOnFutureDebtAsync(int futureDebt)
        {
            var interestRates = _interestRateRepository
                .GetInterestRates()
                .ToDictionary(key => key.Rate, decision => decision.Rate);

            var interestRate = GetnterestRate(futureDebt, interestRates);

            return await Task.FromResult(new InterestRate { Rate = interestRate });
        }

        private int GetnterestRate(int amount, Dictionary<int, int> interestRates)
        {
            if (amount <= 20000)
            {
                return interestRates[InterestRateConstants.Three];
            }

            if (amount > 20000 && amount < 39000)
            {
                return interestRates[InterestRateConstants.Four];
            }

            if (amount > 40000 && amount < 59000)
            {
                return interestRates[InterestRateConstants.Five];
            }

            if (amount > 60000)
            {
                return interestRates[InterestRateConstants.Six];
            }

            throw new Exception($"{amount} is not valid");
        }
    }
}
