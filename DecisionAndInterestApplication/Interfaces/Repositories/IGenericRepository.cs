namespace DecisionAndInterestApplication.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> InsertAsync(T obj);
    }
}
