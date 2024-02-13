using DecisionAndInterestApplication.Interfaces.Validations;

namespace DecisionAndInterestApplication.Validations
{
    public class InterestRateValidation : IInterestRateValidation
    {
        public void Validate(int? amount)
        {
            throw new ArgumentException("Amount cannot be null!");
        }
    }
}
