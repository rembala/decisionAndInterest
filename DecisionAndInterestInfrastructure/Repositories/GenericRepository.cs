using DecisionAndInterestApplication.Interfaces.Repositories;
using DecisionAndInterestDomain.Common;

namespace DecisionAndInterestInfrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public Task<T> InsertAsync(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
