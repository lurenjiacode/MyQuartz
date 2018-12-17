using Quartz;
using Quartz.Impl;
using Quartz.Impl.Matchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuartz.MyTest
{
    public class Test
    {
        public void start()
        {

            //Scheduler 调度
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            //开启一个执行计划
            scheduler.Start();

            //job 作业任务
            var job = JobBuilder.Create<HelloJob>().Build();

            //tigger 触发（一个job可以有多个tigger）
            var trigger = TriggerBuilder.Create().WithSimpleSchedule(x => x.WithIntervalInSeconds(2).RepeatForever()).Build();


            //任务监听
            scheduler.ListenerManager.AddJobListener(new MyJobListen(),GroupMatcher<JobKey>.AnyGroup());

            //将作业任务和触发器添加到执行计划
            scheduler.ScheduleJob(job, trigger);

        }
    }
}
