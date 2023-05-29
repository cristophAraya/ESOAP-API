

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Quartz.Impl;
using Quartz.Spi;
using Quartz;
using QuartzESoap.Models;
using QuartzESoap.Schedular;
using QuartzESoap.JobFactory;
using Cl.Sura.QuartzESoap.Jobs;

namespace QuartzESoap
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<IJobFactory, MyJobFactory>();
                    services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();

                    #region Adding JobType
                    services.AddSingleton<NotificationJob>();
                    //services.AddSingleton<LoggerJob>();
                    #endregion

                    #region Adding Jobs 
                    List<JobMetadata> jobMetadatas = new List<JobMetadata>();
                    //jobMetadatas.Add(new JobMetadata(Guid.NewGuid(), typeof(NotificationJob), "INICIA PROCESO E-SOAP", "0/30 * * * * ?"));
                    jobMetadatas.Add(new JobMetadata(Guid.NewGuid(), typeof(NotificationJob), "INICIA PROCESO E-SOAP", "0 10 14 ? * *")); // A LAS 17:40, TODOS LOS DIAS

                    services.AddSingleton(jobMetadatas);
                    #endregion

                    services.AddHostedService<MySchedular>();
                });
    }
}
