using DecisionAndInterestApplication.Interfaces.Helpers;
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
            services.AddScoped<IInterestRateValidation, InterestRateValidation>();

            return services
                .AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Dependencies).Assembly));
        }
    }
}
