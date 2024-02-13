using DecisionAndInterestDomain.Entities;

namespace DecisionAndInterestApplication.Interfaces.Helpers
{
    public interface IDecisionHelper
    {
        Task<Decision> GetDecisionBasedOnAppliedAmountAsync(int amount);
    }
}
