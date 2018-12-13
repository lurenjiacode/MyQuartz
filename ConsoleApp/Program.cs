using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");

            //Scheduler 调度
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();
            //job 作业任务
            var job = JobBuilder.Create<HelloJob>().Build();

            //tigger 出发
            var trigger = TriggerBuilder.Create().WithSimpleSchedule(x=>x.WithIntervalInSeconds(2).RepeatForever()).Build();

            scheduler.ScheduleJob(job, trigger);

            Console.WriteLine("end");
            Console.ReadKey();
        }
    }

    public class MyJobListen : IJobListener
    {
        //public string Name => throw new NotImplementedException();
        public string Name => "hello";

        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public void JobToBeExecuted(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            throw new NotImplementedException();
        }
    }
}
