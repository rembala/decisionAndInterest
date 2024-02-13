
using DecisionAndInterestDomain.Entities;

namespace DecisionAndInterestApplication.Interfaces.Helpers
{
    public interface IInterestRateService
    {
        Task<InterestRate> GetInterestRateBasedOnFutureDebtAsync(int futureDebt);
    }
}
