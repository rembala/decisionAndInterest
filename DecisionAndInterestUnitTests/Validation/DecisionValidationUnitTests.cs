using DecisionAndInterestApplication.Validations;

namespace DecisionAndInterestUnitTests.Validation
{
    public class DecisionValidationUnitTests
    {
        [Test]
        public void Validate_AmountIsNull_ShouldThrowAnException()
        {
            var decisionValidation = new DecisionValidation();

            Assert.Throws<ArgumentException>(() => decisionValidation.Validate(null, 212));
        }

        [Test]
        public void Validate_AmountIsNotNullButPreExistingIsNull_ShouldThrowAnException()
        {
            var decisionValidation = new DecisionValidation();

            Assert.Throws<ArgumentException>(() => decisionValidation.Validate(232, null));
        }

        [Test]
        public void Validate_PreExistingAmountAndCreditAmountIsNotNull_ShouldNotThrowAnException()
        {
            var decisionValidation = new DecisionValidation();

            Assert.DoesNotThrow(() => decisionValidation.Validate(12, 212));
        }

        [Test]
        public void Validate_AmountIsZero_ShouldThrowAnException()
        {
            var decisionValidation = new DecisionValidation();

            Assert.Throws<ArgumentException>(() => decisionValidation.Validate(0, 212));
        }

        [Test]
        public void Validate_PreExistingIsZero_ShouldThrowAnException()
        {
            var decisionValidation = new DecisionValidation();

            Assert.Throws<ArgumentException>(() => decisionValidation.Validate(12213, 0));
        }
    }
}
