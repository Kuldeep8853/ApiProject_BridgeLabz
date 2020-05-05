using Manager.DriverManager;
using Manager.OwnerManager;
using Manager.PoliceManager;
using Manager.SecurityManager;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.DriverRepository;
using Repository.OwnerRepository;
using Repository.PoliceRepository;
using Repository.SecurityRepository;
using Repository.UserContext;
using Swashbuckle.AspNetCore.Swagger;

namespace ParkingLot_Problem
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
            services.AddDbContext<UserContextDB>(option => option.UseSqlServer(this.Configuration.GetConnectionString("UserDbConnection")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddTransient<IDriverManager, DriverManager>(); 
            services.AddTransient<IDriverRepository, DriverRepository>();
            services.AddTransient<IOwnerManager, OwnerManager>();
            services.AddTransient<IOwnerRepository, OwnerRepository>();
            services.AddTransient<IPoliceManager, PoliceManager>();
            services.AddTransient<IPoliceRepository, PoliceRepository>();
            services.AddTransient<ISecurityManager, SecurtyManager>();
            services.AddTransient<ISecurityRepository, SecurityRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "ParkingLot_Problem", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyAPI V1");
                });
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
