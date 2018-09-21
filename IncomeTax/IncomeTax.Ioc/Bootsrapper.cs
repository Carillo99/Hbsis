using IncomeTax.Domain.Repository;
using IncomeTax.Infra.Data.Interface;
using IncomeTax.Infra.Data.Repository;
using IncomeTax.Services.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IncomeTax.Ioc
{
    public static class Bootsrapper
    {
        public static void Ioc(this IServiceCollection services, IConfiguration configuration)
        {
            #region Repositorio
            LoadRepository(services, configuration);
            #endregion
        }

        private static void LoadRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IContributionIR, ContributionIR>();
            services.AddTransient<IMinimumWageRepository, MinimumWageRepository>();
            services.AddTransient<ITaxpayerRepository, TaxpayerRepository>();
            services.AddTransient<ITaxpayerIRRepository, TaxpayerIRRepository>();
            services.AddTransient<IServiceIR, ServiceIR>();
        }
    }
}
