using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedaktSkeleton.AzureCosmosDbDistributed.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var builder = services.AddRedakt();
            builder.AddCosmosDbDataStore();
            builder.AddAzureBlobStorage();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseRedaktUrlManagement();  // Remove this line if you do not want to use Redakt URL management.
            app.UseRedaktPageRendering();  // Remove this line if you do not want to use Redakt page (Razor template) rendering.
            app.UseRedaktContentApi();  // Remove this line if you do not want to use the Redakt Content Delivery API.
            app.UseRedaktSitemapXml();  // Remove this line if you do not want Redakt to automaticaly generate a sitemap.xml.
        }
    }
}
