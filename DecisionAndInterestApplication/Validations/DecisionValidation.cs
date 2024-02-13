using DecisionAndInterestApplication.Interfaces.Validations;

namespace DecisionAndInterestApplication.Validations
{
    public class DecisionValidation : IDecisionValidation
    {
        public void Validate(int? amount)
        {
            if (!amount.HasValue)
            {
                throw new ArgumentException("Amount cannot be null!");
            }
        }
    }
}
