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

namespace RedaktSkeleton.AwsMongoDbSingle.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRedakt()  // Adds generic Redakt services and common feature modules.
                .AddMongoDbDataStore()  // Adds MongoDB database services.
                .AddS3Storage();  // Adds AWS S3 storage services.
                //.AddGridFsFileStore();  // Alternative to S3: Adds MongoDB GridFS embedded storage services.
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

            app.UseResponseCompression();  // Response compression of dynamic pages is recommended.

            // Set compression & cache for static files.
            app.UseStaticFiles(new StaticFileOptions
            {
                HttpsCompression = Microsoft.AspNetCore.Http.Features.HttpsCompressionMode.Compress,
                OnPrepareResponse = context =>
                {
                    var headers = context.Context.Response.GetTypedHeaders();
                    headers.CacheControl = new Microsoft.Net.Http.Headers.CacheControlHeaderValue
                    {
                        Public = true,
                        MaxAge = TimeSpan.FromDays(30)
                    };
                }
            });

            app.UseRouting();
                                    
            app.UseAuthorization();  // UseAuthorization required for projects with back office.

            // Redakt middleware
            app.UseRedaktUrlManagement();  // Remove this line (and the package) if you do not want to use Redakt URL management.
            app.UseRedaktIdentityServer();
            app.UseRedaktBackOffice();
            app.UseRedaktPageRendering();  // Remove this line if you do not want to use Redakt page (Razor template) rendering.
            app.UseRedaktContentApi();  // Remove this line (and the package) if you do not want to use the Redakt Content Delivery API.
            app.UseRedaktSitemapXml();  // Remove this line if you do not want Redakt to automaticaly generate a sitemap.xml.
        }
    }
}
