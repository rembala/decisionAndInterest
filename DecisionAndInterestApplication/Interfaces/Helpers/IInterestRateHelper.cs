
using DecisionAndInterestDomain.Entities;

namespace DecisionAndInterestApplication.Interfaces.Helpers
{
    public interface IInterestRateHelper
    {
        Task<InterestRate> GetInterestRateBasedOnFutureDebt(int futureDebt);
    }
}
