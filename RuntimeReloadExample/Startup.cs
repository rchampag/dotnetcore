using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RuntimeReloadExample
{
    public class Startup
    {
        IConfigurationRoot Configuration { get; }

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(System.AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<MySettings>(Configuration.GetSection("MyProperties"));
            //services.AddTransient(cfg => cfg.GetService<IOptionsSnapshot<MySettings>>().Value);
            services.AddOptions();
            services.AddTransient<IMyService, MyService>();
        }
    }
}
