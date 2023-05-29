

using CharlesApi.Data.Beneficiario;
using CharlesApi.Data.CoberturaSiniestrada;
using CharlesApi.Data.Liquidar;
using CharlesApi.Data.Participante;
using CharlesApi.Data.Reclamante;
using CharlesApi.Data.Siniestro;
using CharlesApi.Data.SiniestroLog;
using CharlesApi.Data.TipoEvento;
using CharlesApi.Data.TipoReclamante;
using CharlesApi.Helpers.Base;
using CharlesApi.Repository.Beneficiario;
using CharlesApi.Repository.CoberturaSiniestrada;
using CharlesApi.Repository.Participante;
using CharlesApi.Repository.Reclamante;
using CharlesApi.Repository.Siniestro;
using CharlesApi.Repository.SiniestroLog;
using CharlesApi.Repository.TipoEvento;
using CharlesApi.Repository.TipoReclamante;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System.IO;
using System.Reflection;

namespace CharlesApi
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


            services.AddSingleton<ISiniestroService, SiniestroService>();
            services.AddSingleton<ISiniestroRepository, SiniestroRepository>();

            services.AddSingleton<IReclamanteService, ReclamanteService>();
            services.AddSingleton<IReclamanteRepository, ReclamanteRepository>();

            services.AddSingleton<IParticipanteService, ParticipanteService>();
            services.AddSingleton<IParticipanteRepository, ParticipanteRepository>();

            services.AddSingleton<ICoberturaSiniestradaService, CoberturaSiniestradaService>();
            services.AddSingleton<ICoberturaSiniestradaRepository, CoberturaSiniestradaRepository>();

            services.AddSingleton<IBeneficiarioService, BeneficiarioService>();
            services.AddSingleton<IBeneficiarioRepository, BeneficiarioRepository>();

            services.AddSingleton<ILiquidarService, LiquidarService>();

            services.AddSingleton<ISiniestroLogService, SiniestroLogService>();
            services.AddSingleton<ISiniestroLogRepository, SiniestroLogRepository>();
            services.AddSingleton<ITipoEventoService, TipoEventoService>();
            services.AddSingleton<ITipoEventoRepository, TipoEventoRepository>();

            services.AddSingleton<ITipoReclamanteService, TipoReclamanteService>();
            services.AddSingleton<ITipoReclamanteRepository, TipoReclamanteRepository>();

            services.AddControllers()
                   .AddJsonOptions(options =>
                   {
                       options.JsonSerializerOptions.IgnoreNullValues = true;
                   });

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api CHARLESTAYLOR E-SOAP", Version = "v1" });

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
