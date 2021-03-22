using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace dotnet5isolated
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .Build();

            await host.RunAsync();
        }
    }
}