using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RAaA.DAL.Interfaces;
using RAaA.DAL.Entities;
using RAaA.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace RAaA.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IRepository<Processor>, ProcessorRepository>();
            services.AddScoped<IRepository<RAM>, RAMRepository>();
            services.AddScoped<IRepository<PCBuild>, PCBuildRepository>();
            services.AddScoped<IUnitOfWork, EFUnitOfWork>();
            //services.AddDbContext<PCBuildContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<PCBuildContext>(options => options.UseSqlServer("Data Source=BROPC9WBJ642;Initial Catalog=PCBuild;Integrated Security=True", b=>b.MigrationsAssembly("RAaA.DAL")));

            services.AddMvc();
        }

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
