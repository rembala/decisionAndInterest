using DecisionAndInterestApplication.Interfaces.Validations;

namespace DecisionAndInterestApplication.Validations
{
    public class DecisionValidation : IDecisionValidation
    {
        public void Validate(int? amount, int? preExistingCreditAmount)
        {
            if (!amount.HasValue || amount == 0)
            {
                throw new ArgumentException("Amount cannot be null or zero");
            }

            if (!preExistingCreditAmount.HasValue || preExistingCreditAmount.Value == 0)
            {
                throw new ArgumentException("Pre existing amount cannot be null or zero");
            }
        }
    }
}
