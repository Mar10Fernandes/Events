using Events.Domain;
using Events.Domain.Interfaces;
using Events.Repository.MongoDB;
using Events.Repository.MongoDB.Base.Connection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace Events.API
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                // reloadOnChange: true is required for config changes to be detected.
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSingleton<IConfiguration>(Configuration);

            // Add Repository MongoDB
            // Config
            services.AddScoped<IConfig, Config>();
            // Connect
            services.AddScoped<IConnect, Connect>();

            // Repositories
            // TODO: The injection should be based on an interface to respect standards instead of abstract class
            services.AddScoped<EventsRepositoryAbst, EventsRepository>();

            // Domains
            services.AddScoped<IEventsDomain, EventsDomain>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();
        }
    }
}
