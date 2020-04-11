using System.Net;
using ClubSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using ClubSite.Repository;
using Microsoft.EntityFrameworkCore;

namespace ClubSite
{
    public class Startup
    {
        private readonly string _spaSourcePath;
        private readonly string _corsPolicyName;

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _spaSourcePath = Configuration.GetValue<string>("SPA:SourcePath");
            _corsPolicyName = Configuration.GetValue<string>("CORS:PolicyName");
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Register RazorPages/Controllers
            services.AddControllers();

            // Add Brotli/Gzip response compression (prod only)
            //services.AddResponseCompressionConfig(Configuration);

            // IMPORTANT CONFIG CHANGE IN 3.0 - 'Async' suffix in action names get stripped by default - so, to access them by full name with 'Async' part - opt out of this feature'.
            services.AddMvc(options => options.SuppressAsyncSuffixInActionNames = false);

            // In production, the Vue files will be served from this directory
            services.AddSpaStaticFiles(configuration => configuration.RootPath = $"{_spaSourcePath}/dist");

            // Register
            services.AddDbContext<Context>(options =>
            {
                options.UseMySQL(Configuration.GetConnectionString("Default"));
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // If development, enable Hot Module Replacement
            // If production, enable Brotli/Gzip response compression & strict transport security headers
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // There does not yet appear to be a finalized solution to replace this obselete framework.
                // app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                // {
                //     HotModuleReplacement = true
                // });
            }
            else
            {
                app.UseResponseCompression();
                app.UseExceptionHandler("/Error");
                app.UseHttpsRedirection();
                app.UseHsts();
            }

            // Global exception handling
            app.UseExceptionHandler(builder =>
            {
                builder.Run(async context =>
                {
                    var error = context.Features.Get<IExceptionHandlerFeature>();
                    var exDetails = new ExceptionDetails((int)HttpStatusCode.InternalServerError, error?.Error.Message);

                    context.Response.ContentType = "application/json";
                    context.Response.StatusCode = exDetails.StatusCode;
                    context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                    context.Response.Headers.Add("Application-Error", exDetails.Message);
                    context.Response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");

                    await context.Response.WriteAsync(exDetails.ToString());
                });
            });

            app.UseCors(_corsPolicyName);
            app.UseStaticFiles();

            app.UseSpaStaticFiles();
            app.UseRouting();

            // Map controllers
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = _spaSourcePath;

                if (env.IsDevelopment())
                    spa.UseReactDevelopmentServer(npmScript: "start");
            });
        }
    }
}
