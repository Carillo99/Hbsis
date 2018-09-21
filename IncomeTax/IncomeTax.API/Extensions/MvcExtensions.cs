using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO.Compression;

namespace IncomeTax.API.Extensions
{
    public static class MvcExtensions
    {
        public static void AddMvcWithCustomConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            #region CodigoAntingo
            services.Configure<IISOptions>(o =>
            {
                o.ForwardClientCertificate = false;
            });

            //// Configura o modo de compressão
            services.Configure<GzipCompressionProviderOptions>(
                options => options.Level = CompressionLevel.Optimal
            );

            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
               // options.EnableForHttps = true;
            });

            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            });
            
            #endregion
        }
    }
}
