using Refit;
using UI.Services.Refit;

namespace UI.Extension
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            #region Refit

            services.AddRefitClient<IAccountService>()
                   .ConfigureHttpClient(c =>
                   {
                       c.BaseAddress = new Uri(config.GetSection("ApiServiceUrls:APIUrl").Value);
                   });          
            #endregion

            return services;
        }
    }
}
