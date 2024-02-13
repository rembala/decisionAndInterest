using DecisionAndInterestApplication.Interfaces.Validations;

namespace DecisionAndInterestApplication.Validations
{
    public class DecisionValidation : IDecisionValidation
    {
        public void Validate(int? amount)
        {
            throw new ArgumentException("Amount cannot be null!");
        }
    }
}
