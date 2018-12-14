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
            //开启一个执行计划
            scheduler.Start();
            //job 作业任务
            var job = JobBuilder.Create<HelloJob>().Build();
            //tigger 触发
            var trigger = TriggerBuilder.Create().WithSimpleSchedule(x=>x.WithIntervalInSeconds(2).RepeatForever()).Build();
            //将作业任务和触发器添加到执行计划
            scheduler.ScheduleJob(job, trigger);

            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}
