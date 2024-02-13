using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionAndInterestApplication.Interfaces.Validations
{
    public interface IInterestRateValidation
    {
        void Validate(int? amount);
    }
}
