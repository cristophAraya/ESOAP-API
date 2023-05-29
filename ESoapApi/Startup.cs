

using Cl.Propal.Sincronizacion.Helpers.Producers;
using Cl.Sura.ESoapApi.Data.Confirmar;
using Cl.Sura.ESoapApi.Data.ConfirmarCalculo;
using Cl.Sura.ESoapApi.Data.ConfirmarEvaluacion;
using Cl.Sura.ESoapApi.Data.ConfirmarPago;
using Cl.Sura.ESoapApi.Data.ConsultaSiniestro;
using Cl.Sura.ESoapApi.Data.Evento;
using Cl.Sura.ESoapApi.Data.Persona;
using Cl.Sura.ESoapApi.Data.Poliza;
using Cl.Sura.ESoapApi.Data.RegistroCalculo;
using Cl.Sura.ESoapApi.Data.RegistroDenuncio;
using Cl.Sura.ESoapApi.Data.RegistroEvaluacion;
using Cl.Sura.ESoapApi.Data.RegistroPago;
using Cl.Sura.ESoapApi.Data.RegistroReclamante;
using Cl.Sura.ESoapApi.Helpers.Base;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System.IO;
using System.Reflection;

namespace Cl.Sura.ESoapApi
{
    public class Startup
    {
        readonly string PermitirSitios = "PermitirSitios";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: PermitirSitios,
                builder =>
                {
                    builder.AllowAnyHeader();
                    builder.AllowAnyMethod();
                    builder.AllowAnyOrigin();
                });
            });

            services.Configure<SettingsConfig>(Configuration.GetSection(nameof(SettingsConfig)));


            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            services.AddSingleton<ISettingsConfig>(provider => provider.GetRequiredService<IOptions<SettingsConfig>>().Value);

        
            services.AddSingleton<IRabbitProducer, RabbitProducer>();

            services.AddSingleton<IPolizaService, PolizaService>();
            services.AddSingleton<IPolizaRepository, PolizaRepository>();
            services.AddSingleton<IPersonaService, PersonaService>();
            services.AddSingleton<IPersonaRepository, PersonaRepository>();
            services.AddSingleton<IEventoService, EventoService>();
            services.AddSingleton<IEventoRepository, EventoRepository>();
            services.AddSingleton<IRegistroEvaluacionService, RegistroEvaluacionService>();
            services.AddSingleton<IRegistroEvaluacionRepository, RegistroEvaluacionRepository>();

            services.AddSingleton<IRegistroDenuncioService, RegistroDenuncioService>();
            services.AddSingleton<IRegistroDenuncioRepository, RegistroDenuncioRepository>();
            services.AddSingleton<IRegistroReclamanteService, RegistroReclamanteService>();
            services.AddSingleton<IRegistroReclamanteRepository, RegistroReclamanteRepository>();

            services.AddSingleton<IConsultaSiniestroService, ConsultaSiniestroService>();
            services.AddSingleton<IConsultaSiniestroRepository, ConsultaSiniestroRepository>();

            services.AddSingleton<IConfirmarService, ConfirmarService>();
            services.AddSingleton<IConfirmarRepository, ConfirmarRepository>();


            services.AddSingleton<IRegistroCalculoService, RegistroCalculoService>();
            services.AddSingleton<IRegistroCalculoRepository, RegistroCalculoRepository>();
            services.AddSingleton<IConfirmarCalculoService, ConfirmarCalculoService>();
            services.AddSingleton<IConfirmarCalculoRepository, ConfirmarCalculoRepository>();

            services.AddSingleton<IRegistroPagoService, RegistroPagoService>();
            services.AddSingleton<IRegistroPagoRepository, RegistroPagoRepository>();

            services.AddSingleton<IConfirmarPagoService, ConfirmarPagoService>();
            services.AddSingleton<IConfirmarPagoRepository, ConfirmarPagoRepository>();



            services.AddSingleton<IConfirmarEvaluacionService, ConfirmarEvaluacionService>();
            services.AddSingleton<IConfirmarEvaluacionRepository, ConfirmarEvaluacionRepository>();
            


            services.AddControllers()
                   .AddJsonOptions(options =>
                   {
                       options.JsonSerializerOptions.IgnoreNullValues = true;
                   });

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api SURA E-SOAP", Version = "v1" });

                c.AddSecurityDefinition("ApiKey", new
           OpenApiSecurityScheme()
                {
                    Type = SecuritySchemeType.ApiKey,
                    In = ParameterLocation.Header,
                    Name = "XApiKey",
                    Description = "API Key",
                    Scheme = "ApiKeyScheme"
                });
                var key = new OpenApiSecurityScheme()
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "ApiKey"
                    },
                    In = ParameterLocation.Header
                };

                var requirement = new OpenApiSecurityRequirement
                {
                    { key, new List<string>() }
                };
                c.AddSecurityRequirement(requirement);
                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //c.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            var path = Directory.GetCurrentDirectory();
            loggerFactory.AddFile($"{path}\\Logs\\Log.txt");


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(PermitirSitios);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
