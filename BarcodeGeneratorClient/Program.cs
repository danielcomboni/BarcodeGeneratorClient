using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BarcodeGeneratorClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            //builder.Services.AddScoped<IPrintingService, PrintingService>();

            //builder.Services.AddScoped < IGeneratorService , GeneratorService >( ) ;



            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //await builder.Build().RunAsync();

            var uri = builder.HostEnvironment;
            Console.WriteLine("host env: " + uri);
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://barcodegeneratorapi.azurewebsites.net/") });

            //builder.Services.AddScoped<INavigate, Navigate>();
            //builder.Services.AddScoped<ICountryDataService, CountryDataService>();
            //builder.Services.AddScoped<IJobCategoryDataService, JobCategoryDataService>();

            await builder.Build().RunAsync();



        }
    }
}
