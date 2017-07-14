using Microsoft.Extensions.DependencyInjection;
using System;

namespace RuntimeReloadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            Startup startup = new Startup();
            startup.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();


            while (true)
            {
                using (var scope = serviceProvider.CreateScope())
                {
                    var service = scope.ServiceProvider.GetService<IMyService>();
                    var reply = service.DoSomething();

                    Console.WriteLine(reply);

                    Console.WriteLine("Press enter to exit, any other key to repeat...");

                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Enter)
                        break;
                }

            }
        }
    }
}