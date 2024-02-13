using DecisionAndInterestApplication.Interfaces.Repositories;
using DecisionAndInterestDomain.Entities;

namespace DecisionAndInterestInfrastructure.Repositories
{
    public class InterestRateRepository : IInterestRateRepository
    {
        private readonly IGenericRepository<InterestRate> _genericDecisionRepository;

        public InterestRateRepository(IGenericRepository<InterestRate> genericDecisionRepository)
        {
            _genericDecisionRepository = genericDecisionRepository;
        }

        public List<InterestRate> GetInterestRates()
        {
            var interestRates = new List<InterestRate> {
                new InterestRate { Id = 1, Amount = 3 },
                new InterestRate { Id = 2, Amount = 4 },
                new InterestRate { Id = 3, Amount = 5 },
                new InterestRate { Id = 4, Amount = 6 }
            };

            return interestRates;
        }

        public async Task InsertNewInterestRate(InterestRate interestRate)
        {
            await _genericDecisionRepository.InsertAsync(interestRate);
        }
    }
}
