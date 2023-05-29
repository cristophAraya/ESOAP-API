using Quartz.Spi;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzESoap.JobFactory
{
    class MyJobFactory : IJobFactory
    {
        private readonly IServiceProvider serviceProvider;

        public MyJobFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            var jobDetail = bundle.JobDetail;
            return (IJob)serviceProvider.GetService(jobDetail.JobType);
        }

        public void ReturnJob(IJob job)
        {

        }
    }
}
