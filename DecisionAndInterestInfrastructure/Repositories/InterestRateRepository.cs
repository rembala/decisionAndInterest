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
                new InterestRate { Id = 1, Rate = 3 },
                new InterestRate { Id = 2, Rate = 4 },
                new InterestRate { Id = 3, Rate = 5 },
                new InterestRate { Id = 4, Rate = 6 }
            };

            return interestRates;
        }

        public async Task InsertNewInterestRate(InterestRate interestRate)
        {
            await _genericDecisionRepository.InsertAsync(interestRate);
        }
    }
}
