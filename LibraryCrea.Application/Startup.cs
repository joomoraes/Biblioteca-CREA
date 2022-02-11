using AutoMapper;
using LibraryCrea.CrossCutting.DependencyInjection;
using LibraryCrea.CrossCutting.Mappings;
using LibraryCrea.Domain.Security;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace application
{
    internal class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureService.ConfigureDependencieService(services);
            ConfigureRepository.ConfigureDependenciesRepository(services);

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelProfile());
                cfg.AddProfile(new EntityToDtoProfile());
                cfg.AddProfile(new ModelToEntityProfile());
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            var signingConfiguration = new SigningConfigurations();
            services.AddSingleton(signingConfiguration);

//        

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("CREA", new OpenApiInfo
                {

                    Version = "CREA",
                    Title = "CREA",
                    Description = "CREA",
                    TermsOfService = new Uri("https://www.crea-mt.org.br/portal/"),
                    Contact = new OpenApiContact
                    {
                        Name = "Contato",
                        Email = " ",
                        Url = new Uri("https://www.crea-mt.org.br/portal/")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "----",
                        Url = new Uri("https://www.crea-mt.org.br/portal/")
                    }
                });




            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            if (!env.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();

            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();


            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/Liberali/swagger.json", "API Farm4All Mobile");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}