using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedaktSkeleton.AzureCosmosDbDistributed.BackOffice
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRedakt()  // Adds generic Redakt services and common feature modules.
                .AddCosmosDbDataStore()  // Adds CosmosDB database services.
                .AddAzureBlobStorage()  // Adds Azure Blob Storage services.
                .AddAzureServiceBus();  // Adds Azure Service Bus services.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
                        
            app.UseHsts();
            app.UseHttpsRedirection();

            app.UseRouting();
                                    
            app.UseAuthorization();  // UseAuthorization required for projects with back office.

            // Redakt middleware
            app.UseRedaktIdentityServer();
            app.UseRedaktBackOffice();
        }
    }
}
