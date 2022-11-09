using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Psychology.Core;
using Psychology.Core.Services.Data;
using Psychology.Core.Services.Rest;
using Psychology.Data;
using Psychology.Services.Data;
using Psychology.Services.Rest;
using System.Linq;

namespace Psychology
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRouting(options => options.LowercaseUrls = true);
            var mode = Configuration["Environment:Mode"];
            services.AddDbContext<PsychologyDbContext>(options =>
                  options.UseSqlServer(Configuration.GetConnectionString("Default" + mode),
                  x => x.MigrationsAssembly("Psychology.Data")));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IAdminService, AdminService>();
            services.AddTransient<IQuestionService, QuestionService>();

            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IEmailService>(provider => new EmailService(Configuration));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Reader API", Version = "V1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                c.OrderActionsBy(x => x.RelativePath);
            });
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

            });

            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }

        // dotnet ef migrations add init -c PsychologyDbContext -p .\Psychology.Data\Psychology.Data.csproj -s .\Psychology\Psychology.csproj
        // dotnet ef database update -c PsychologyDbContext -p .\Psychology.Data\Psychology.Data.csproj -s .\Psychology\Psychology.csproj
    }
}
