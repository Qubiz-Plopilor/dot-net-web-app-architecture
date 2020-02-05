using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Toucan.API.Infrastructure.Middlewares;
using WebApp.API.Infrastructure.Middlewares;
using WebApp.Core.Domain.Contracts;
using WebApp.Core.Domain.Services;
using WebApp.Core.Domain.Services.DBContext;
using WebApp.Core.Services;
using WebApp.Core.Services.Contracts;

namespace WebApp.API
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
            // Logging
            services.AddLogging();

            // Enable Cors
            services.AddCors(o => o.AddPolicy("CORS_Policy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ApplicationDbContext")));

            // Routing
            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });

            // Add MVC
            services.AddControllers();

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    options.SerializerSettings.Converters.Add(new StringEnumConverter());
                    options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Include;
                });

            // add OpenAPI v3 document
            services.AddSwaggerDocument(c =>
            {
                c.Title = "Stories API";
                c.Description = "Stories API management";
                c.Version = "v1";
            });

            // SignalR
            services.AddSignalR(hubOptions =>
            {
                //hubOptions.EnableDetailedErrors = true;
                //hubOptions.KeepAliveInterval = TimeSpan.FromMinutes(1);
            })
            .AddJsonProtocol(options =>
            {
                options.PayloadSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });            

            RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //else
            //{
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();

            app.UseStaticFiles();

            //app.MapWhen(context => context.Request.Path.StartsWithSegments("/assets"), 
            //    appBuilder => appBuilder.UseStaticFiles());

            app.UseCors("CORS_Policy");

            app.UseAuthentication();
            app.UseAuthorization();
            
            // Add the Swagger UI middleware
            app.UseOpenApi();
            app.UseSwaggerUi3(settings =>
            {
                //settings.SwaggerRoutes.Add(new SwaggerUi3Route("default", "/"));
            });

            // Add Exception handling

            // Split the middleware pipeline
            //app.MapWhen(context => context.Request.Path.StartsWithSegments("/api/articles"), appBuilder =>
            //{
            //    appBuilder.UseApiExceptionMiddleware();
            //});

            //app.UseWhen(context => context.Request.Path.StartsWithSegments("/api/articles"), appBuilder =>
            //{
            //    appBuilder.UseApiExceptionMiddleware();
            //});

            //app.UseMiddleware<ApiExceptionMiddleware>();

            app.UseApiExceptionMiddleware();

            //app.UseMiddleware<CustomTestMiddleware>();

            // Add MVC
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton(Configuration);
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ITagService, TagService>();
        }
    }
}
