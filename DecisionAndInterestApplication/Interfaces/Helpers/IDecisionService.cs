using DecisionAndInterestDomain.Entities;

namespace DecisionAndInterestApplication.Interfaces.Helpers
{
    public interface IDecisionService
    {
        Task<Decision> GetDecisionBasedOnAppliedAmountAsync(int amount);
    }
}
