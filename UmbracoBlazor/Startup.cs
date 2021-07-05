using UmbracoBlazor.Models;
using UmbracoBlazor.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Web.Common;
using Umbraco.Extensions;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Configuration;

namespace UmbracoBlazor
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _config;

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="webHostEnvironment">The Web Host Environment</param>
        /// <param name="config">The Configuration</param>
        /// <remarks>
        /// Only a few services are possible to be injected here https://github.com/dotnet/aspnetcore/issues/9337
        /// </remarks>
        public Startup(IWebHostEnvironment webHostEnvironment, IConfiguration config)
        {
            _env = webHostEnvironment ?? throw new ArgumentNullException(nameof(webHostEnvironment));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        /// <summary>
        /// Configures the services
        /// </summary>
        /// <remarks>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        /// </remarks>
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddUmbraco(_env, _config)
                .AddBackOffice()
                .AddWebsite()
                .AddComposers()
                .Build();


            services.AddDbContext<AppDbContext>(options =>
       options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddRazorPages();
            services.AddServerSideBlazor().AddCircuitOptions(e =>
            {
                e.DetailedErrors = true;
            });

            services.AddBlazoredSessionStorage();

            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.Configure<RazorPagesOptions>(options => options.RootDirectory = "/BlazorComponents");


        }

        /// <summary>
        /// Configures the application
        /// </summary>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseUmbraco()
                .WithMiddleware(u =>
                {
                    u.WithBackOffice();
                    //  u.WithWebsite();
                })
                .WithEndpoints(u =>
                {
                    u.UseInstallerEndpoints();
                    u.UseBackOfficeEndpoints();
                    //u.UseWebsiteEndpoints();
                });


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
