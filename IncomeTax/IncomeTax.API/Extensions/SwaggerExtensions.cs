using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace IncomeTax.API.Extensions
{
    public static class SwaggerExtensions
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info
                {
                    Version = "V1",
                    Title = "ImcomeTax Api",
                    Description = "Documentação de uso do projeto ImcomeTax",
                    TermsOfService = "None",
                    Contact = new Contact { Name = "Gleisson Carillo", Email = "", Url = "https://www.linkedin.com/in/gleisson-carillo" }
                });

            });
        }
    }
}
