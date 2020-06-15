using System;
using System.Threading.Tasks;

namespace FileUpload.Core.Services
{
    public interface IWeatherForecastService
    {

        Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}
