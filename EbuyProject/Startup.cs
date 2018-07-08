using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;
using EbuyProject.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using Microsoft.Extensions.Configuration;

namespace EbuyProject
{
	public class Startup
	{
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy("AllowSpecificOrigin",
					builder => builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader().AllowCredentials());
			});

			//services.AddMvc();
			services.AddMvc()
			 .AddJsonOptions(options =>
			 {
				 options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
				 options.SerializerSettings.ContractResolver = new DefaultContractResolver();
			 });

            //var connection = @"Server=(localdb)\mssqllocaldb;Database=EbuyDb;Trusted_Connection=True;ConnectRetryCount=0";
            //services.AddDbContext<EbuyContext>(options => options.UseSqlServer(connection));

            services.AddDbContext<EbuyContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
        }

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory,
			EbuyContext ctx)
		{

			//loggerFactory.AddConsole();

			//if (env.IsDevelopment())
			//{
			//	app.UseDeveloperExceptionPage();
			//}

			//app.Run(async (context) =>
			//{
			//	await context.Response.WriteAsync("Hello World!");
			//});
			app.UseCors("AllowSpecificOrigin");

			app.Use(async (context, next) =>
			{
				await next();
				if (context.Response.StatusCode == 404 &&
				   !Path.HasExtension(context.Request.Path.Value) &&
				   !context.Request.Path.Value.StartsWith("/api/"))
				{
					context.Request.Path = "/index.html";
					await next();
				}
			});
			app.UseMvcWithDefaultRoute();
			app.UseDefaultFiles();
			app.UseStaticFiles();

            ctx.Database.EnsureCreated();
			ctx.EnsureSeedDataForContext();

		}
	}
}
