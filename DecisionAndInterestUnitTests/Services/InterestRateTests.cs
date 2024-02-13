using DecisionAndInterestApplication.Interfaces.Repositories;
using DecisionAndInterestDomain.Entities;
using DecisionAndInterestInfrastructure.Services;
using DecisionAndInterestUnitTests.Common;

namespace DecisionAndInterestUnitTests.Services
{
    public class InterestRateTests : Base<IInterestRateRepository>
    {
        [Theory]
        [TestCase(1455, 3)]
        [TestCase(22000, 4)]
        [TestCase(41000, 5)]
        [TestCase(62000, 6)]
        public async Task GetInterestRateBasedOnFutureDebtAsync_FutureDebtTestCases_ShouldReturnInterestRateBasedOnFutureDebt(int futureDebt, int expectedInterestRate)
        {
            var interestRates = new List<InterestRate> { 
                new InterestRate { Rate = 3, Id = 1 },
                new InterestRate { Rate = 4, Id = 2 },
                new InterestRate { Rate = 5, Id = 3 },
                new InterestRate { Rate = 6, Id = 4 }
            };

            _repository.Setup(method => method.GetInterestRates()).Returns(interestRates);

            var interestRateService = new InterestRateService(_repository.Object);

            var result = await interestRateService.GetInterestRateBasedOnFutureDebtAsync(futureDebt);

            Assert.That(result.Rate, Is.EqualTo(expectedInterestRate));
        }
    }
}
