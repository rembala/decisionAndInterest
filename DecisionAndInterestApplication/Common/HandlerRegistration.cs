using DecisionAndInterestApplication.Helpers;
using DecisionAndInterestApplication.Interfaces.Helpers;
using DecisionAndInterestApplication.Interfaces.Repositories;
using DecisionAndInterestApplication.Interfaces.Validations;
using DecisionAndInterestApplication.Validations;
using Microsoft.Extensions.DependencyInjection;

namespace DecisionAndInterestApplication.Common
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterRequestHandlers(
            this IServiceCollection services)
        {
            services.AddScoped<IDecisionValidation, DecisionValidation>();
            services.AddScoped<IDecisionHelper, DecisionHelper>();
            services.AddScoped<IInterestRateValidation, InterestRateValidation>();
            services.AddScoped<IInterestRateHelper, InterestRateHelper>();

            return services
                .AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Dependencies).Assembly));
        }
    }
}
