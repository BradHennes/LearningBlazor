using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace LearningBlazor.Pages.FetchData
{
    public class FetchDataBase : ComponentBase
    {
        [Inject]
        protected HttpClient HttpClient { get; set; }

        protected WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await this.HttpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }

        protected class WeatherForecast
        {
            public DateTime Date { get; set; }

            public int TemperatureC { get; set; }

            public string Summary { get; set; }

            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }
    }
}
