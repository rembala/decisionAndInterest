
using DecisionAndInterestDomain.Entities;

namespace DecisionAndInterestApplication.Interfaces.Repositories
{
    public interface IInterestRateRepository
    {
        List<InterestRate> GetInterestRates();
    }
}
