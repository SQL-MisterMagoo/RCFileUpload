using FileUpload.Client.Services;
using FileUpload.Core.Services;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace FileUpload.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IWeatherForecastService, WeatherForecastService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<Core.Components.App>("app");
        }
    }
}
