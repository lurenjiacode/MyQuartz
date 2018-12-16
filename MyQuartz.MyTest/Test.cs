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

            scheduler.Start();

            //job 作业任务
            var job = JobBuilder.Create<HelloJob>().Build();

            //tigger 触发（一个job可以有多个tigger）
            var trigger = TriggerBuilder.Create().WithSimpleSchedule(x => x.WithIntervalInSeconds(2).RepeatForever()).Build();



            scheduler.ListenerManager.AddJobListener(new MyJobListen(),GroupMatcher<JobKey>.AnyGroup());

            scheduler.ScheduleJob(job, trigger);

        }
    }
}
