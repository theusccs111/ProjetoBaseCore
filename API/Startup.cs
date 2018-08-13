using API.Core.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API
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
            //var hostName = System.Net.Dns.GetHostName();
            //if (hostName == "Annon")
            //{
            //    var connection = @"Server=ANNON\SQLEXPRESS;Database=RepublicManager;Trusted_Connection=True;ConnectRetryCount=0";
            //    services.AddDbContext<Contexto>(options => options.UseSqlServer(connection));
            //}
            //else
            //{
            //    var connection = @"Server=DESKTOP-OCC8KVA\SQLEXPRESS;Database=RepublicManager;Trusted_Connection=True;ConnectRetryCount=0";
            //    services.AddDbContext<Contexto>(options => options.UseSqlServer(connection));
            //}
            //injeção de dependencia
            //services.AddScoped<>()
            services.AddScoped<IUsuarioRepositorio, IUsuarioRepositorio>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
