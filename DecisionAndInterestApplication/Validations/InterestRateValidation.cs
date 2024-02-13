using DecisionAndInterestApplication.Interfaces.Validations;

namespace DecisionAndInterestApplication.Validations
{
    public class InterestRateValidation : IInterestRateValidation
    {
        public void Validate(int? futureDebt)
        {
            if (!futureDebt.HasValue)
            {
                throw new ArgumentException("Total future debt cannot be null!");
            }
        }
    }
}
