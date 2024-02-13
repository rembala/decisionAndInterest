using DecisionAndInterestApplication.Helpers;
using DecisionAndInterestApplication.Interfaces.Helpers;
using DecisionAndInterestApplication.Interfaces.Repositories;
using DecisionAndInterestApplication.Interfaces.Validations;
using DecisionAndInterestApplication.Validations;
using DecisionAndInterestInfrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DecisionAndInterestInfrastructure.Common.Registrations
{
    public static class RepositoryDependencies
    {
        public static IServiceCollection RegisterRepositories(
            this IServiceCollection services)
        {
            services.AddScoped<IDecisionRepository, DecisionRepository>();
            services.AddScoped<IInterestRateRepository, InterestRateRepository>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}
