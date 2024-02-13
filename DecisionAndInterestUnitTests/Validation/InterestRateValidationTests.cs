using DecisionAndInterestApplication.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionAndInterestUnitTests.Validation
{
    public class InterestRateValidationTests
    {
        [Test]
        public void Validate_FutureDebtIsNull_ShouldThrowAnException()
        {
            var decisionValidation = new InterestRateValidation();

            Assert.Throws<ArgumentException>(() => decisionValidation.Validate(null));
        }

        [Test]
        public void Validate_FutureDebtIsNotNull_ShouldNotThrowAnException()
        {
            var decisionValidation = new InterestRateValidation();

            Assert.DoesNotThrow(() => decisionValidation.Validate(232));
        }

        [Test]
        public void Validate_FutureDebtIsZero_ShouldThrowAnException()
        {
            var decisionValidation = new InterestRateValidation();

            Assert.Throws<ArgumentException>(() => decisionValidation.Validate(0));
        }
    }
}
