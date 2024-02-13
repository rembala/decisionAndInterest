using DecisionAndInterestApplication.Common.Constants;
using DecisionAndInterestApplication.Interfaces.Helpers;
using DecisionAndInterestApplication.Interfaces.Repositories;
using DecisionAndInterestDomain.Entities;

namespace DecisionAndInterestApplication.Helpers
{
    public class InterestRateHelper : IInterestRateHelper
    {
        private readonly IInterestRateRepository _interestRateRepository;

        public InterestRateHelper(IInterestRateRepository interestRateRepository)
        {
            _interestRateRepository = interestRateRepository;
        }

        public async Task<InterestRate> GetInterestRateBasedOnFutureDebt(int amount)
        {
            var interestRates = _interestRateRepository
                .GetInterestRates()
                .ToDictionary(key => key.Amount, decision => decision.Amount);

            var interestRate = GetnterestRate(amount, interestRates);

            return await Task.FromResult(new InterestRate {  Amount = interestRate });
        }

        private int GetnterestRate(int amount, Dictionary<int, int> interestRates)
        {
            if (amount < 20000)
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
