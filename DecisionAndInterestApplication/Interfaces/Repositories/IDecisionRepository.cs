
using DecisionAndInterestDomain.Entities;

namespace DecisionAndInterestApplication.Interfaces.Repositories
{
    public interface IDecisionRepository
    {
        List<Decision> GetDecisions();
    }
}
