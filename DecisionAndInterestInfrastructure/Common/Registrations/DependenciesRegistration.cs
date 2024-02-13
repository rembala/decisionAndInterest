using DecisionAndInterestApplication.Interfaces.Helpers;
using DecisionAndInterestApplication.Interfaces.Repositories;
using DecisionAndInterestInfrastructure.Repositories;
using DecisionAndInterestInfrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DecisionAndInterestInfrastructure.Common.Registrations
{
    public static class DependenciesRegistration
    {
        public static IServiceCollection RegisterDependencies(
            this IServiceCollection services)
        {
            services.AddScoped<IDecisionRepository, DecisionRepository>();
            services.AddScoped<IInterestRateRepository, InterestRateRepository>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IDecisionService, DecisionService>();
            services.AddScoped<IInterestRateService, InterestRateService>();

            return services;
        }
    }
}
