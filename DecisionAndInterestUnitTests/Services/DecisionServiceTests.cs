using DecisionAndInterestApplication.Interfaces.Repositories;
using DecisionAndInterestDomain.Entities;
using DecisionAndInterestInfrastructure.Services;
using DecisionAndInterestUnitTests.Common;

namespace DecisionAndInterestUnitTests.Services
{
    public class DecisionServiceTests : Base<IDecisionRepository>
    {
        [Theory]
        [TestCase(151445, "No")]
        [TestCase(2200, "Yes")]
        [TestCase(69100, "No")]
        public async Task GetDecisionBasedOnAppliedAmountAsync_AppliedAmountTestCases_ShouldReturnDecisionBasedOnAmount(int amount, string expectedDecision) {
            var decisions = new List<Decision> { new Decision { Title = "No", Id = 1}, new Decision { Title = "Yes", Id = 2 } };
            
            _repository.Setup(method => method.GetDecisions()).Returns(decisions);

            var decisionService = new DecisionService(_repository.Object);

            var result = await decisionService.GetDecisionBasedOnAppliedAmountAsync(amount);

            Assert.That(result.Title, Is.EqualTo(expectedDecision));
        }
    }
}

