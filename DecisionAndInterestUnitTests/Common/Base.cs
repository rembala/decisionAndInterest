using Moq;

namespace DecisionAndInterestUnitTests.Common
{
    public abstract class Base<T> where T : class
    {
        protected Mock<T> _repository = new Mock<T>(MockBehavior.Strict);
    }
}
