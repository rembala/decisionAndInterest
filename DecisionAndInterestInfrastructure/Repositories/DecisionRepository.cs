using DecisionAndInterestApplication.Interfaces.Repositories;
using DecisionAndInterestDomain.Entities;

namespace DecisionAndInterestInfrastructure.Repositories
{
    public class DecisionRepository : IDecisionRepository
    {
        private readonly IGenericRepository<Decision> _genericDecisionRepository;

        public DecisionRepository(IGenericRepository<Decision> genericDecisionRepository)
        {
            _genericDecisionRepository = genericDecisionRepository;
        }

        public List<Decision> GetDecisions() {
            var decisions = new List<Decision> {
                new Decision { Id = 1, Title = "No" },
                new Decision { Id = 2, Title = "Yes" }
            };

            return decisions;
        }

        public async Task InsertNewDecision(Decision decision) {
            await _genericDecisionRepository.InsertAsync(decision);
        }
    }
}
